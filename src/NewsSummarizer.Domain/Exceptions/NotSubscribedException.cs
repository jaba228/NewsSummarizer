namespace NewsSummarizer.Domain;

class NotSubscribedException : DomainException
{
    public NotSubscribedException() : base() {}

    public NotSubscribedException(string message) : base(message)
    {
        
    }
}