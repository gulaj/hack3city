using DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ImportService
    {

        public void ImportStations()
        {
            GdanskStationsImporter.Importer importer = new GdanskStationsImporter.Importer();
            List<Station> stations = importer.Run();

            using(var context = new SearchDBContext()) {
                foreach(var station in stations) {
                    context.Stations.Add(station);
                }
                context.SaveChanges();
            }
            

        }

        public void ImportEstates()
        {
            EstatesImporter.Importer importer = new EstatesImporter.Importer();            
        }

        public void ImportTraffic()
        {
            GdanskTrafficImporter.Importer importer = new GdanskTrafficImporter.Importer();            
        }
    }
}
