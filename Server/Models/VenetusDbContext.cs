using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Server.Models
{
    public class VenetusDbContext : DbContext
    {
        public DbSet<Game> Games;
    }
}