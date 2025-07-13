# 🌦️ Weather App - REST API Auth Examples 

This repository demonstrates various **authentication strategies** implemented in a simple Weather API using simple Layered Architecture with ASP.NET Core. Each project is built independently to showcase a specific auth mechanism, making it easier for developers to learn and compare implementation patterns.

---

# Authors

## Vishwa Kumar

- **Email:** vishwa@vishwa.me
- **GitHub:** [Vishwam](https://github.com/vishwamkumar)
- **LinkedIn:** [Vishwa Kumar](https://www.linkedin.com/in/vishwamohan)

Vishwa is the primary developer and architect of this example app, responsible for the architecture and implementation of these features.

---

## 🔐 Authentication Styles Covered

| Project | Description |
|--------|-------------|
| `WeatherApp.RestApi.ApiKeyAuth` | Authenticates requests using custom API keys passed via headers. |
| `WeatherApp.RestApi.BasicAuth` | Implements HTTP Basic Authentication (username/password). |
| `WeatherApp.RestApi.JwtAuth` | Uses custom JWT token generation and validation logic. |
| `WeatherApp.RestApi.JwtAuthIdentity` | Leverages ASP.NET Core Identity for JWT authentication and user management. |
| `WeatherApp.RestApi.OAuth2Duende` | Demonstrates OAuth2/OpenID Connect using **Duende IdentityServer**. |

---

## ▶️ Getting Started

Each project contains its own solution and can be run/tested independently.

### Clone the Repository

    ```bash
        git clone https://github.com/vishwamkumar/weather-app.rest-apis.layered.git
        cd weather-app.rest-apis.layered
    ```
---

## ▶️ Run Any Project

    ```bash
       cd WeatherApp.RestApi.JwtAuth
       dotnet run
    ```
---

You can replace JwtAuth with any of the other auth project folders.

## Structure

weather-app.rest-apis.layered/
├── WeatherApp.RestApi.ApiKeyAuth/
├── WeatherApp.RestApi.BasicAuth/
├── WeatherApp.RestApi.JwtAuth/
├── WeatherApp.RestApi.JwtAuthIdentity/
└── WeatherApp.RestApi.OAuth2Duende/

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
