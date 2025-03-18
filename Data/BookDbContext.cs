using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookManagerApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BookManagerApi.Data
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions <BookDbContext> options) : base(options)
        {
            
        }

        public DbSet<BookModel> Books { get; set; }
    }
}