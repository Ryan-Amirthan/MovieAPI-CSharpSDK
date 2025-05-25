using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record ListItemStatusRequest
{
    [JsonIgnore]
    public required int MediaId { get; set; }

    [JsonIgnore]
    public required ListItemStatusRequestMediaType MediaType { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
