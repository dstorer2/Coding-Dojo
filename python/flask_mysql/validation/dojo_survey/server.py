from flask_app import app

from flask_app.controllers.dojos import Dojo


if __name__ == '__main__':
    app.run(debug=True)