# Backend Setup and Configuration (for .NET Web API)

### 1. Prerequisites:
- You need to have .NET Core 6 installed on your system.
- Ensure HTTPS is enabled, as the frontend expects a secure connection.

### 2. Clone the Repository:
- HTTPS: https://github.com/MelissaPleitez/Client_System_Backend.git
- SSH: git@github.com:MelissaPleitez/Client_System_Backend.git

### 3. Configure the Project:
- The project is configured to run on HTTPS by default. The backend uses the URL https://localhost:5001.
Ensure that your machine allows running on this port and that the HTTPS certificate is set up correctly.

### 4. Running the Application: To running, there are two ways to do this
   - By running the following command: dotnet run. This will start the backend server, and you should
     see output in the terminal showing where the application is listening (usually on https://localhost:5001).
   
   - If you're using Visual Studio, you can start the backend by clicking the green "Start" button
    (often labeled with the project's name in this case "Clients_System"). This will launch the backend server and
     automatically open a terminal window where you can see the application’s output, including the URL it’s listening on.

# Assumptions and Notes
     
## CORS Configuration:
- The backend is configured to allow Cross-Origin Resource Sharing (CORS) from any origin. This ensures that the frontend can
communicate with the backend, regardless of where it’s hosted. The CORS policy is defined in the Program.cs, this allows the
frontend application (regardless of the domain) to make requests to the backend.

## Endpoints Overview:
The backend exposes two main API controllers:

### AuthController: 
- POST /api/auth/login: Authenticates a user with an email and password
- Sample request body: {
  "email": "test@test.com",
  "password": "Password123"
}
- If the email and password match the hardcoded values, the API returns a success message.
Example response:
{ "message": "Login Successful" }
Otherwise, it returns an unauthorized error:
{ "message": "Invalid credentials" }


### ClientsController:
- GET /api/clients: Returns a list of clients with their details (name, nationality, occupation, and email).
Example response:
  {
    "name": "Alice Johnson",
    "nationality": "American",
    "occupation": "Engineer",
    "email": "alice@example.com"
  },


## Swagger Documentation:
The backend uses Swagger for API documentation. Once the backend is running, navigate to:
- https://localhost:5001/swagger
This URL will show the Swagger UI where you can test the API endpoints directly.





