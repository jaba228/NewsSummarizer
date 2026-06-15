namespace NewsSummarizer.Application;

using NewsSummarizer.Domain;

interface IUserRepository
{
    Task<User?> GetByIdAsync(long telegramId);
    Task AddAsync(User user);
    Task<IReadOnlyCollection<User>> GetUserByDigestHourAsync(int hour);
    
}
