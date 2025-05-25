using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

[JsonConverter(typeof(EnumSerializer<ListItemStatusRequestMediaType>))]
public enum ListItemStatusRequestMediaType
{
    [EnumMember(Value = "")]
    Empty,

    [EnumMember(Value = "movie")]
    Movie,

    [EnumMember(Value = "tv")]
    Tv,
}
