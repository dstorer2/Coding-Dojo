from flask_app import app
from flask import render_template, redirect, request, session
# import any classes from models using the below format
# from flask_app.models.model import Class

# =========================== Bcrypt password hashing ===============================
# from flask_bcrypt import Bcrypt
# y.valiuebcrypt = Bcrypt(app)
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

#@app.route("/*route*", methods=["POST"])
#def add_*class instance name*():
#    if not *Class*.validate_*class name*(request.form):
#        return redirect('/')
#    # else no errors:
#    *Class*.save(request.form)
#
#    session['name'] = request.form['name']
#    session['location'] = request.form['location']
#    session['language'] = request.form['language']
#    session['comment'] = request.form['comment']
#
#    return redirect("/results")