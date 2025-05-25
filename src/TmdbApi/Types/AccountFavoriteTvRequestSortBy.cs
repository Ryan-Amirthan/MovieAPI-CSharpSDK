using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

[JsonConverter(typeof(EnumSerializer<AccountFavoriteTvRequestSortBy>))]
public enum AccountFavoriteTvRequestSortBy
{
    [EnumMember(Value = "created_at.asc")]
    CreatedAtAsc,

    [EnumMember(Value = "created_at.desc")]
    CreatedAtDesc,
}
