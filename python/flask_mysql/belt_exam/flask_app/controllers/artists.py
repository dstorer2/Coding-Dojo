from flask_app import app
from flask import render_template, redirect, request, session, flash
from flask_app.models.artist import Artist
from flask_app.models.painting import Painting
from flask_bcrypt import Bcrypt
bcrypt = Bcrypt(app)


#===============================ROUTES=============================

@app.route("/")
def login_reg():


    return render_template("index.html")

#==============================REGISTER=============================

@app.route("/register", methods=['POST'])
def register():

    if not Artist.validate_register(request.form):
        return redirect("/")

    pw_hash = bcrypt.generate_password_hash(request.form['password'])
    print(pw_hash)

    data = {
        "first_name": request.form['first_name'],
        "last_name": request.form['last_name'],
        "email": request.form['email'],
        "password": pw_hash,
    }

    new_user = Artist.save_artist(data)

    session['user_id'] = int(new_user)

    return redirect("/paintings")

    # =====================LOGIN================================

@app.route("/login", methods=['POST'])
def login():

    data = { "email": request.form['email'] }
    print(request.form)
    user_in_db = Artist.get_by_email(data)
    print(user_in_db)
    if not user_in_db:
        flash("Invalid Email/password")
        return redirect("/")

    if not bcrypt.check_password_hash(user_in_db.password, request.form['password']):
        flash("Invalid Email/password")
        return redirect("/")

    session['user_id'] = user_in_db.id

    return redirect("/paintings")

#=======================DASHBOARD=============================

@app.route("/paintings")
def dashboard():

    data = { "id": session['user_id'] }

    artist = Artist.get_artist_info(data)

    paintings = Painting.get_all_paintings()

    return render_template("paintings.html", user = artist, paintings = paintings)

#======================ADD PAINTING=============================

@app.route("/add_painting")
def add_painting():

    return render_template("add_painting.html")

@app.route("/create_painting", methods=['POST'])
def create_painting():

    if not Painting.validate_painting(request.form):
        return redirect("/add_painting")

    data = {
        "title": request.form['title'],
        "description": request.form['description'],
        "price": request.form['price'],
        "artist_id": session['user_id']
    }

    Artist.create_painting(data)

    return redirect("/paintings")

#========================UPDATE PAINTING===================

@app.route("/edit/<int:painting_id>")
def edit_page(painting_id):

    data = { "id": painting_id }

    painting = Painting.get_painting_info(data)

    if not session['user_id'] == painting.artist.id:
        flash("Don't do that. Only edit your own paintings")
        return redirect("/paintings")

    return render_template("edit_painting.html", painting = painting)

@ app.route("/update_painting", methods=['POST'])
def update_painting():

    if not Painting.validate_painting(request.form):
        return redirect("/edit/"+str(request.form['painting_id']))

    data = {
        "id": request.form['painting_id'],
        "title": request.form['title'],
        "description": request.form['description'],
        "price": request.form['price'],
    }

    Painting.edit_painting(data)

    return redirect("/paintings")

#====================DISPLAY==========================

@app.route("/display_painting/<int:painting_id>")
def display(painting_id):

    data = { "id": painting_id }

    painting = Painting.get_painting_info(data)

    return render_template("display_painting.html", painting = painting)

#====================DELETE============================

@app.route("/delete/<int:painting_id>")
def delete(painting_id):

    data = { "id": painting_id }

    painting = Painting.get_painting_info(data)

    if not session['user_id'] == painting.artist.id:
        flash("You cannot delete someone else's paintings. Don't do that.")
        return redirect("/paintings")

    Painting.delete_painting(data)

    return redirect("/paintings")