using System.Text.Json;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record AccountTvWatchlistResponseResultsItem
{
    [JsonPropertyName("adult")]
    public bool? Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("original_language")]
    public string? OriginalLanguage { get; set; }

    [JsonPropertyName("original_name")]
    public string? OriginalName { get; set; }

    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }

    [JsonPropertyName("media_type")]
    public string? MediaType { get; set; }

    [JsonPropertyName("genre_ids")]
    public IEnumerable<int>? GenreIds { get; set; }

    [JsonPropertyName("popularity")]
    public double? Popularity { get; set; }

    [JsonPropertyName("first_air_date")]
    public string? FirstAirDate { get; set; }

    [JsonPropertyName("vote_average")]
    public double? VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int? VoteCount { get; set; }

    [JsonPropertyName("origin_country")]
    public IEnumerable<string>? OriginCountry { get; set; }

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
