from flask_app import app
from flask_app.controllers import users

# import any additional controllers I add to the project here

if __name__ == "__main__":
    app.run(debug=True)