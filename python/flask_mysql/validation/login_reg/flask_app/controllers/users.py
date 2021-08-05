from flask_app import app
from flask import render_template, redirect, request, session, get_flashed_messages, flash
from datetime import datetime
# import any classes from models using the below format
from flask_app.models.user import User
dateformat = " %m/%d/%Y "
# =========================== Bcrypt password hashing ===============================
# from flask_bcrypt import Bcrypt
# bcrypt = Bcrypt(app)
# ====================== Don't forget to pipenv install flask_bcrypt========================

# app routes go here

# =========================================
# home route
# =========================================

@app.route("/")
def index():


    return render_template("index.html")






# =========================================
# emample validation route:
# =========================================

@app.route("/register", methods=["POST"])
def add_user():

    data = {
        'first_name': request.form['first_name'],
        'last_name': request.form['last_name'],
        'email': request.form['email'],
        'birthday': request.form['birthday'],
        'password': request.form['password'],
    }
    users = User.get_all()

    print(users)

    if not User.validate_user(request.form):
        message = get_flashed_messages()
        print("message", message)
        return redirect('/')
    # else no errors:

    User.save(data)

    session['name'] = request.form['first_name']

    return redirect("/dashboard")

@app.route("/dashboard")
def dashboard():

    return render_template("dashboard.html")


    # if not User.validate_user(request.form):
    #     return redirect('/')
    # # else no errors:
    # User.save(request.form)

    # session['id'] = request.form['id']