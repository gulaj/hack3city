using DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MockEstatesSearchService : Services.IEstatesSearchService
    {
        public List<Estate> SearchEstatesInArea(List<Station> stations, int radiusFromStation) 
        {
            return new List<Estate> { 
                new Estate{Id = new Guid(), Description = "Opis1", Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Price = 250000, Title = "Ładne M3"},
                new Estate{Id = new Guid(), Description = "Opis2", Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Price = 350000, Title = "Ładne M4"}
            };
        }
    }
}
