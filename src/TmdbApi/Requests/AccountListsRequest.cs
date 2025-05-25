using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

public record AccountListsRequest
{
    [JsonIgnore]
    public int? Page { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
