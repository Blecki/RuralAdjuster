using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuralAdjuster.DataModel.Reports
{
    public class RouteSchemeReport : Report
    {
        public Route Route;

        public RouteSchemeReport(Route Route)
        {
            this.Route = Route;
        }

        public override String Run()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("R{0:000} Segment Scheme Report\n", Route.Number);
            foreach (var Segment in Route.PreSegments)
            {
                builder.Append("\n[" + Segment.Comment + "]\n");
                foreach (var SchemeEntry in Segment.Scheme)
                {
                    builder.AppendFormat("{0}\t Low: {1}\t High: {2}\t {3}\t Box Count: {4}\n",
                        SchemeEntry.StreetName,
                        SchemeEntry.Low,
                        SchemeEntry.High,
                        SchemeEntry.SequenceType,
                        SchemeEntry.BoxCount);
                }
            }
            return builder.ToString();
        }
    }
}
