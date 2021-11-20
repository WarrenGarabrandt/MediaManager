using MediaManager.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager.Query
{
    public class qryMovieSearch : WebAPIQuery
    {
        public MovieSearchResult Result { get; set; }

        public qryMovieSearch(string query, int? page, string lang, bool? includeAdult, string region, int? year, int? releaseYear)
        {
            Query = query;
            Page = page;
            Language = lang;
            IncludeAdult = includeAdult;
            Region = region;
            Year = year;
            ReleaseYear = releaseYear;
        }
        public string Query { get; set; }
        public int? Page { get; set; }
        public string Language { get; set; }
        public bool? IncludeAdult { get; set; }
        public string Region { get; set; }
        public int? Year { get; set; }
        public int? ReleaseYear { get; set; }

        public string GenerateQueryString(string apikey)
        {
            List<string> parms = new List<string>();
            parms.Add(string.Format("api_key={0}", apikey));
            if (string.IsNullOrWhiteSpace(Language))
            {
                parms.Add(string.Format("language={0}", Language));
            }
            parms.Add(string.Format("query={0}", Query));
            if (Page.HasValue)
            {
                parms.Add(string.Format("page={0}", Page.Value));
            }
            if (IncludeAdult.HasValue)
            {
                parms.Add(string.Format("include_adult={0}", IncludeAdult.Value));
            }
            if (string.IsNullOrWhiteSpace(Region))
            {
                parms.Add(string.Format("region={0}", Region));
            }
            if (Year.HasValue)
            {
                parms.Add(string.Format("year={0}", Year.Value));
            }
            if (ReleaseYear.HasValue)
            {
                parms.Add(string.Format("primary_release_year={0}", ReleaseYear.Value));
            }
            StringBuilder sb = new StringBuilder();
            bool first = true;
            foreach (string parm in parms)
            {
                if (first)
                {
                    first = false;
                    sb.Append("?");
                }
                else
                {
                    sb.Append("&");
                }
                sb.Append(parm);
            }
            return sb.ToString();
        }

        public void SetResult(MovieSearchResult result)
        {
            Result = result;
            DoneSignal.Set();
        }

        public MovieSearchResult GetResult()
        {
            DoneSignal.Wait();
            DoneSignal.Dispose();
            if (Aborted)
            {
                throw new OperationCanceledException();
            }
            return Result;
        }

    }
}
