using Template_CA_DDD_MS.API;
using Template_CA_DDD_MS.Application;
using Template_CA_DDD_MS.Domain;
using Template_CA_DDD_MS.Infrastructure;
using Common.Presentation;


WebApplicationBuilder lTemplate_CA_DDD_MSApplicationBuilder = WebApplication.CreateBuilder(args);

await lTemplate_CA_DDD_MSApplicationBuilder.ConfigureInfrastructureAsync();
lTemplate_CA_DDD_MSApplicationBuilder.Services.RegisterDomainServices();
lTemplate_CA_DDD_MSApplicationBuilder.Services.RegisterApplicationServices();
lTemplate_CA_DDD_MSApplicationBuilder.ConfigureCommonPresentation();
lTemplate_CA_DDD_MSApplicationBuilder.ConfigurePresentation();

var lTemplate_CA_DDD_MSApplication = lTemplate_CA_DDD_MSApplicationBuilder.Build();

await lTemplate_CA_DDD_MSApplication.UseInfrastructure();
lTemplate_CA_DDD_MSApplication.UsePresentation();

await lTemplate_CA_DDD_MSApplication.RunAsync();
