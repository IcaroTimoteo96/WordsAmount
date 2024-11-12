using Microsoft.EntityFrameworkCore;
using WordsAmount.Application.Interfaces;
using WordsAmount.Domain.Entities;

namespace WordsAmount.Infrastructure.Repositories
{
    public class WordRepository : IWordRepository
    {
        private readonly WordDbContext _context;

        public WordRepository(WordDbContext context)
        {
            _context = context;
        }

        public async Task AddWordAsync(Word word)
        {
            await _context.Words.AddAsync(word);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Word>> GetWordsAsync()
        {
            return await _context.Words.ToListAsync();
        }
    }
}
