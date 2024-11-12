using WordsAmount.Application.Interfaces;
using WordsAmount.Domain.Entities;

namespace WordsAmount.Application.UseCases
{
    public class AddWordUseCase
    {
        private readonly IWordRepository _wordRepository;

        public AddWordUseCase(IWordRepository wordRepository)
        {
            _wordRepository = wordRepository;
        }

        public async Task ExecuteAsync(string wordText)
        {
            var word = new Word { Text = wordText };
            await _wordRepository.AddWordAsync(word);
        }
    }
}
