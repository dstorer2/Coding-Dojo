from flask import Flask, render_template, request, redirect, session
app = Flask(__name__)  
app.secret_key = 'keep it secret, keep it safe'

@app.route('/')         
def index():

    if 'reloads' not in session:
        session['reloads'] = 0
    
    session['reloads'] += 1

    if 'visits' not in session:
        session['visits'] = 0

    session['visits'] += 1
    
    print("Got form info")
    
    print(request.form)
    
    if 'visits' in session:
        print('key exists!')
    else:
        print("key 'key_name' does NOT exist")
    
    return render_template("index.html")

@app.route("/add_two")
def add_two():

    if 'visits' not in session:
        session['visits'] = 0

    session['visits'] += 1

    return redirect("/")

@app.route("/incriment_count", methods=['post'])
def incriment():

    session['count'] = request.form['count']

    print(session['count'])

    if 'visits' not in session:
        session['visits'] = 0

    session['visits'] += int(session['count']) - 1

    return redirect("/")

@app.route('/destroy_session')
def destroy():

    session.clear()
    
    return redirect("/")







if __name__=="__main__":   
    app.run(debug=True)    