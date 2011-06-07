using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        private string feedUrl = "http://sample.com/";
        private string resource = "posts.rss";
        private string user = "user";                               
        private string password = "password";
        

        [Test]
        public void CanGetFeed()
        {
            var getFeed = GetRssFeed.GetRssFeed.Get(feedUrl, resource, user, password);

            Assert.NotNull(getFeed);
            Assert.Greater(getFeed.Channels.Count, 0);
        }
    }
}
