using Models.Entities;
using RestEase;

namespace Infrastructure.WebApi;

[Header("User-Agent", "Blip.Valores.API")]
public interface IGithubClient
{
    [Get("/orgs/takenet/repos?sort=created&direction=asc&language=C%23")]
    Task<List<GithubRepos>> GetGithubReposAsync();
}
