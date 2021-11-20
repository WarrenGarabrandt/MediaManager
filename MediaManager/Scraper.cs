using MediaManager.Query;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager
{
    public class Scraper
    {
        private BackgroundWorker worker;
        private string APIKey;
        public Scraper(string apiKey)
        {
            APIKey = apiKey;
            QueryQueue = new ConcurrentQueue<WebAPIQuery>();
            worker = new BackgroundWorker();
            worker.DoWork += Worker_DoWork;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        ConcurrentQueue<WebAPIQuery> QueryQueue;

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        

    }
}
