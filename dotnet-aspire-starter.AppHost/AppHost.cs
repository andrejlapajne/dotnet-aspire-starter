var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.dotnet_aspire_starter_ApiService>("apiservice")
    .WithHttpHealthCheck("/health");

builder.AddProject<Projects.dotnet_aspire_starter_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithHttpHealthCheck("/health")
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
