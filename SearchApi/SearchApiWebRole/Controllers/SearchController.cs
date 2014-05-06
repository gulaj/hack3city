using DtoModels;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SearchApiWebRole.Controllers
{
    public class SearchController : ApiController
    {
        IStationsSearchService service;

        public SearchController(IStationsSearchService service)
        {
            this.service = service;
        }

        // GET api/search
        public SearchResponse Get(float latitude = 0, float logtitude = 0, int maxDriveTime = 30)
        {            
            return service.Search(new SearchRequest());
        }
    }
}