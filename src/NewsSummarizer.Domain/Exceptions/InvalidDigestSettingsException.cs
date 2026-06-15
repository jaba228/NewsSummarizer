namespace NewsSummarizer.Domain;

class InvalidDigestSettingsException : DomainException
{
    public InvalidDigestSettingsException() : base() {}

    public InvalidDigestSettingsException(string message) : base(message)
    {
        
    }
}
