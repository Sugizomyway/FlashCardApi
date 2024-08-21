using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FlashCardApi.CoreServices.ServiceInterface;
using FlashCardApi.Models;


namespace FlashCardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlashcardController : ControllerBase
    {
        // Fields
        private readonly IFlashCardService _FlashCardService;

        // Constructor
        public FlashcardController(IFlashCardService FlashCardService)
        {
            _FlashCardService = FlashCardService;
        }

        // Http Methods
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<FlashCard>>> GetAllCards()
        {
            var fc = await _FlashCardService.GetAllCards();
            return Ok(fc);
        }
        [HttpGet("GetById")]
        public async Task<ActionResult<FlashCard>> GetById(int id)
        {
            var fc = await _FlashCardService.GetCardById(id);
            return Ok(fc);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFlashCard(int id)
        {
            await _FlashCardService.DeleteCard(id);
            return NoContent();
        }

        [HttpPost("addFlashCard")]
        public async Task<ActionResult<FlashCard>> PostFlashCard(FlashCard flashcard)
        {
            var fc = await _FlashCardService.AddCard(flashcard);
            return Ok(fc);
        }

        [HttpPut("UpdateFlashCard")]
        public async Task<ActionResult> PutFlashCard([FromBody] FlashCard flashCard)
        {
            try
            {
                await _FlashCardService.UpdateCard(flashCard);
            }
            catch (Exception e) 
            {
                return StatusCode(500);
            }
            
            return NoContent();
        }


    }
}