using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager.Model
{
    public class MovieSearchResult
    {
        public long Page { get; set; }
        public MovieInfo[] Results { get; set; }
        public long Total_Results { get; set; }
        public long Total_Pages { get; set; }
    }
}
