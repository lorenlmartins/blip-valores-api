using Facades.Facades;
using Infrastructure.WebApi;
using Microsoft.Extensions.DependencyInjection;
using Models.Interfaces.Facades;
using Models.Interfaces.Services;
using RestEase;
using Services;

namespace Facades.Extensions;

public static class ServiceCollectionsExtensions
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddSingleton(RestClient.For<IGithubClient>("https://api.github.com"));
        services.AddScoped<IGithubReposService, GithubReposService>();
        services.AddScoped<IGithubReposFacade, GithubReposFacade>();
        return services;
    }
}
