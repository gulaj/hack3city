using DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MockStationsSearchService : Services.IStationsSearchService
    {
        public SearchResponse Search(SearchRequest request)
        {
            return new SearchResponse
            {
                Stations = new List<Station> {
                    new Station{Id = new Guid(),Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Name = "Dworzec PKP", TimeToBasePoint = 20},
                    new Station{Id = new Guid(),Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Name = "SKM Stocznia", TimeToBasePoint = 17},
                    new Station{Id = new Guid(),Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Name = "SKM Politechnika", TimeToBasePoint = 12},
                    new Station{Id = new Guid(),Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Name = "Wrzeszcz PKP", TimeToBasePoint = 8},
                    new Station{Id = new Guid(),Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Name = "SKM Zaspa", TimeToBasePoint = 6},
                    new Station{Id = new Guid(),Location = new GeoPoint{Latitude = 1, Longtitude = 2}, Name = "SKM Oliwa", TimeToBasePoint = 2}
                }
            };
        }
    }
}
