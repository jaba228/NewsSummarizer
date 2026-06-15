namespace NewsSummarizer.Domain;

public class Subscription
{
        public long UserId { get; private set; } 
        public long TopicId { get; private set; }
        public DateTime CreatedAt { get; private set; }

        internal Subscription(long userId, long topicId)
        {
                UserId = userId;
                TopicId = topicId;
                CreatedAt = DateTime.UtcNow;        
        }
}
