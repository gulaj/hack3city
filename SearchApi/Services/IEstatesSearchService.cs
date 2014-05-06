using System;
namespace Services
{
    public interface IEstatesSearchService
    {
        System.Collections.Generic.List<DtoModels.Estate> SearchEstatesInArea(System.Collections.Generic.List<DtoModels.Station> stations, int radiusFromStation);
    }
}
