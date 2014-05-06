using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModels
{
    public class SearchResponse
    {
        public List<Message> Messages { get; set; }

        public List<Station> Stations { get; set; }
    }
}
