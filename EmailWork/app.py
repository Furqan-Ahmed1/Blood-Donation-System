from flask import Flask,jsonify,request,make_response,url_for,redirect
import requests, json
import smtplib
app = Flask(__name__)


@app.route("/", methods = ['POST'])
def email():
    email = request.json['email']
    fname = request.json['first_name']
    lname = request.json['Last_name']
    usertype = request.json['User_type']

    s = smtplib.SMTP('smtp.gmail.com', 587)
  
    # start TLS for security
    s.starttls()
    
    # Authentication
    s.login("iipttesting@gmail.com", "Qwe123!@#")
    
    # message to be sent
    message = "Thank You " + fname+ " " + lname +" for registering in Blood Donation System as a " + usertype

    
    # sending the mail
    s.sendmail("iipttesting@gmail.com", email, message)
    
    # terminating the session
    s.quit()

    return "200"

if __name__ == '__main__':
    app.run(host='127.0.0.1', port=80)