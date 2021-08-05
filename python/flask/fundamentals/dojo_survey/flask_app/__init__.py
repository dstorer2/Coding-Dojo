from flask import Flask, render_template, redirect, session, request
app = Flask(__name__)
app.secret_key = "blahblahblahblahblah"