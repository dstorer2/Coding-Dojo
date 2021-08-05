from flask_app import app
from flask import render_template, redirect, request
# import the class from friend.py
from flask_app.model.author import Author
from flask_app.model.book import Book

@app.route('/authors')
def main_page():

    authors = Author.get_all()

    return render_template("index.html", all_authors = authors)

@app.route('/new_author', methods=['POST'])
def add_author():

    data = {
        "name": request.form['author_name']
    }

    Author.add_new_author(data)

    return redirect("/success/author")

@app.route("/success/author")
def success_author():

    return render_template("success_author.html")

@app.route("/view_author/<int:id>")
def display_one_author(id):
    data = {
        "id": id
    }

    all_books = Book.get_all()

    author = Author.get_author_info(data)

    return render_template("author_info.html", author = author, all_books = all_books)

@app.route("/add_author_fav/<int:author_id>", methods=['POST'])
def create_auth_fav(author_id):
    data = {
        "author_id": author_id,
        "book_id": request.form['book_id']
    }

    Book.add_author_fav(data)

    return redirect("/view_author/"+str(author_id))

@app.route("/view_book/<int:book_id>")
def display_one_book(book_id):
    data = {
        "book_id": book_id
    }

    all_authors = Author.get_all()

    book = Author.get_book_favs(data)

    return render_template("book_info.html", authors = all_authors, book = book)

@app.route("/add_book_fav/<int:book_id>", methods=['POST'])
def add_book_fav(book_id):
    data = {
        'author_id': request.form['author_id'],
        'book_id': book_id
    }

    Book.add_author_fav(data)

    return redirect("/view_book/"+str(book_id))




