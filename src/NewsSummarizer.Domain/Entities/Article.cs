namespace NewsSummarizer.Domain;

class Article : BaseEntity
{
    public string? Url;
    public string? Title;
    public string? Content;
    public string? Summary;
    public string? Source;
    public DateTime PublishedAt;
    public DateTime ParsedAt;
    public long? TopicId;

    public bool HasSymmary => !string.IsNullOrWhiteSpace(Summary);

    public Article(string url, string title, string content,
                   string source, DateTime publishedAt,
                   long? topicId = null)
    {
        if (string.IsNullOrEmpty(url))
            throw new ArgumentException("Empty URL.");

        Url = url;
        Title = title ?? "Без заголовка";
        Content = content;
        Source = source;
        PublishedAt = publishedAt;
        TopicId = topicId;
        Summary = string.Empty;
        ParsedAt = DateTime.UtcNow;        
    }

    public void ApplySummary(string summary)
    {
        if (summary is not null)
            Summary = summary;
        else
            throw new ArgumentNullException("Null summary.");
    }
}