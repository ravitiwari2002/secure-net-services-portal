# Project Description

This project is a robust web application developed using C#, XML, and .ASP NET. It is designed to provide a secure and efficient user experience.

## Main Features

### Authentication
The application uses cookies to authenticate users. After authentication, it retrieves the username and role of the user.

### Data Security
The application ensures data security through DLL encryption/decryption. It converts strings to and from Base64 during member/staff signup and login.

### User Verification
A Captcha user control is used to verify member signups. It generates a captcha image that the user must match to proceed.

### Data Handling
The application uses XML file manipulation to store and retrieve usernames and passwords of members/staff.

### User Interface
The application includes a default page with descriptions and links to member and staff pages, and a service page containing the services a member uses. It also has separate pages for member signup/login and staff login.

### Additional Services
The application provides additional services like finding the nearest store using Google APIs, currency conversion using the ExchangeRate API, and a 5-day weather forecast using the openweathermap.org API.
