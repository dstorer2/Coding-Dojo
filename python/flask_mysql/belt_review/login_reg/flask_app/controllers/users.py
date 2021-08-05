from flask_app import app
from flask import render_template, redirect, request, session, flash
from flask_app.models.user import User
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

    User.save_user(data)

    session['first_name'] = request.form['first_name']

    return redirect("/success")


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

    session['first_name'] = user_in_db.first_name

    return redirect("/success")

#======================SUCCESS=================

@app.route("/success")
def success():

    if not session:
        flash("Don't do that. Please register or login before accessing the main page.")
        return redirect("/")

    return render_template("success.html")

#==================LOGOFF========================

@app.route("/logoff")
def logoff():

    session.clear()

    return redirect("/")

