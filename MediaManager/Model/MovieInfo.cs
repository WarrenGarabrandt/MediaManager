using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager.Model
{
    public class MovieInfo
    {
        public string Poster_Path { get; set; }
        public bool Adult { get; set; }
        public string Overview { get; set; }
        public string Release_Date { get; set; }
        public int[] Genera_IDs { get; set; }
        public long ID { get; set; }
        public string Original_Title { get; set; }
        public string Original_Language { get; set; }
        public string Title { get; set; }
        public string Backdrop_Path { get; set; }
        public decimal Popularity { get; set; }
        public long Vote_Count { get; set; }
        public bool Video { get; set; }
        public decimal Vote_Average { get; set; }

    }
}
