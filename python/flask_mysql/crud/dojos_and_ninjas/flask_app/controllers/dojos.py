from flask_app import app
from flask import render_template, redirect, request
# import the class from friend.py
from flask_app.model.dojo import Dojo
from flask_app.model.ninja import Ninja

@app.route("/dojos")
def index():
    dojos = Dojo.get_all()
    print(dojos)

    return render_template("index.html", all_dojos = dojos)

@app.route("/view_dojo/<int:id>")
def dojo_page(id):
    data = {
        "dojo_id": id
    }

    dojo = Dojo.get_ninjas_in_dojo(data)
    

    return render_template("show_dojo.html", all_ninjas_in_dojo = dojo)

@ app.route("/new_ninja")
def new_ninja():

    dojos = Dojo.get_all()

    return render_template("create_ninja.html", all_dojos = dojos)


