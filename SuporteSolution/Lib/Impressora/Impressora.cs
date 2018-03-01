using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Text;

namespace SuporteSolution.Lib.Impressora
{
    public static class Impressora
    {
        public static void LimparFila()
        {
            var ps = new PrintServer();
            var queues = ps.GetPrintQueues();
            foreach (PrintQueue pq in ps.GetPrintQueues())
            {
                //sempre chamar o refresh antes do getPrintJobInfo...
                pq.Refresh();
                if (pq.GetPrintJobInfoCollection() != null)
                {
                    var jobs = pq.GetPrintJobInfoCollection();
                    foreach (var job in jobs)
                    {
                        job.Cancel();
                    }
                }
            }
        }
    }
}
