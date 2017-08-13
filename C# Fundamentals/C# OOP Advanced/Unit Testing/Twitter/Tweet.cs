namespace Twitter
{
    public class Tweet : ITweet
    {
        public Tweet(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }

        public override string ToString()
        {
            return this.Message;
        }
    }
}