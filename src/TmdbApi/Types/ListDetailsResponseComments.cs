using System.Text.Json;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record ListDetailsResponseComments
{
    [JsonPropertyName("movie:617127")]
    public object? Movie617127 { get; set; }

    [JsonPropertyName("movie:986056")]
    public object? Movie986056 { get; set; }

    [JsonPropertyName("movie:822119")]
    public object? Movie822119 { get; set; }

    [JsonPropertyName("movie:533535")]
    public object? Movie533535 { get; set; }

    [JsonPropertyName("movie:609681")]
    public object? Movie609681 { get; set; }

    [JsonPropertyName("movie:447365")]
    public object? Movie447365 { get; set; }

    [JsonPropertyName("movie:640146")]
    public object? Movie640146 { get; set; }

    [JsonPropertyName("movie:505642")]
    public object? Movie505642 { get; set; }

    [JsonPropertyName("movie:616037")]
    public object? Movie616037 { get; set; }

    [JsonPropertyName("movie:453395")]
    public object? Movie453395 { get; set; }

    [JsonPropertyName("movie:634649")]
    public object? Movie634649 { get; set; }

    [JsonPropertyName("movie:524434")]
    public object? Movie524434 { get; set; }

    [JsonPropertyName("movie:566525")]
    public object? Movie566525 { get; set; }

    [JsonPropertyName("movie:497698")]
    public object? Movie497698 { get; set; }

    [JsonPropertyName("movie:429617")]
    public object? Movie429617 { get; set; }

    [JsonPropertyName("movie:299534")]
    public object? Movie299534 { get; set; }

    [JsonPropertyName("movie:299537")]
    public object? Movie299537 { get; set; }

    [JsonPropertyName("movie:363088")]
    public object? Movie363088 { get; set; }

    [JsonPropertyName("movie:299536")]
    public object? Movie299536 { get; set; }

    [JsonPropertyName("movie:284054")]
    public object? Movie284054 { get; set; }

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
