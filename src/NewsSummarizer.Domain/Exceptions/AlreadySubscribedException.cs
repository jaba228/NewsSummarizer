namespace NewsSummarizer.Domain;

class AlreadySubscribedException : DomainException
{
    public AlreadySubscribedException() : base() {}

    public AlreadySubscribedException(string message) : base(message)
    {
        
    }
}