namespace NewsSummarizer.Domain;

class User : BaseEntity
{
	public string? Username;
	public string? FirstName;
	public DateOnly RegistredAt;
	public TimeOnly DigestTime;
	public int DigestArticleCount;
	// TODO: find better way to store subscriptions
	// public List<string>? Subscriptions;

	// TODO: get rid of anemic model and create various
	// 		 methonds like ChangeDigestTime().

	public User(long id, string username, string firstname, 
		  		DateOnly registredAt, TimeOnly digestTime,
				int digestArticleCount) : base(id)
	{
		Username = username;
		FirstName = firstname;
		RegistredAt = registredAt;
		DigestTime = digestTime;
		DigestArticleCount = digestArticleCount;
	}
}
