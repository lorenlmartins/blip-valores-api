using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using Models.Interfaces.Facades;

namespace Blip.Valores.API.Controllers;

public class GithubReposController(IGithubReposFacade githubReposFacade) : ControllerBase
{
    private const int ZERO_VALUE = 0;

    private readonly IGithubReposFacade _githubReposFacade = githubReposFacade;

    [HttpGet("latest-repos")]
    public async Task<ActionResult<List<GithubRepos>>> GetGithubRepos()
    {
        var repos = await _githubReposFacade.GetGithubReposAsync();
        if (repos.Count is ZERO_VALUE)
        {
            return NotFound();
        }
        return Ok(repos);
    }
}
