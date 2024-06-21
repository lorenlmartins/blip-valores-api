using Infrastructure.WebApi;
using Models.Entities;
using Models.Interfaces.Services;

namespace Services;

public class GithubReposService(IGithubClient githubClient) : IGithubReposService
{
    private const string CSHARP_LANGUAGE = "C#";
    private const int LATEST_FIVE_REPOS = 5;
    private const int ZERO_VALUE = 0;

    private readonly IGithubClient _githubClient = githubClient;

    public async Task<List<GithubRepos>> GetGithubReposAsync()
    {
        var repos = await _githubClient.GetGithubReposAsync();
        if (repos.Count is ZERO_VALUE)
        {
            return [];
        }
        return repos.Where(x => x.Language != null && x.Language.Equals(CSHARP_LANGUAGE))
            .Take(LATEST_FIVE_REPOS)
            .ToList();
    }
}
