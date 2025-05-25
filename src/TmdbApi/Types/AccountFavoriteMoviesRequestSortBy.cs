using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

[JsonConverter(typeof(EnumSerializer<AccountFavoriteMoviesRequestSortBy>))]
public enum AccountFavoriteMoviesRequestSortBy
{
    [EnumMember(Value = "created_at.asc")]
    CreatedAtAsc,

    [EnumMember(Value = "created_at.desc")]
    CreatedAtDesc,
}
