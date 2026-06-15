namespace NewsSummarizer.Domain;

class Topic : BaseEntity
{
    public string? Slug { get; private set; }
    public string? Name { get; private set; }
    public string? Description { get; private set; }

    public Topic(string slug, string name, string description)
    {
        if (slug is null || slug == string.Empty)
            throw new ArgumentException("Field 'slug' is empty.");

        if (name is null || name == string.Empty)
            throw new ArgumentException("Field 'name' is empty.");           

        Slug = slug.Trim();
        Name = name.Trim();
        Description = description ?? string.Empty;
    }
}
