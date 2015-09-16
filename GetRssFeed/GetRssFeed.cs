using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GetRssFeed.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace GetRssFeed
{
    public class GetRssFeed
    {
        private RestClient _client;

        /// <summary>
        /// Constructor that uses BasicHttpAuthentication.
        /// </summary>
        /// <param name="feedUrl"></param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        public GetRssFeed(string feedUrl, string user, string password)
        {
            _client = new RestClient(feedUrl);
            if (!string.IsNullOrEmpty(user) && !string.IsNullOrEmpty(password))
                _client.Authenticator = new HttpBasicAuthenticator(user, password);
        }

        /// <summary>
        /// Returns a feed.
        /// </summary>
        /// <param name="baseUrl">ex: http://somewhere.com/</param>
        /// <param name="resource">everthing after the ".com". Ex: feed.rss</param>
        /// <param name="user"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static RssFeed Get(string baseUrl, string resource, string user = "", string password = "")
        {
            var getFeed = new GetRssFeed(baseUrl, user, password);

            var req = new RestRequest()
            {
                Method = Method.GET,
                Resource = resource
            };

            return getFeed.Execute<RssFeed>(req);
        }

        public T Execute<T>(RestRequest request) where T : new()
        {
            var response = _client.Execute<T>(request);
            return response.Data;
        }

        public IRestResponse Execute(RestRequest request)
        {
            var res = _client.Execute(request);
            return res;
        }
    }
}
