using System;
namespace Services
{
    public interface IStationsSearchService
    {
        DtoModels.SearchResponse Search(DtoModels.SearchRequest request);
    }
}
