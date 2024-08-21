using Microsoft.EntityFrameworkCore;
using FlashCardApi.Data;
using FlashCardApi.Infrastructure.RepositoryInterface;
using FlashCardApi.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace FlashCardApi.Infrastructure.DataRepository
{
    public class FlashCardRepo : IFlashCardRepo 
    {
        //Field
        private readonly FlashCardContext _context;
        //Constructor
        public FlashCardRepo(FlashCardContext context) {
            _context = context;
        }
        //Methods
        public async Task<IEnumerable<FlashCard>> GetAllCards()
        {
            var fcList = await _context.flashcard.ToListAsync();
            return fcList;
        }

        public async Task<FlashCard> GetCardById(int id)
        {
            var fc = await _context.flashcard.FindAsync(id);
            return fc;
        }

        public async Task<FlashCard> AddCard(FlashCard _flashcard) 
        {
            _context.flashcard.Add(_flashcard);
            await _context.SaveChangesAsync();
            return _flashcard;
        }

        public async Task UpdateCard(FlashCard _flashcard) {
            var existingFlashCard = await _context.flashcard.FindAsync(_flashcard.Id);
            if (existingFlashCard != null) 
            {
                existingFlashCard.Question = _flashcard.Question;
                existingFlashCard.Answer = _flashcard.Answer;
                existingFlashCard.createdBy = _flashcard.createdBy;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCard(int id) {
            var vid = await _context.flashcard.FindAsync(id);
            if (vid != null)
            {
                _context.flashcard.Remove(vid);
                await _context.SaveChangesAsync();
            }
        }

    }

}