System Requirements
.NET Core SDK: Version 3.1 or later.
IDE: Visual Studio 2019, Visual Studio Code, or equivalent.
SwaggerHub: For API definition and server stub generation.
Postman: For API testing.


1. Project Setup
   Clone the Project
   To obtain the project files, clone the repository from GitHub: https://github.com/YulichkaGa/Israel-Yuli-Project-Rest-Api-From-Yaml.git


2. Install Dependencies
   Ensure all dependencies are correctly installed:


  dotnet restore


3. Environment Setup
   Configure environment variables for JWT in appsettings.json or through your hosting environment:

json
Copy code
"Jwt": {
    "Issuer": "YourIssuer",
    "Audience": "YourAudience",
    "Key": "YourSecretKey"
}

4. Running the Application
   Start the application with the following command:


   dotnet run


5. Security
   The API uses JWT for authentication. Ensure the JWT token is validated against expiration, issuer, and audience.

6. Testing
   Unit Testing
   Implement unit tests using Xunit to test all functionalities. Ensure tests cover all arithmetic operations and authentication mechanisms.

  Integration Testing
  Use Postman or a similar tool to perform end-to-end testing. Automate these tests if possible to include them in your CI/CD pipeline.


7. Documentation and Support
   Code Documentation: Use XML comments for documentation within the codebase.
   API Documentation: Generated via Swagger and available at /swagger on the API server.

