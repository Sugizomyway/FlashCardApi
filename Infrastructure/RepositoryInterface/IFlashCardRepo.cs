using FlashCardApi.Models;

namespace FlashCardApi.Infrastructure.RepositoryInterface 
{
    public interface IFlashCardRepo 
    {
        Task<IEnumerable<FlashCard>> GetAllCards();
        Task<FlashCard> GetCardById(int id);
        Task<FlashCard> AddCard(FlashCard _flashcard);
        Task UpdateCard(FlashCard _flashcard);
        Task DeleteCard(int id);
    }
}