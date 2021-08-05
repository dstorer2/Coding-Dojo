from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import app
from flask import flash
from flask_bcrypt import Bcrypt
bcrypt = Bcrypt(app)

import re
EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

class Artist:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.email = data['email']
        self.password = data['password']

    @staticmethod
    def validate_register(data):
        is_valid = True
        if len(data['first_name']) < 2:
            flash("Name must be at least 3 characters long")
            is_valid = False
        if len(data['last_name']) < 2:
            flash("Name must be at least 3 characters long")
            is_valid = False
        if len(data['password']) < 8:
            flash("Please enter a password that is at least 8 characters long")
            is_valid = False
        if data['password'] != data['conf_pass']:
            flash("Password and confirmation password do not match")
            is_valid = False
        if not EMAIL_REGEX.match(data['email']):
            flash("Email must be valid")
            is_valid = False
        return is_valid

    @classmethod
    def save_artist(cls, data):
        query = "INSERT INTO artists (first_name, last_name, email, password, created_at, updated_at) VALUES (%(first_name)s, %(last_name)s, %(email)s, %(password)s, now(), now())"
        results = connectToMySQL('artists_paintings').query_db(query, data)
        return results

    @classmethod
    def get_by_email(cls, data):
        query = "SELECT * FROM artists WHERE artists.email = %(email)s"
        result = connectToMySQL('artists_paintings').query_db(query, data)
        if len(result) < 1:
            return False
        return cls(result[0])

    @classmethod
    def get_artist_info(cls, data):
        query = "SELECT * FROM artists WHERE id = %(id)s"
        results = connectToMySQL('artists_paintings').query_db(query, data) 
        return results[0]

    @classmethod
    def create_painting(cls, data):
        query = "INSERT INTO paintings (title, description, price, artist_id, created_at, updated_at) VALUES (%(title)s, %(description)s, %(price)s, %(artist_id)s, now(), now())"
        return connectToMySQL('artists_paintings').query_db(query, data)