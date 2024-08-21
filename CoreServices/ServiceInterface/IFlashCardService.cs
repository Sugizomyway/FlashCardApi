using FlashCardApi.Models;
using FlashCardApi.Infrastructure.RepositoryInterface;
using FlashCardApi.CoreServices.ServiceInterface;

namespace FlashCardApi.CoreServices.ServiceInterface
{
    public interface IFlashCardService
    {
        Task<IEnumerable<FlashCard>> GetAllCards();
        Task<FlashCard> GetCardById(int id);
        Task<FlashCard> AddCard(FlashCard _flashcard);
        Task UpdateCard(FlashCard _flashcard);
        Task DeleteCard(int id);
    }
}