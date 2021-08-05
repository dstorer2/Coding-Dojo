from flask_app import app
from flask import render_template, redirect, request, session, flash
from flask_app.models.user import User
from flask_app.models.message import Message
from flask_bcrypt import Bcrypt
bcrypt = Bcrypt(app)

@app.route("/")
def login_reg():


    return render_template("index.html")

#==============================REGISTER=============================

@app.route("/register", methods=['POST'])
def register():

    if not User.validate_register(request.form):
        return redirect("/")

    pw_hash = bcrypt.generate_password_hash(request.form['password'])
    print(pw_hash)

    data = {
        "first_name": request.form['first_name'],
        "last_name": request.form['last_name'],
        "email": request.form['email'],
        "password": pw_hash,
    }

    new_user = User.save_user(data)

    session['user_id'] = int(new_user)

    return redirect("/dashboard/"+str(session['user_id']))

#==========================DASHBOARD=============================

@app.route("/dashboard/<int:id>")
def profile_page(id):

    data = {
        "id": id
    }

    all_users = User.get_all_users()

    user = User.get_user_info(data)
    print(user)
    messages = User.get_messages(data)
    print(messages)

    if not messages:
        return render_template("profile.html", user = user, all_users = all_users)


    return render_template("profile.html", messages = messages, user = user, all_users = all_users)

# =====================LOGIN================================

@app.route("/login", methods=['POST'])
def login():

    data = { "email": request.form['email'] }
    print(request.form)
    user_in_db = User.get_by_email(data)
    print(user_in_db)
    if not user_in_db:
        flash("Invalid Email/password")
        return redirect("/")

    if not bcrypt.check_password_hash(user_in_db.password, request.form['password']):
        flash("Invalid Email/password")
        return redirect("/")

    session['user_id'] = user_in_db.id

    return redirect("/dashboard/"+str(session['user_id']))

@app.route("/send_message", methods=['POST'])
def send_message():

    data = {
        "recipient_id": request.form['recipient_id'],
        "user_id": session['user_id'],
        "content": request.form['content'],
    }

    if not User.validate_message(request.form):
        return redirect("dashboard/"+str(session['user_id']))

    User.send_message(data)

    return redirect("/success")

@app.route("/success")
def success():
    return render_template("success.html")

@app.route("/delete", methods=['POST'])
def delete():

    data = {
        "id": request.form['message_id']
    }

    Message.delete(data)

    return redirect("/dashboard/"+str(session['user_id']))

