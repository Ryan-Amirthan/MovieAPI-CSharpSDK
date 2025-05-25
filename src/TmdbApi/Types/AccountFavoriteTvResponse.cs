using System.Text.Json;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record AccountFavoriteTvResponse
{
    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<AccountFavoriteTvResponseResultsItem>? Results { get; set; }

    [JsonPropertyName("total_pages")]
    public int? TotalPages { get; set; }

    [JsonPropertyName("total_results")]
    public int? TotalResults { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
