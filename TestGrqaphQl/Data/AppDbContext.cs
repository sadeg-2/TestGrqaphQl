﻿using Microsoft.EntityFrameworkCore;
using TestGrqaphQl.Data.Models;

namespace TestGrqaphQl.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }

}
