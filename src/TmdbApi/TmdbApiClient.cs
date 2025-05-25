using System.Net.Http;
using System.Text.Json;
using System.Threading;
using global::System.Threading.Tasks;
using TmdbApi.Core;

namespace TmdbApi;

public partial class TmdbApiClient
{
    private readonly RawClient _client;

    public TmdbApiClient(string? apiKey = null, ClientOptions? clientOptions = null)
    {
        var defaultHeaders = new Headers(
            new Dictionary<string, string>()
            {
                { "Authorization", $"Bearer {apiKey}" },
                { "X-Fern-Language", "C#" },
                { "X-Fern-SDK-Name", "TmdbApi" },
                { "X-Fern-SDK-Version", Version.Current },
                { "User-Agent", "Imdb.Net/1.0.0" },
            }
        );
        clientOptions ??= new ClientOptions();
        foreach (var header in defaultHeaders)
        {
            if (!clientOptions.Headers.ContainsKey(header.Key))
            {
                clientOptions.Headers[header.Key] = header.Value;
            }
        }
        _client = new RawClient(clientOptions);
    }

    /// <example><code>
    /// await client.AuthCreateRequestTokenAsync(
    ///     new AuthCreateRequestTokenRequest { RawBody = "RAW_BODY" }
    /// );
    /// </code></example>
    public async Task<AuthCreateRequestTokenResponse> AuthCreateRequestTokenAsync(
        AuthCreateRequestTokenRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "4/auth/request_token",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AuthCreateRequestTokenResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <example><code>
    /// await client.AuthCreateAccessTokenAsync(new AuthCreateAccessTokenRequest { RawBody = "RAW_BODY" });
    /// </code></example>
    public async Task<AuthCreateAccessTokenResponse> AuthCreateAccessTokenAsync(
        AuthCreateAccessTokenRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "4/auth/access_token",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AuthCreateAccessTokenResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Log out of a session.
    /// </summary>
    /// <example><code>
    /// await client.AuthLogoutAsync(new AuthLogoutRequest { RawBody = "RAW_BODY" });
    /// </code></example>
    public async Task<AuthLogoutResponse> AuthLogoutAsync(
        AuthLogoutRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path = "4/auth/access_token",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AuthLogoutResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Retrieve a list by id.
    /// </summary>
    /// <example><code>
    /// await client.ListDetailsAsync(1, new ListDetailsRequest());
    /// </code></example>
    public async Task<ListDetailsResponse> ListDetailsAsync(
        int listId,
        ListDetailsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format("4/list/{0}", ValueConvert.ToPathParameterString(listId)),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListDetailsResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Update the details of a list.
    /// </summary>
    /// <example><code>
    /// await client.ListUpdateAsync(1, new ListUpdateRequest { RawBody = "RAW_BODY" });
    /// </code></example>
    public async Task<ListUpdateResponse> ListUpdateAsync(
        int listId,
        ListUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Put,
                    Path = string.Format("4/list/{0}", ValueConvert.ToPathParameterString(listId)),
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListUpdateResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Create a new list.
    /// </summary>
    /// <example><code>
    /// await client.ListCreateAsync(new ListCreateRequest { RawBody = "RAW_BODY" });
    /// </code></example>
    public async Task<ListCreateResponse> ListCreateAsync(
        ListCreateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "4/list",
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListCreateResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Clear all of the items on a list.
    /// </summary>
    /// <example><code>
    /// await client.ListClearAsync(1);
    /// </code></example>
    public async Task<ListClearResponse> ListClearAsync(
        int listId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/list/{0}/clear",
                        ValueConvert.ToPathParameterString(listId)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListClearResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Delete a list.
    /// </summary>
    /// <example><code>
    /// await client.ListDeleteAsync(1);
    /// </code></example>
    public async Task<ListDeleteResponse> ListDeleteAsync(
        int listId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path = string.Format("4/{0}", ValueConvert.ToPathParameterString(listId)),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListDeleteResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Add items to a list.
    /// </summary>
    /// <example><code>
    /// await client.ListAddItemsAsync(1, new ListAddItemsRequest { RawBody = "RAW_BODY" });
    /// </code></example>
    public async Task<ListAddItemsResponse> ListAddItemsAsync(
        int listId,
        ListAddItemsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = string.Format(
                        "4/list/{0}/items",
                        ValueConvert.ToPathParameterString(listId)
                    ),
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListAddItemsResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Update an individual item on a list
    /// </summary>
    /// <example><code>
    /// await client.ListUpdateItemsAsync("list_id", new ListUpdateItemsRequest { RawBody = "RAW_BODY" });
    /// </code></example>
    public async Task<ListUpdateItemsResponse> ListUpdateItemsAsync(
        string listId,
        ListUpdateItemsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "4/list/{0}/items",
                        ValueConvert.ToPathParameterString(listId)
                    ),
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListUpdateItemsResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Remove items from a list
    /// </summary>
    /// <example><code>
    /// await client.ListRemoveItemsAsync(1, new ListRemoveItemsRequest { RawBody = "RAW_BODY" });
    /// </code></example>
    public async Task<ListRemoveItemsResponse> ListRemoveItemsAsync(
        int listId,
        ListRemoveItemsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "4/list/{0}/items",
                        ValueConvert.ToPathParameterString(listId)
                    ),
                    Body = request,
                    ContentType = "application/json",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListRemoveItemsResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Check if an item is on a list.
    /// </summary>
    /// <example><code>
    /// await client.ListItemStatusAsync(
    ///     1,
    ///     new ListItemStatusRequest { MediaId = 1, MediaType = ListItemStatusRequestMediaType.Empty }
    /// );
    /// </code></example>
    public async Task<ListItemStatusResponse> ListItemStatusAsync(
        int listId,
        ListItemStatusRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["media_id"] = request.MediaId.ToString();
        _query["media_type"] = request.MediaType.Stringify();
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/list/{0}/item_status",
                        ValueConvert.ToPathParameterString(listId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ListItemStatusResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get the custom lists that a user has created.
    /// </summary>
    /// <example><code>
    /// await client.AccountListsAsync("account_object_id", new AccountListsRequest());
    /// </code></example>
    public async Task<AccountListsResponse> AccountListsAsync(
        string accountObjectId,
        AccountListsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/lists",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountListsResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users list of favourite movies.
    /// </summary>
    /// <example><code>
    /// await client.AccountFavoriteMoviesAsync("account_object_id", new AccountFavoriteMoviesRequest());
    /// </code></example>
    public async Task<AccountFavoriteMoviesResponse> AccountFavoriteMoviesAsync(
        string accountObjectId,
        AccountFavoriteMoviesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/movie/favorites",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountFavoriteMoviesResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users list of favourite TV shows.
    /// </summary>
    /// <example><code>
    /// await client.AccountFavoriteTvAsync("account_object_id", new AccountFavoriteTvRequest());
    /// </code></example>
    public async Task<AccountFavoriteTvResponse> AccountFavoriteTvAsync(
        string accountObjectId,
        AccountFavoriteTvRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/tv/favorites",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountFavoriteTvResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users list of recommended TV shows.
    /// </summary>
    /// <example><code>
    /// await client.AccountTvRecommendationsAsync(
    ///     "account_object_id",
    ///     new AccountTvRecommendationsRequest()
    /// );
    /// </code></example>
    public async Task<AccountTvRecommendationsResponse> AccountTvRecommendationsAsync(
        string accountObjectId,
        AccountTvRecommendationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/tv/recommendations",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountTvRecommendationsResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users list of recommended movies.
    /// </summary>
    /// <example><code>
    /// await client.AccountMovieRecommendationsAsync(
    ///     "account_object_id",
    ///     new AccountMovieRecommendationsRequest()
    /// );
    /// </code></example>
    public async Task<AccountMovieRecommendationsResponse> AccountMovieRecommendationsAsync(
        string accountObjectId,
        AccountMovieRecommendationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/movie/recommendations",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountMovieRecommendationsResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users movie watchlist.
    /// </summary>
    /// <example><code>
    /// await client.AccountMovieWatchlistAsync("account_object_id", new AccountMovieWatchlistRequest());
    /// </code></example>
    public async Task<AccountMovieWatchlistResponse> AccountMovieWatchlistAsync(
        string accountObjectId,
        AccountMovieWatchlistRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/movie/watchlist",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountMovieWatchlistResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users TV watchlist.
    /// </summary>
    /// <example><code>
    /// await client.AccountTvWatchlistAsync("account_object_id", new AccountTvWatchlistRequest());
    /// </code></example>
    public async Task<AccountTvWatchlistResponse> AccountTvWatchlistAsync(
        string accountObjectId,
        AccountTvWatchlistRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/tv/watchlist",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountTvWatchlistResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users rated movies.
    /// </summary>
    /// <example><code>
    /// await client.AccountRatedMoviesAsync("account_object_id", new AccountRatedMoviesRequest());
    /// </code></example>
    public async Task<AccountRatedMoviesResponse> AccountRatedMoviesAsync(
        string accountObjectId,
        AccountRatedMoviesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/movie/rated",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountRatedMoviesResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Get a users rated TV shows.
    /// </summary>
    /// <example><code>
    /// await client.AccountRatedTvAsync("account_object_id", new AccountRatedTvRequest());
    /// </code></example>
    public async Task<AccountRatedTvResponse> AccountRatedTvAsync(
        string accountObjectId,
        AccountRatedTvRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Page != null)
        {
            _query["page"] = request.Page.Value.ToString();
        }
        if (request.Language != null)
        {
            _query["language"] = request.Language;
        }
        if (request.SortBy != null)
        {
            _query["sort_by"] = request.SortBy.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "4/account/{0}/tv/rated",
                        ValueConvert.ToPathParameterString(accountObjectId)
                    ),
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<AccountRatedTvResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new TmdbApiException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <example><code>
    /// await client.GettingStartedAsync();
    /// </code></example>
    public async global::System.Threading.Tasks.Task GettingStartedAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.BaseUrl,
                    Method = HttpMethod.Post,
                    Path = "",
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new TmdbApiApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
