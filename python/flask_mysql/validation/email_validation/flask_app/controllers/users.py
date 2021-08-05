from flask_app import app
from flask import render_template, redirect, request, session
# import any classes from models using the below format
from flask_app.models.user import User

# =========================================
# home route
# =========================================

@app.route("/")
def index():

    return render_template("index.html")


# =========================================
# emample validation route:
# =========================================

@app.route("/add_email", methods=["POST"])
def add_email():
    print("Got to route")
    if not User.validate_is_email(request.form):
        return redirect('/')
    # else no errors:

    all_emails = User.get_all_emails()
    
    if not User.validate_unique(request.form, all_emails):
        return redirect ("/")


    User.save(request.form)



    return redirect("/results")

@app.route("/results")
def results():

    all_emails = User.get_all_emails()
    print(all_emails)

    return render_template("all_users.html", emails = all_emails)

@app.route("/delete/<int:id>")
def delete_email(id):
    data = {
        'id': id
    }

    User.delete(data)

    return redirect("/results")

