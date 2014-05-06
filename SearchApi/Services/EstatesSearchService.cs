using DtoModels;
using DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EstatesSearchService : Services.IEstatesSearchService
    {
        public List<DtoModels.Estate> SearchEstatesInArea(List<DtoModels.Station> stations, int radiusFromStation) 
        {
            return null;
        }
    }
}
