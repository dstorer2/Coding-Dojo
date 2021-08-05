from flask_app.config.mysqlconnection import connectToMySQL

class Book:
    def __init__(self, data):
        self.id = data['book_id']
        self.title = data['title']
        self.num_of_pages = data['num_of_pages']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

        self.favorites = []
    
    @classmethod
    def get_all(cls):
        query = "SELECT * FROM books"
        return connectToMySQL('books_schema').query_db(query)

    @classmethod
    def add_new_book( cls, data):
        print(data)
        query = "INSERT INTO books ( title, num_of_pages, created_at, updated_at) VALUES (%(title)s, %(pages)s, now(), now() )"
        return connectToMySQL('books_schema').query_db(query, data)

    @classmethod
    def add_author_fav(cls, data):
        query = "INSERT INTO favorites (author_id, book_id, created_at, updated_at) VALUES (%(author_id)s, %(book_id)s, now(), now())"
        return connectToMySQL('books_schema').query_db(query, data)

