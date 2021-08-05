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
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

#   add class and static methods here. For example:

    @staticmethod
    def validate_is_email(user):
        is_valid = True # we assume this is true
        if not EMAIL_REGEX.match(user['email']): 
            flash("Invalid email address!")
            is_valid = False
        
        return is_valid

    @staticmethod
    def validate_unique(user, data):
        is_valid = True
        for datum in data:
            if user['email'] == datum['email']:
                flash("Email already exists")
                is_valid = False
        return is_valid

    @classmethod
    def get_all_emails(cls):
        query = "SELECT * FROM emails;"
        return connectToMySQL('email').query_db(query)
    
    @classmethod
    def save(cls, data):
        query = "INSERT INTO emails (email, created_at, updated_at) VALUES (%(email)s, now(), now())"
        return connectToMySQL('email').query_db(query, data)

    @classmethod
    def delete(cls, data):
        query = "DELETE FROM emails WHERE id = %(id)s"
        return connectToMySQL('email').query_db(query, data)


#    @classmethod
#        def save( cls, data):
#        query = "INSERT INTO *table name* ( *column names* ) VALUES ( %( *column values* )s, now(), now() )"
#        return connectToMySQL( '*schema name*' ).query_db(query, data)