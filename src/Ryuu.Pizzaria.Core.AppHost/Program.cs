using Projects;

var builder = DistributedApplication.CreateBuilder(args);

// Add PostgreSQL
var postgres = builder.AddPostgres("postgres")
    .WithVolume("pgdata", "/var/lib/postgresql/data");

builder.AddProject<Ryuu_Pizzaria_Core_Api>("ryuu-pizzaria-core-api").WithReference(postgres);

builder.Build().Run();