using Microsoft.AspNetCore.Mvc;
using WordsAmount.Application.UseCases;

namespace WordsAmount.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WordsController : ControllerBase
    {
        private readonly AddWordUseCase _addWordUseCase;

        public WordsController(AddWordUseCase addWordUseCase)
        {
            _addWordUseCase = addWordUseCase;
        }

        [HttpPost]
        public async Task<IActionResult> AddWord([FromBody] string wordText)
        {
            await _addWordUseCase.ExecuteAsync(wordText);
            return Ok("Word added successfully.");
        }
    }
}
