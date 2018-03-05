using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;

namespace Bitaqati.iOS
{
    public class MessageHandler : HttpClientHandler
    {
        private const string URL_API_CODE_VALUE = "SS1";
        private const string URL_API_CODE_KEY = "apiCode";
        private string _Token = string.Empty;


        public MessageHandler()
        {

        }

        public MessageHandler(string token)
        {
            _Token = token;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", string.Format("Bearer {0}", _Token));
            request.Headers.Add(URL_API_CODE_KEY, URL_API_CODE_VALUE);
            return base.SendAsync(request, cancellationToken);
        }
    }
}
