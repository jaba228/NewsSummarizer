namespace NewsSummarizer.Domain;

class DomainException : Exception
{
    public DomainException() : base() {}

    public DomainException(string message) : base(message)
    {
        
    }
}