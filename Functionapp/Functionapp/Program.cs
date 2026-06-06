using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

// starting point of Azure Function App — same as Program.cs in Web API
var builder = FunctionsApplication.CreateBuilder(args);

builder.ConfigureFunctionsWebApplication();
builder.Services
	.AddApplicationInsightsTelemetryWorkerService()
	.ConfigureFunctionsApplicationInsights();
builder.Build().Run();