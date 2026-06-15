namespace NewsSummarizer.Application;

using NewsSummarizer.Domain;

interface ITopicRepository
{
    Task<IReadOnlyCollection<Topic>> GetAllAsync();
    Task<Topic?> GetBySlugAync(string slug);
}