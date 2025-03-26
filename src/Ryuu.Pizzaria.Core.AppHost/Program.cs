var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Ryuu_Pizzaria_Core_Api>("ryuu-pizzaria-core-api");

builder.Build().Run();
