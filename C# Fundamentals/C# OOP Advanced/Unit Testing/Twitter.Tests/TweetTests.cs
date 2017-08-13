using NUnit.Framework;

namespace Twitter.Tests
{
    [TestFixture]
    public class TweetTests
    {
        [Test]
        public void TweetReceivedMessage()
        {
            // Arrange

            // Act
            Tweet tweet = new Tweet("Hello!");

            // Assert
            Assert.AreEqual("Hello!", tweet.Message);
        }
    }
}