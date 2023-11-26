# SecureNet Services Portal

SecureNet Services Portal is a comprehensive web application developed using C#, XML, and .ASP NET. The application is designed to provide a secure, efficient, and user-friendly experience.

## Features

### Authentication and Access Control

The application uses cookies for user authentication. After successful authentication, it retrieves the user's username and role. Access to different pages is controlled based on the user's role and login status.

### Data Security

Data security is ensured through DLL encryption/decryption. The application converts strings to and from Base64 during member/staff signup and login, ensuring that sensitive information is securely handled.

### User Verification

User verification is implemented using a Captcha user control during member signups. This feature generates a captcha image that the user must match to proceed with the signup process.

### Data Handling

The application uses XML file manipulation for storing and retrieving usernames and passwords of members and staff. This ensures efficient data handling and retrieval.

### User Interface

The application provides a user-friendly interface with a default page containing descriptions and links to member and staff pages, a service page containing the services a member can use, and separate pages for member signup/login and staff login.

### Additional Services

The application offers additional services like finding the nearest store using Google APIs, currency conversion using the ExchangeRate API, and a 5-day weather forecast using the openweathermap.org API.

### Service Directory

The application includes a comprehensive Service Directory listing all the components and services used in the application. Each entry in the directory includes the provider name, component type, operation name, parameters and their types, return type, function description, and a link to a TryIt page or an item in the web presentation layer GUI.

### Member and Staff Pages

The Member page allows users to register (self-subscribe) to access the services offered by the application. The Staff page allows the administrator to add staff members and view the number of members. Access to these pages is controlled based on the user's role and login status.
