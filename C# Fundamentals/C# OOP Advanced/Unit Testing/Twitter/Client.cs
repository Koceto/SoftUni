using System;

namespace Twitter
{
    public class Client : IClient
    {
        public void PublishTweet(ITweet tweet)
        {
            Console.WriteLine(tweet);
        }
    }
}