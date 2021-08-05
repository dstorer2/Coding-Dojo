from flask_app import app
from flask import render_template, redirect, request
# import the class from friend.py
from flask_app.model.ninja import Ninja

@app.route("/create_ninja", methods=['POST'])
def create_ninja():
    print(request.form['dojo_id'])
    data = {
        "dojo_id": request.form['dojo_id'],
        "fname": request.form['fname'],
        "lname": request.form['lname'],
        "age": request.form['age'],
    }
    print(data)
    id = data['dojo_id']
    Ninja.create_new(data)
    
    print(data)
    return redirect("/view_dojo/"+str(id))
