using Models.Entities;

namespace Models.Interfaces.Services;

/// <summary>
/// Service to get the C# repositories from the Blip's Github organization.
/// </summary>
public interface IGithubReposService
{
    /// <summary>
    /// Get the latest five C# repositories from the Blip's Github organization.
    /// </summary>
    /// <returns> List of Github repositories </returns>
    Task<List<GithubRepos>> GetGithubReposAsync();
}
