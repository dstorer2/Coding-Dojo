from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)
app.secret_key = 'keep it secret, keep it safe' # set a secret key for security

@app.route('/')
def index():
    return render_template("index.html")

@app.route('/users', methods=['POST'])
def create_user():
    print("Got Post Info")
    print(request.form)
    session['name'] = request.form['name']
    session['email'] = request.form['name']


    return redirect("/show")

@app.route('/show')
def show_user():
    print("Showing the User Info From the Form")
    print(request.form)
    return render_template("show.html", name_on_template = session['name'], email_on_template = session['email'])


if __name__=="__main__":
    app.run(debug=True)