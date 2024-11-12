using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WordsAmount.Domain.Entities;

namespace WordsAmount.Infrastructure
{
    public class WordDbContext : DbContext
    {
        public WordDbContext(DbContextOptions<WordDbContext> options) : base(options) { }
        public DbSet<Word> Words { get; set; }
    }
}