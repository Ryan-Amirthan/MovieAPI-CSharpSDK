using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record ListDetailsRequest
{
    [JsonIgnore]
    public string? Language { get; set; }

    [JsonIgnore]
    public int? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
