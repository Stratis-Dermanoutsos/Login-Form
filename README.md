# Login-Form

This is a full-stack native application bundle that includes both the client and the server applications.

This project was my attempt to learn how to create and use a practical user-handling application with a dedicated database in a native environment.


## Capabilities:
 - ### Client:
   - Login with their existing account
   - Sign up with a new one

 - ### Server:
   - Supports multiple requests
   - Encrypts all passwords registered by default
   - Has full control over the database
     - Edit users' passwords
     - Create new users
     - Remove existing users
   - Has access to detailed logs that take note of all activity

## Changes required to execute the code:
 - ### Server:
   - Form1.cs: 19 :: "Your IP" => You IPv4 address
   - DataHandler.cs: 16 :: "myServerAddress" and "myDatabase"

 - ### Client:
   - FormLogin.cs: 137 :: "Server's IP"
   - FormLogin.cs: 140 :: Add code to execute on successful login
   - FormLogin.cs: 165 :: "Server's IP"

<br><br>
###### This is a bundle that includes 2 separate projects and are to run separately.
###### All frontend and backend is written in C# using WindowsForms.

