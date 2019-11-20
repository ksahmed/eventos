using System;
using System.Net;
using System.Threading.Tasks;

namespace Eventos.Utils
{
    public class HttpUtils
    {
        private WebClient _client = new WebClient();

        public HttpUtils()
        {
        }

        /// <summary>
        ///  sends a request via webclient and returns response
        /// </summary>
        /// <param name="request">json string</param>
        /// <param name="apiAddress"></param>
        public async Task SendRequestAsync(string request, Uri apiAddress)
        {
            try
            {
                await _client.UploadStringTaskAsync(apiAddress, request);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        ///  sends a request via webclient and returns response
        /// </summary>
        /// <param name="apiAddress"></param>
        public async Task<T> GetDataAsync<T>(Uri apiAddress)
        {
            try
            {
                var r = await _client.DownloadStringTaskAsync(apiAddress);
                if (r != null)
                {
                    return (T)Newtonsoft.Json.JsonConvert.DeserializeObject(r);
                }
                else
                {
                    return await Task.FromResult(default(T));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}