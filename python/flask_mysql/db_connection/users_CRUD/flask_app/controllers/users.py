from flask_app import app
from flask import Flask, render_template, redirect, request, session
# import the class from friend.py
from flask_app.models.user import User

@app.route("/")
def index():
    # call the get all classmethod to get all friends
    users = User.get_all()
    print(users)
    return render_template("index.html", all_users = users)

@app.route("/create_new_user")
def create_page():
    return render_template("create.html")

@app.route('/create_user', methods=["POST"])
def create_user():
    # First we make a data dictionary from our request.form coming from our template.
    # The keys in data need to line up exactly with the variables in our query string.
    data = {
        "fname": request.form["fname"],
        "lname" : request.form["lname"],
        "email" : request.form["email"],
    }
    # We pass the data dictionary into the save method from the Friend class.
    User.save(data)
    # Don't forget to redirect after saving to the database.
    return redirect('/')

@app.route('/read_one/<int:id>')
def read_one(id):
    data = {
        "id": id
    }
    user = User.get_one(data)
    return render_template("read_one.html", user = user)

@app.route('/delete/<int:id>')
def delete_one(id):
    data = {
        'id': id
    }
    User.delete_user(data)
    return redirect("/")

@app.route('/edit/<int:id>')
def edit_page(id):
    data = {
        "id": id
    }
    user = User.get_one(data)
    return render_template("edit_user.html", user=user)

@app.route('/edit_user/<int:id>', methods=['post'])
def edit_user(id):
    data = {
        "fname": request.form["fname"],
        "lname" : request.form["lname"],
        "email" : request.form["email"],
        "id": id
    }
    User.update(data)

    id = data['id']

    return redirect("/read_one/"+str(id))