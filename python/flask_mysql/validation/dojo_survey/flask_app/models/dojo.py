from flask_app.config.mysqlconnection import connectToMySQL
from flask import flash

class Dojo:
    def __init__(self, data):
        self.id = data['id']
        self.name = data['name']
        self.location = data['location']
        self.language = data['language']
        self.comment = data['comment']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @staticmethod
    def validate_dojo(dojo):
        is_valid = True # we assume this is true
        if len(dojo['name']) < 1:
            flash("Please enter a name for your dojo.")
            is_valid = False
        if dojo['location'] == "null":
            flash("Please select a location")
            is_valid = False
        if dojo['language'] == "null":
            flash("Please select a language")
            is_valid = False
        if len(dojo['comment']) < 1:
            flash("Please enter a comment")
            is_valid = False
        return is_valid

    @classmethod
    def save( cls, data):
        query = "INSERT INTO dojos ( name, location, language, comment, created_at, updated_at ) VALUES ( %(name)s, %(location)s, %(fav_lang)s, %(comment)s, now(), now() )"
        return connectToMySQL('survey').query_db(query, data)

    @classmethod
    def get_dojo_info( cls, data):
        query = "SELECT * FROM dojos WHERE name = %(name)s"
        return connectToMySQL('survey').query_db(query, data)