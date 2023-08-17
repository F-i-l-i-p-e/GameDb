using Microsoft.EntityFrameworkCore; // EF Core Namespace
using GameDb.Models; // Models Namespace
using System.Collections.Generic; // Collections Namespace

namespace GameDb.Data // Data Namespace
{
    public class DBContext : DbContext // DB Context Class
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
        } // Constructor

        public DbSet<Game> Games { get; set; } // Games Set
    }
}
