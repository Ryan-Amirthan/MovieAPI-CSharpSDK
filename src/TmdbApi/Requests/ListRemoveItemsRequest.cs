using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record ListRemoveItemsRequest
{
    [JsonPropertyName("RAW_BODY")]
    public required string RawBody { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
