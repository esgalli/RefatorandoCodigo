using System.Net;
using System.Net.Http;

namespace RefatorandoCodigo.Http
{
    public interface IHttpResponse
    {
        HttpContent Content { get; }
        HttpStatusCode StatusCode { get; }
        bool Success { get; }
    }
}