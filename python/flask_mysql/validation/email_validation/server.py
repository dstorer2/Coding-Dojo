from flask_app import app
# import all class models from the controllers here
from flask_app.controllers.users import User



if __name__ == '__main__':
    app.run( debug=True )
