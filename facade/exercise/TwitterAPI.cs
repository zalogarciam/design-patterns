public class TwitterAPI
{
    private String appKey;
    private String secret;

    public TwitterAPI(string appKey, string secret)
    {
        this.appKey = appKey;
        this.secret = secret;
    }

    public List<Tweet> Get()
    {
        var twitterClient = new TwitterClient();
        var tweets = twitterClient.getRecentTweets(GetAccessToken());
        return tweets;
    }

    public string GetAccessToken()
    {
        var oauth = new OAuth();
        var requestToken = oauth.requestToken(appKey, secret);
        var accessToken = oauth.getAccessToken(requestToken);
        return accessToken;
    }
}