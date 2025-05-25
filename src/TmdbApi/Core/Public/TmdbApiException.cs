using System;

namespace TmdbApi;

/// <summary>
/// Base exception class for all exceptions thrown by the SDK.
/// </summary>
public class TmdbApiException(string message, Exception? innerException = null)
    : Exception(message, innerException);
