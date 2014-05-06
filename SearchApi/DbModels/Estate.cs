using System;
using System.Data.Spatial;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModels
{
    public class Estate
    {
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DbGeography Location { get; set; }
    }
}
