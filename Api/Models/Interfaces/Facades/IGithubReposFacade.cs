using Models.Entities;

namespace Models.Interfaces.Facades;

/// <summary>
/// Facade to get the C# repositories from the Blip's Github organization.
/// </summary>
public interface IGithubReposFacade
{
    /// <summary>
    /// Get the latest five C# repositories from the Blip's Github organization.
    /// </summary>
    /// <returns> List of Github repositories </returns>
    Task<List<GithubRepos>> GetGithubReposAsync();
}
