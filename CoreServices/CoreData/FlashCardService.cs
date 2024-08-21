using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashCardApi.CoreServices.ServiceInterface;
using FlashCardApi.Infrastructure.RepositoryInterface;
using FlashCardApi.Models;

namespace FlashCardApi.CoreServices.CoreData
{
    public class FlashCardService : IFlashCardService
    {
        private readonly IFlashCardRepo _flashCardRepo;

        public FlashCardService(IFlashCardRepo flashCardRepo)
        {
            _flashCardRepo = flashCardRepo;
        }
        public async Task<FlashCard> AddCard(FlashCard fc)
        {
            return await _flashCardRepo.AddCard(fc);
        }
        public async Task DeleteCard(int id)
        {
            await _flashCardRepo.DeleteCard(id);
        }
        public async Task<IEnumerable<FlashCard>> GetAllCards()
        {
            return await _flashCardRepo.GetAllCards();
        }
        public async Task<FlashCard> GetCardById(int id)
        {
            return await _flashCardRepo.GetCardById(id);
        }

        public async Task UpdateCard(FlashCard fc)
        {
            await _flashCardRepo.UpdateCard(fc);
        }
    }
}