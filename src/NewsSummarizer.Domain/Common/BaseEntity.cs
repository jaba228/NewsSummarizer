namespace NewsSummarizer.Domain;

abstract class BaseEntity
{
    // TODO: maybe use something like uuid for all 
    //       of the classes? 
    public long Id;

    public BaseEntity(long Id)
    {
        this.Id = Id;
    }
}
