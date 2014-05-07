using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbModels
{
    public class Station
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DbGeography Location { get; set; }

        public int TimeToBasePoint { get; set; }

        public string CommunicationLine { get; set; }
    }
}
