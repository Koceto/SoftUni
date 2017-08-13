namespace Twitter
{
    public interface IClient
    {
        void PublishTweet(ITweet tweet);
    }
}