using System.Text.Json;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record AccountListsResponseResultsItem
{
    [JsonPropertyName("account_object_id")]
    public string? AccountObjectId { get; set; }

    [JsonPropertyName("adult")]
    public int? Adult { get; set; }

    [JsonPropertyName("average_rating")]
    public double? AverageRating { get; set; }

    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("featured")]
    public int? Featured { get; set; }

    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("iso_3166_1")]
    public string? Iso31661 { get; set; }

    [JsonPropertyName("iso_639_1")]
    public string? Iso6391 { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("number_of_items")]
    public int? NumberOfItems { get; set; }

    [JsonPropertyName("public")]
    public int? Public { get; set; }

    [JsonPropertyName("revenue")]
    public string? Revenue { get; set; }

    [JsonPropertyName("runtime")]
    public int? Runtime { get; set; }

    [JsonPropertyName("sort_by")]
    public int? SortBy { get; set; }

    [JsonPropertyName("updated_at")]
    public string? UpdatedAt { get; set; }

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
