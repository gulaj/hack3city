using System;
using System.Collections.Generic;
using System.Data.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModels
{
    public class SearchRequest
    {
        public GeoPoint BaseLocation { get; set; }

        public int RadiusFromStation { get; set; }
    }
}
