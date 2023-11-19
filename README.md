# .NET aspire starter application

[.NET Aspire](https://learn.microsoft.com/en-us/dotnet/aspire) default starter application template as presented in the [getting started page](https://learn.microsoft.com/en-us/dotnet/aspire/get-started/quickstart-build-your-first-aspire-app).
The default _.NET Aspire starter application_ template provisions the following 4 projects:

- [ApiService](./dotnet-aspire-starter.ApiService): an API backend service, containing in this example the weather forecast endpoint
- [AppHost](./dotnet-aspire-starter.AppHost): the .NET Aspire host, that defines the orchestration between the services
- [ServiceDefaults](./dotnet-aspire-starter.ServiceDefaults): a .NET Aspire shared project example, that illustrates how to share a common configuration between all services, such as telemetry, logging, etc.
- [Web](.//dotnet-aspire-starter.Web): a Blazor UI web application for the frontend, that invokes the backend services

## Running the application

As stated on the [getting started page](https://learn.microsoft.com/en-us/dotnet/aspire/get-started/quickstart-build-your-first-aspire-app?tabs=dotnet-cli#test-the-app-locally), simply run the following command (requires .NET 8 to be installed first):

    dotnet run --project dotnet-aspire-starter/dotnet-aspire-starter.AppHost

## Screenshots

Here are a few screenshots from the running application and the .NET Aspire dashboard.

### Application

#### Home Page

![Home Page](/doc/home.page.png)

#### Counter Page

![Counter Page](/doc/counter.page.png)

#### Weather Page

![Weather Page](/doc/weather.page.png)

### Dashboard

#### Projects

![Dashboard Projects](/doc/dashboard.projects.png)

#### Containers

![Dashboard Containers](/doc/dashboard.containers.png)

#### Executables

![Dashboard Executables](/doc/dashboard.executables.png)

#### Logs

##### Logs Project

![Logs API service](/doc/dashboard.logs.apiservice.png)
![Logs web frontend](/doc/dashboard.logs.webfrontend.png)

##### Logs Container

![Logs Container](/doc/dashboard.logs.container.png)

##### Logs Executable

![Logs Executable](/doc/dashboard.logs.executable.png)

##### Logs Structured

![Logs Structured](/doc/dashboard.logs.structured.png)

#### Traces

![Dashboard Traces](/doc/dashboard.traces.png)

#### Metrics

![Metrics API service](/doc/dashboard.metrics.apiservice.png)
![Metrics web frontend](/doc/dashboard.metrics.webfrontend.png)
