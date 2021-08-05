from flask_app import app
from flask import render_template, redirect, request, session
# import the class from friend.py
from flask_app.models.dojo import Dojo

@app.route("/")
def index():

    return render_template("index.html")

@app.route("/result", methods=["POST"])
def info():

    session['name'] = request.form['name']
    session['location'] = request.form['location']
    session['fav_lang'] = request.form['fav_lang']
    session['comment'] = request.form['comment']

    if 'radio1' not in request.form:
        session['radio1'] = 0
    else:
        session['radio1'] = request.form['radio1']    

    if 'box' not in request.form:
        session['box'] = 0
    else:
        session['box'] = request.form['box']

    return render_template("display_info.html")


@app.route("/home")
def home():

    session.clear()

    return redirect("/")