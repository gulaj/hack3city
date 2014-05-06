using DbModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SearchDBContext : DbContext
    {
        public DbSet<Station> Stations { get; set; }

        public DbSet<Estate> Estates { get; set; }
    }
}
