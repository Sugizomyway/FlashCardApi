using Microsoft.EntityFrameworkCore;
using FlashCardApi.Models;

namespace FlashCardApi.Data
{
    public class FlashCardContext : DbContext
    {
        public FlashCardContext(DbContextOptions<FlashCardContext> options) : base(options){}

        public DbSet<FlashCard> flashcard{get;set;}

    }
}