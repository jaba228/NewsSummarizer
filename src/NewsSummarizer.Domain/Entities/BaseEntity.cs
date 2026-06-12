namespace NewsSummarizer.Domain;

abstract class BaseEntity
{
    public long Id;

    public BaseEntity(long Id)
    {
        this.Id = Id;
    }
}
