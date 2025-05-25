# Reference
<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AuthCreateRequestTokenAsync</a>(AuthCreateRequestTokenRequest { ... }) -> AuthCreateRequestTokenResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>


</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AuthCreateRequestTokenAsync(
    new AuthCreateRequestTokenRequest { RawBody = "RAW_BODY" }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuthCreateRequestTokenRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AuthCreateAccessTokenAsync</a>(AuthCreateAccessTokenRequest { ... }) -> AuthCreateAccessTokenResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>


</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AuthCreateAccessTokenAsync(new AuthCreateAccessTokenRequest { RawBody = "RAW_BODY" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuthCreateAccessTokenRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AuthLogoutAsync</a>(AuthLogoutRequest { ... }) -> AuthLogoutResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Log out of a session.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AuthLogoutAsync(new AuthLogoutRequest { RawBody = "RAW_BODY" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `AuthLogoutRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListDetailsAsync</a>(listId, ListDetailsRequest { ... }) -> ListDetailsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Retrieve a list by id.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListDetailsAsync(1, new ListDetailsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `int` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ListDetailsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListUpdateAsync</a>(listId, ListUpdateRequest { ... }) -> ListUpdateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update the details of a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListUpdateAsync(1, new ListUpdateRequest { RawBody = "RAW_BODY" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `int` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ListUpdateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListCreateAsync</a>(ListCreateRequest { ... }) -> ListCreateResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Create a new list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListCreateAsync(new ListCreateRequest { RawBody = "RAW_BODY" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**request:** `ListCreateRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListClearAsync</a>(listId) -> ListClearResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Clear all of the items on a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListClearAsync(1);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `int` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListDeleteAsync</a>(listId) -> ListDeleteResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Delete a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListDeleteAsync(1);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `int` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListAddItemsAsync</a>(listId, ListAddItemsRequest { ... }) -> ListAddItemsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Add items to a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListAddItemsAsync(1, new ListAddItemsRequest { RawBody = "RAW_BODY" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `int` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ListAddItemsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListUpdateItemsAsync</a>(listId, ListUpdateItemsRequest { ... }) -> ListUpdateItemsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Update an individual item on a list
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListUpdateItemsAsync("list_id", new ListUpdateItemsRequest { RawBody = "RAW_BODY" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ListUpdateItemsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListRemoveItemsAsync</a>(listId, ListRemoveItemsRequest { ... }) -> ListRemoveItemsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Remove items from a list
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListRemoveItemsAsync(1, new ListRemoveItemsRequest { RawBody = "RAW_BODY" });
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `int` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ListRemoveItemsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">ListItemStatusAsync</a>(listId, ListItemStatusRequest { ... }) -> ListItemStatusResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Check if an item is on a list.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.ListItemStatusAsync(
    1,
    new ListItemStatusRequest { MediaId = 1, MediaType = ListItemStatusRequestMediaType.Empty }
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**listId:** `int` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `ListItemStatusRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountListsAsync</a>(accountObjectId, AccountListsRequest { ... }) -> AccountListsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get the custom lists that a user has created.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountListsAsync("account_object_id", new AccountListsRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountListsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountFavoriteMoviesAsync</a>(accountObjectId, AccountFavoriteMoviesRequest { ... }) -> AccountFavoriteMoviesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users list of favourite movies.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountFavoriteMoviesAsync("account_object_id", new AccountFavoriteMoviesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountFavoriteMoviesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountFavoriteTvAsync</a>(accountObjectId, AccountFavoriteTvRequest { ... }) -> AccountFavoriteTvResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users list of favourite TV shows.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountFavoriteTvAsync("account_object_id", new AccountFavoriteTvRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountFavoriteTvRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountTvRecommendationsAsync</a>(accountObjectId, AccountTvRecommendationsRequest { ... }) -> AccountTvRecommendationsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users list of recommended TV shows.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountTvRecommendationsAsync(
    "account_object_id",
    new AccountTvRecommendationsRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountTvRecommendationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountMovieRecommendationsAsync</a>(accountObjectId, AccountMovieRecommendationsRequest { ... }) -> AccountMovieRecommendationsResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users list of recommended movies.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountMovieRecommendationsAsync(
    "account_object_id",
    new AccountMovieRecommendationsRequest()
);
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountMovieRecommendationsRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountMovieWatchlistAsync</a>(accountObjectId, AccountMovieWatchlistRequest { ... }) -> AccountMovieWatchlistResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users movie watchlist.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountMovieWatchlistAsync("account_object_id", new AccountMovieWatchlistRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountMovieWatchlistRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountTvWatchlistAsync</a>(accountObjectId, AccountTvWatchlistRequest { ... }) -> AccountTvWatchlistResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users TV watchlist.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountTvWatchlistAsync("account_object_id", new AccountTvWatchlistRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountTvWatchlistRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountRatedMoviesAsync</a>(accountObjectId, AccountRatedMoviesRequest { ... }) -> AccountRatedMoviesResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users rated movies.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountRatedMoviesAsync("account_object_id", new AccountRatedMoviesRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountRatedMoviesRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">AccountRatedTvAsync</a>(accountObjectId, AccountRatedTvRequest { ... }) -> AccountRatedTvResponse</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>

Get a users rated TV shows.
</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.AccountRatedTvAsync("account_object_id", new AccountRatedTvRequest());
```
</dd>
</dl>
</dd>
</dl>

#### ⚙️ Parameters

<dl>
<dd>

<dl>
<dd>

**accountObjectId:** `string` 
    
</dd>
</dl>

<dl>
<dd>

**request:** `AccountRatedTvRequest` 
    
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>

<details><summary><code>client.<a href="/src/TmdbApi/TmdbApiClient.cs">GettingStartedAsync</a>()</code></summary>
<dl>
<dd>

#### 📝 Description

<dl>
<dd>

<dl>
<dd>


</dd>
</dl>
</dd>
</dl>

#### 🔌 Usage

<dl>
<dd>

<dl>
<dd>

```csharp
await client.GettingStartedAsync();
```
</dd>
</dl>
</dd>
</dl>


</dd>
</dl>
</details>
