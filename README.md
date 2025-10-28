# ServiceContextDemo

A minimal .NET 8 ASP.NET Core Web API showcasing a per-request service context via middleware and simple DI-driven services.

## What it includes
- `ServiceContext` and `ServiceContextMiddleware` for storing/request-scoped data.
- `GreetingController` with a demo endpoint using `IGreetingService`/`GreetingService`.
- `SingletonService` example registered in DI.
- Default `WeatherForecast` sample endpoint.
- Swagger/OpenAPI enabled for easy exploration.

## Quick start
1. Prerequisites: .NET 8 SDK
2. Run the app:
   ```bash
   dotnet run
   ```
3. Open Swagger UI in your browser at `/swagger` (use the port shown in the console).

## Endpoints (demo)
- `GET /greet?name=YourName` — returns a greeting built with the request service context.
- `GET /weatherforecast` — sample data endpoint.

## Project layout
- `Program.cs` — app setup, DI registration, middleware pipeline, Swagger.
- `ServiceContext.cs` / `ServiceContextMiddleware.cs` — request context model and middleware.
- `Services/` — `IGreetingService`, `GreetingService`, `SingletonService`.
- `Controllers/GreetingController.cs` — greeting API.

## Notes
- Configuration: `appsettings.json` and environment-specific overrides.
- HTTP file: `ServiceContextDemo.http` has sample requests for local testing.
