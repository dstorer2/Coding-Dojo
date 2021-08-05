from flask_app.config.mysqlconnection import connectToMySQL
from flask_app.model.book import Book

class Author:
    def __init__(self, data):
        self.id = data['author_id']
        self.name = data['name']
        self.created_at = data['created_at']
        self.updated_at = data['updated_at']

        self.favorites = []
    
    @classmethod
    def get_all(cls):
        query = "SELECT * FROM authors"
        return connectToMySQL('books_schema').query_db(query)

    @classmethod
    def add_new_author( cls, data):
        print(data)
        query = "INSERT INTO authors ( name, created_at, updated_at) VALUES (%(name)s, now(), now() )"
        return connectToMySQL('books_schema').query_db(query, data)

    @classmethod
    def get_author_favs( cls, data):
        query = "SELECT books.title, books.num_of_pages FROM authors LEFT JOIN favorites ON authors.id = favorites.author_id LEFT JOIN books ON favorites.book_id = books.id WHERE authors.id = %(id)s"
        return  connectToMySQL('books_schema').query_db(query, data)

    @classmethod
    def get_author_info( cls, data ):
        query = "SELECT * FROM authors JOIN favorites ON authors.id = favorites.author_id JOIN books ON favorites.book_id = books.id WHERE authors.id = %(id)s"
        results = connectToMySQL('books_schema').query_db(query, data)
        print(results)
        author = cls(results[0])
        for row_in_db in results:
            data = {
                "book_id": row_in_db['book_id'],
                "title": row_in_db['title'],
                "num_of_pages": row_in_db['num_of_pages'],
                "created_at": row_in_db['books.created_at'],
                "updated_at": row_in_db['books.updated_at'],
            }
            author.favorites.append(Book(data))
        return author

    @classmethod
    def get_book_favs(cls, data):
        query = "SELECT * FROM books JOIN favorites ON books.id = favorites.book_id JOIN authors ON favorites.author_id = authors.id WHERE books.id = %(book_id)s"
        results = connectToMySQL('books_schema').query_db(query, data)
        print(results[0])
        book = Book(results[0])
        for row_in_db in results:
            data = {
                "author_id": row_in_db['author_id'],
                "name": row_in_db['name'],
                "created_at": row_in_db['authors.created_at'],
                "updated_at": row_in_db['authors.updated_at'],
            }
            book.favorites.append(Author(data))
        return book
