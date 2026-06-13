namespace NewsSummarizer.Domain.Entities;

class User : BaseEntity
{
	public static int MinDigestArticleCount = 1;
	public static int MaxDigestArticleCount = 20;
	public static int DefaultDigestArticleCount = 5;
	public static TimeOnly DefaultDigestTime = new(hour: 9, minute: 0);

	public string? Username { get; private set; }
	public string? FirstName { get; private set; }

	public DateTime RegistredAt { get; private set; }
	public TimeOnly DigestTime { get; private set; }

	public int DigestArticleCount { get; private set; }

	public IReadOnlyCollection<Subscription> Subscriptions;
	private List<Subscription> _subscriptions;

	public User(long tgId, string firstName, string? userName) : base(tgId)
	{
		if (firstName is null) throw new ArgumentException("Something went wrong on Telegram user data reception.");
		FirstName = firstName;
		Username = userName ?? string.Empty;
		RegistredAt = DateTime.UtcNow;
		DigestTime = DefaultDigestTime;
		DigestArticleCount = DefaultDigestArticleCount;
		_subscriptions = new List<Subscription>();
	}

	public void UpdateDigestTime(TimeOnly newTime)
	{
		DigestTime = newTime;
	}

	public void UpdateDigestArticleCount(int newCount)
	{
		if (newCount < MinDigestArticleCount || newCount > MaxDigestArticleCount)
			throw new InvalidDigestSettingsException();
		DigestArticleCount = newCount;
	}

	public bool IsSubscribedTo(long topicId)
	{
		return _subscriptions.Any(s => s.TopicId == topicId);
	}

	public void Subscribe(Topic topic)
	{
		if (topic is null)
			throw new ArgumentNullException("No topic provided.");

		if (IsSubscribedTo(topic.Id))
			throw new AlreadeSubscribedException();		

		_subscriptions.Add(new Subscription(Id, topic.Id));	
	}

	public void Unsubscribe(Topic topic)
	{
		// TODO: make it look not like a shitty-ass lamer code.
		//       Plus it think it's very wrong, but need to 
		//       research anyway.
		if (_subscriptions.Exists(s => s.TopicId == topic.Id))
			_subscriptions.Remove(_subscriptions.Find(s => s.TopicId == topic.Id));
		else
			throw new NotSubscribedException();			
	}
}
