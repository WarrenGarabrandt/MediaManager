using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaManager.Query
{
    public abstract class WebAPIQuery
    {
        internal System.Threading.ManualResetEventSlim DoneSignal;
        public bool Aborted { get; internal set; }
        public void Abort()
        {
            Aborted = true;
            DoneSignal.Set();
        }
    }
}
