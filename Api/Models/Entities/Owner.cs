using Newtonsoft.Json;

namespace Models.Entities;

public class Owner
{
    [JsonProperty("avatar_url")]
    public string? AvatarUrl { get; set; }
}
