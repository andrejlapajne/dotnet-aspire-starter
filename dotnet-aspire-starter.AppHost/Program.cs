var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedisContainer("cache");

var apiservice = builder.AddProject<Projects.dotnet_aspire_starter_ApiService>("apiservice");

builder.AddProject<Projects.dotnet_aspire_starter_Web>("webfrontend")
    .WithReference(cache)
    .WithReference(apiservice);

builder.Build().Run();
