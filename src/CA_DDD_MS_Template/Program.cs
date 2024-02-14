using CA_DDD_MS_Template.API;
using CA_DDD_MS_Template.Application;
using CA_DDD_MS_Template.Domain;
using CA_DDD_MS_Template.Infrastructure;
using Common.Presentation;


WebApplicationBuilder lCA_DDD_MS_TemplateApplicationBuilder = WebApplication.CreateBuilder(args);

await lCA_DDD_MS_TemplateApplicationBuilder.ConfigureInfrastructureAsync();
lCA_DDD_MS_TemplateApplicationBuilder.Services.RegisterDomainServices();
lCA_DDD_MS_TemplateApplicationBuilder.Services.RegisterApplicationServices();
lCA_DDD_MS_TemplateApplicationBuilder.ConfigureCommonPresentation();
lCA_DDD_MS_TemplateApplicationBuilder.ConfigurePresentation();

var lCA_DDD_MS_TemplateApplication = lCA_DDD_MS_TemplateApplicationBuilder.Build();

await lCA_DDD_MS_TemplateApplication.UseInfrastructure();
lCA_DDD_MS_TemplateApplication.UsePresentation();

await lCA_DDD_MS_TemplateApplication.RunAsync();
