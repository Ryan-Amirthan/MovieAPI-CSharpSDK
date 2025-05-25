using System.Text.Json;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record AccountFavoriteMoviesResponseResultsItem
{
    [JsonPropertyName("adult")]
    public bool? Adult { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("genre_ids")]
    public IEnumerable<int>? GenreIds { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("original_language")]
    public string? OriginalLanguage { get; set; }

    [JsonPropertyName("original_title")]
    public string? OriginalTitle { get; set; }

    [JsonPropertyName("overview")]
    public string? Overview { get; set; }

    [JsonPropertyName("popularity")]
    public double? Popularity { get; set; }

    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }

    [JsonPropertyName("release_date")]
    public string? ReleaseDate { get; set; }

    [JsonPropertyName("title")]
    public string? Title { get; set; }

    [JsonPropertyName("video")]
    public bool? Video { get; set; }

    [JsonPropertyName("vote_average")]
    public double? VoteAverage { get; set; }

    [JsonPropertyName("vote_count")]
    public int? VoteCount { get; set; }

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
