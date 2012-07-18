A simple package that gets and parses an rss feed. Supports basic authenticate.

Just make a call like this:
var feed = GetRssFeed.GetRssFeed.Get("yoursite.com", "rsslocation.rss", user, password);

And get back an RssFeed object:

public class RssFeed
{
	public List<Channel> Channels { get; set; }
}

public class Channel
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public string Language { get; set; }
    public string Ttl { get; set; }
    public List<Item> Items { get; set; }

}

public class Item
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime PubDate { get; set; }
    public string Guid { get; set; }
    public string Link { get; set; }
}