using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record AccountFavoriteTvRequest
{
    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public string? Language { get; set; }

    [JsonIgnore]
    public AccountFavoriteTvRequestSortBy? SortBy { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
