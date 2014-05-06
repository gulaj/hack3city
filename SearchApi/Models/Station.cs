using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModels
{
    public class Station
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public GeoPoint Location { get; set; }

        public int TimeToBasePoint { get; set; }
    }
}
