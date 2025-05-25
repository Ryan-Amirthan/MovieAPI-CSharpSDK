using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record AccountTvWatchlistRequest
{
    [JsonIgnore]
    public int? Page { get; set; }

    [JsonIgnore]
    public string? Language { get; set; }

    [JsonIgnore]
    public AccountTvWatchlistRequestSortBy? SortBy { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
