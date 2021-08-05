from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import app
from flask import flash
from flask_bcrypt import Bcrypt
bcrypt = Bcrypt(app)

import re
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

class User:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.password = data['password']


    @staticmethod
    def validate_register(data):
        is_valid = True
        if len(data['first_name']) < 3:
            flash("Name must be at lease 3 characters long")
            is_valid = False
        if len(data['last_name']) < 3:
            flash("Name must be at lease 3 characters long")
            is_valid = False
        if len(data['password']) < 5:
            flash("Please enter a password that is at least 5 characters long")
            is_valid = False
        if data['password'] != data['conf_pass']:
            flash("Password and confirmation password do not match")
            is_valid = False
        if not EMAIL_REGEX.match(data['email']):
            flash("Email must be valid")
            is_valid = False
        return is_valid

    @classmethod
    def save_user(cls, data):
        query = "INSERT INTO users (first_name, last_name, email, password, created_at, updated_at) VALUES (%(first_name)s, %(last_name)s, %(email)s, %(password)s, now(), now())"
        results = connectToMySQL('users_schema').query_db(query, data)
        return results


    @classmethod
    def get_by_email(cls, data):
        query = "SELECT * FROM users WHERE users.email = %(email)s"
        result = connectToMySQL('users_schema').query_db(query, data)
        if len(result) < 1:
            return False
        return cls(result[0])

    @classmethod
    def get_user_info(cls, data):
        query = "SELECT * FROM users WHERE users.id = %(id)s"
        results = connectToMySQL('users_schema').query_db(query, data)
        print(results)
        return results
