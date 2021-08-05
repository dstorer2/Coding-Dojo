from flask_app import app
from flask import render_template, redirect, request
# import the class from friend.py
from flask_app.model.book import Book


@app.route('/new_book')
def book_page():

    books = Book.get_all()

    return render_template("books.html", all_books = books)

@app.route('/add_book', methods=['POST'])
def add_book():

    data = {
        "title": request.form['title'],
        "pages": int(request.form['pages']),
    }

    Book.add_new_book(data)

    return redirect("/success/book")

@app.route("/success/book")
def success_book():

    return render_template("success_book.html")



