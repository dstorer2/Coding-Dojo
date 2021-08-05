from flask_app.config.mysqlconnection import connectToMySQL
from flask_app import app
from flask import flash


class Message:
    def __init__(self, data):
        self.id = data['id']
        self.user_id = data['user_id']
        self.recipient_id = data['recipient_id']
        self.content = data['content']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

    @classmethod
    def delete(cls, data):
        query = "DELETE FROM messages WHERE id = %(message_id)s"
        return connectToMySQL('private_wall').query_db(query, data)