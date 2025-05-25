using System.Text.Json;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record ListDetailsResponse
{
    [JsonPropertyName("average_rating")]
    public double? AverageRating { get; set; }

    [JsonPropertyName("backdrop_path")]
    public string? BackdropPath { get; set; }

    [JsonPropertyName("results")]
    public IEnumerable<ListDetailsResponseResultsItem>? Results { get; set; }

    [JsonPropertyName("comments")]
    public ListDetailsResponseComments? Comments { get; set; }

    [JsonPropertyName("created_by")]
    public ListDetailsResponseCreatedBy? CreatedBy { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("iso_3166_1")]
    public string? Iso31661 { get; set; }

    [JsonPropertyName("iso_639_1")]
    public string? Iso6391 { get; set; }

    [JsonPropertyName("item_count")]
    public int? ItemCount { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("object_ids")]
    public ListDetailsResponseObjectIds? ObjectIds { get; set; }

    [JsonPropertyName("page")]
    public int? Page { get; set; }

    [JsonPropertyName("poster_path")]
    public string? PosterPath { get; set; }

    [JsonPropertyName("public")]
    public bool? Public { get; set; }

    [JsonPropertyName("revenue")]
    public int? Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }

    [JsonPropertyName("sort_by")]
    public string? SortBy { get; set; }

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
