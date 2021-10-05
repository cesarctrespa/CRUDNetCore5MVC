using System;
using CRUDNetCore5MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDNetCore5MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Libro> Libro { get; set; }
    }
}
