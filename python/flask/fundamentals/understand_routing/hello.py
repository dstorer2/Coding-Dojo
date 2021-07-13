from flask import Flask
app = Flask(__name__)


@app.route('/')
def hello_world():
    return 'Hello World!'

@app.route('/dojo')
def dojo():
    return 'Dojo'

@app.route('/say/<name>')
def say_hi(name):
    print(type(name))
    return f"Hi {str(name)}!"

@app.route('/repeat/<int:num>/<string:name>')
def repeat(num, name):
    return (name + " ")*num

@app.route('/<otherroute>')
def wrongTurn(otherroute):
    return "Ope! Sorry! No response for this route :/ Please try another one! Maybe something like '/say/*your name here*' or '/dojo'! "







if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.