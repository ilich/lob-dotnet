using System;

namespace Lob
{
    public class LobClientException : Exception
    {
        public LobClientException(Uri uri, int statusCode, string reason)
        {
            HttpStatusCode = statusCode;
            Uri = uri;
            Reason = reason;

            switch(statusCode)
            {
                case 200:
                    StatusCode = LobStatusCode.Success;
                    break;

                case 401:
                    StatusCode = LobStatusCode.Unauthorized;
                    break;

                case 403:
                    StatusCode = LobStatusCode.Forbidden;
                    break;

                case 404:
                    StatusCode = LobStatusCode.NotFound;
                    break;

                case 422:
                    StatusCode = LobStatusCode.BadRequest;
                    break;

                case 429:
                    StatusCode = LobStatusCode.TooManyRequests;
                    break;

                case 500:
                    StatusCode = LobStatusCode.ServerError;
                    break;

                default:
                    StatusCode = LobStatusCode.Unknown;
                    break;
            }
        }

        public int HttpStatusCode { get; }

        public LobStatusCode StatusCode { get; }

        public Uri Uri { get; }

        public string Reason { get; }
    }

    public enum LobStatusCode
    {
        Success = 200,
        Unauthorized = 401,
        Forbidden = 403,
        NotFound = 404,
        BadRequest = 422,
        TooManyRequests = 429,
        ServerError = 500,
        Unknown = 0
    }
}
