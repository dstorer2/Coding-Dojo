from flask_app.config.mysqlconnection import connectToMySQL
from flask import flash
import re
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$') 

# create a class that includes the same attributes as the table you are modelling in the __init__ function

class User:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.birthday = data['birthday']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

#   add class and static methods here.

    @staticmethod
    def validate_user(data):
        is_valid = True # we assume this is true
        if len(data['first_name']) < 3:
            flash("Name must be at least 3 characters")
            is_valid = False
        return is_valid

    @classmethod
    def save(cls, data):
        query = 'INSERT INTO users ( first_name, last_name, email, birthday, password, created_at, updated_at ) VALUES ( %(first_name)s, %(last_name)s, %(email)s, %(birthday)s, %(password)s, now(), now() )'
        return connectToMySQL( 'login_registration' ).query_db(query, data)

    @classmethod
    def get_all(cls):
        query = "SELECT * FROM users"
        return connectToMySQL( 'login_registration' ).query_db(query)