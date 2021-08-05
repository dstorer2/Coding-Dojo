from flask_app import app
from flask import render_template, redirect, request, session
from flask_app.models.user import User

@app.route("/")
def main_page():

    table_data = User.all_friendships()
    print(table_data)

    users = User.all_users()

    return render_template("index.html", friendships = table_data, users = users)

@app.route("/add_friendship", methods=["POST"])
def create_friendship():

    data = {
        "user": request.form['user'],
        "friend": request.form['friend']
    }

    User.create_friendship(data)

    return redirect("/success")

@app.route("/success")
def success():
    return redirect("/")

@app.route("/add_user", methods=['POST'])
def add_user():

    data = {
        "first_name": request.form['first_name'],
        "last_name": request.form['last_name'],
    }

    session['name'] = request.form['first_name']

    User.add_user(data)

    return redirect("/successful_add")

@app.route("/successful_add")
def successful():

    return render_template("success.html")