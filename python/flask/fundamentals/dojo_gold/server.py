from flask import Flask, render_template, redirect, session, request
import random
app = Flask(__name__)
app.secret_key = 'keep it secret, keep it safe'


@app.route("/")
def index():

    return render_template("index.html")







if __name__ == '__main__':
    app.run(debug=True)