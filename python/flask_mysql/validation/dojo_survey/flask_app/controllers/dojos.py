from flask_app import app
from flask import render_template, redirect, request, session
# import the class from friend.py
from flask_app.models.dojo import Dojo

@app.route("/")
def index():

    return render_template("index.html")

@app.route("/add_dojo", methods=["POST"])
def add_dojo():
    if not Dojo.validate_dojo(request.form):
        # redirect to the route where the burger form is rendered.
        return redirect('/')
    # else no errors:
    Dojo.save(request.form)

    session['name'] = request.form['name']
    session['location'] = request.form['location']
    session['language'] = request.form['language']
    session['comment'] = request.form['comment']

    return redirect("/results")

@app.route('/results')
def results():
    return render_template("display_info.html")


@app.route("/home")
def home():

    session.clear()

    return redirect("/")