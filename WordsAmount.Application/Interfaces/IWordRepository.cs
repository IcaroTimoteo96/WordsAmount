using WordsAmount.Domain.Entities;

namespace WordsAmount.Application.Interfaces
{
    public interface IWordRepository
    {
        Task AddWordAsync(Word word);
        Task<IEnumerable<Word>> GetWordsAsync();
    }
}
