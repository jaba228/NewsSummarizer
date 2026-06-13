namespace NewsSummarizer.Domain;

// TODO: learned that i can maybe use record instead of
//       abstract class, because it automatically
//       implements all equality methods. Research
//       on that topic needed.
abstract class BaseEntity : IEquatable<BaseEntity>
{
    // TODO: maybe use something like uuid for all 
    //       of the classes? 
    public long Id { get; protected set; }

    protected BaseEntity() {}

    protected BaseEntity(long id)
    {
        Id = id;
    }

    public bool Equals(BaseEntity? other)
    {
        if (other is null) return false;

        if (ReferenceEquals(this, other)) return true;

        if (GetType() != other.GetType()) return false;

        if (Id == default || other.Id == default)
            return false;
        
        return Id.Equals(other.Id);
    }

    public override bool Equals(object? obj)
    {
        return Equals(obj as BaseEntity);
    }

    public override int GetHashCode()
    {
        if (Id == 0) 
            return base.GetHashCode();
        
        return HashCode.Combine(GetType(), Id); 
    }

    public static bool operator ==(BaseEntity? left, BaseEntity? right)
    {
        if (left is null) return right is null;

        return left.Equals(right);
    }

    public static bool operator !=(BaseEntity? left, BaseEntity? right)
    {
        return !(left == right);
    }
}
