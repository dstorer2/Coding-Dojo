from flask import Flask, render_template, redirect, session, request
import random
app = Flask(__name__)
app.secret_key = 'keep it secret, keep it safe'


@app.route("/")
def index():

    if "count" not in session:
        session['count'] = 0

    if "theNumber" not in session:
        session['theNumber'] = int(random.randint(1, 100))
        

    print(session['theNumber'])

    return render_template("index.html")

@app.route("/guess", methods=['POST'])
def guess():

    if int(request.form['guess']) > int(session['theNumber']):
        session['output'] = "That's too high!"
        session['color'] = "red"
        session['count'] += 1
    elif int(request.form['guess']) < int(session['theNumber']):
        session['output'] = "That's too low!"
        session['color'] = "red"
        session['count'] += 1
    elif int(request.form['guess']) == int(session['theNumber']):
        session['count'] += 1
        session['output'] = str(session['theNumber']) + " was the number!"
        session['color'] = "green"
    
    return redirect("/")

@app.route("/destroy_session", methods=['POST'])
def new_game():

    session.clear()

    return redirect("/")


if __name__ == '__main__':
    app.run(debug=True)