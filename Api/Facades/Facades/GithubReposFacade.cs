using Models.Entities;
using Models.Interfaces.Facades;
using Models.Interfaces.Services;

namespace Facades.Facades;

public class GithubReposFacade(IGithubReposService githubReposService) : IGithubReposFacade
{
    private readonly IGithubReposService _githubReposService = githubReposService;

    public async Task<List<GithubRepos>> GetGithubReposAsync()
        => await _githubReposService.GetGithubReposAsync();
}
