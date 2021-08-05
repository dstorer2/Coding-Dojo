from flask_app import app
from flask import render_template, redirect, request, session
from flask_app.config.mysqlconnection import connectToMySQL

class User:
    def __init__(self, data):
        self.id = data['id']
        self.first_name = data['first_name']
        self.last_name = data['last_name']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @classmethod
    def all_friendships(cls):
        query = "SELECT users.first_name AS first_name, users.last_name AS last_name, user2.first_name AS friend_first_name, user2.last_name AS friend_last_name FROM users JOIN friendships ON users.id = friendships.user_id LEFT JOIN users AS user2 ON  user2.id = friendships.user_id1"
        return connectToMySQL('friendships_schema').query_db(query)
        

    @classmethod
    def all_users(cls):
        query = "SELECT * FROM users"
        return connectToMySQL('friendships_schema').query_db(query)

    @classmethod
    def create_friendship(cls, data):
        query = "INSERT INTO friendships (user_id, user_id1, created_at, updated_at) VALUES (%(user)s, %(friend)s, now(), now())"
        return connectToMySQL('friendships_schema').query_db(query, data)

    @classmethod
    def add_user(cls, data):
        query = "INSERT INTO users (first_name, last_name, created_at, updated_at) VALUES (%(first_name)s, %(last_name)s, now(), now())"
        return connectToMySQL('friendships_schema').query_db(query, data)