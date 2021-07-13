from flask import Flask, render_template
from werkzeug.exceptions import RequestedRangeNotSatisfiable  # Import Flask to allow us to create our app
app = Flask(__name__)    # Create a new instance of the Flask class called "app"

@app.route('/')
def index():
    return render_template("index.html", nothing = "")


@app.route('/play/<int:times>')
def index2(times):
    return render_template('index.html', times = times, nothing = ".")


@app.route('/play/<int:times>/<string:color>')
def index3(times, color):
    return render_template('index.html', times = times, color = color, nothing = "..")





if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.