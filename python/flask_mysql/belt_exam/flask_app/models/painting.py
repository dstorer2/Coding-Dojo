from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import app
from flask_app.models.artist import Artist
from flask import flash

class Painting:
    def __init__(self, data):
        self.id = data['id']
        self.title= data['title']
        self.description = data['description']
        self.price = data['price']
        self.artist_id = data['artist_id']

        self.artist = []

    @staticmethod
    def validate_painting(data):
        is_valid = True
        if len(data['title']) <2:
            flash("Title must be at least 2 characters long")
            is_valid = False
        if len(data['description']) < 10:
            flash("Description must be at least 10 characters long")
            is_valid = False
        if float(data['price']) <= 0:
            flash("Price must be greater than $0")
            is_valid = False
        return is_valid

    @classmethod
    def get_all_paintings(cls):
        query = "SELECT * FROM paintings JOIN artists ON paintings.artist_id = artists.id"
        results = connectToMySQL('artists_paintings').query_db(query)

        paintings = []

        for row_in_db in results:
            one_painting = cls(row_in_db)

            artist_data = {
                "id": row_in_db['artists.id'],
                "first_name": row_in_db['first_name'],
                "last_name": row_in_db['last_name'],
                "email": row_in_db['email'],
                "password": row_in_db['password'],
                "created_at": row_in_db['created_at'],
                "updated_at": row_in_db['updated_at'],
            }

            one_painting.artist = Artist(artist_data)

            paintings.append(one_painting)
        return paintings

    @classmethod
    def get_painting_info(cls, data):
        query = "SELECT * FROM paintings JOIN artists ON paintings.artist_id = artists.id WHERE paintings.id = %(id)s"
        results = connectToMySQL('artists_paintings').query_db(query, data)

        one_painting = cls(results[0])

        artist_data = {
            "id": results[0]['artists.id'],
            "first_name": results[0]['first_name'],
            "last_name": results[0]['last_name'],
            "email": results[0]['email'],
            "password": results[0]['password'],
            "created_at": results[0]['created_at'],
            "updated_at": results[0]['updated_at'],
        }

        one_painting.artist = Artist(artist_data)

        return one_painting

    @classmethod
    def edit_painting(cls, data):
        query = "UPDATE paintings SET title = %(title)s, description = %(description)s, price = %(price)s WHERE id = %(id)s"
        return connectToMySQL('artists_paintings').query_db(query, data)

    @classmethod
    def delete_painting(cls, data):
        query = "DELETE FROM paintings WHERE id = %(id)s"
        return connectToMySQL('artists_paintings').query_db(query, data)