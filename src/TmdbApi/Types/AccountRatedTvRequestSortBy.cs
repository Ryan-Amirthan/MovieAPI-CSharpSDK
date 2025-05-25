using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using TmdbApi.Core;

namespace TmdbApi;

[JsonConverter(typeof(EnumSerializer<AccountRatedTvRequestSortBy>))]
public enum AccountRatedTvRequestSortBy
{
    [EnumMember(Value = "created_at.asc")]
    CreatedAtAsc,

    [EnumMember(Value = "created_at.desc")]
    CreatedAtDesc,
}
