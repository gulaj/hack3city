using DtoModels;
using DbModels;
using System;
using System.Data.Spatial;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StationsSearchService : Services.IStationsSearchService
    {
        public SearchResponse Search(SearchRequest request)
        {
            DbGeography basePoint = DbGeography.FromText(string.Format("POINT({0} {1})", request.BaseLocation.Latitude.ToString(), request.BaseLocation.Longtitude.ToString()));



            return null;
        }
    }
}
