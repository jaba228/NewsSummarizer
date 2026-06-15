namespace NewsSummarizer.Domain;

class AlreadySubscribedException : DomainException
{
    public AlreadySubscribedException(string message) : base(message)
    {
        
    }
}