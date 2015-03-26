using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuralAdjuster.DataModel.Reports
{
    public class ZoneDetailReport : Report
    {
        public Zone Zone;
        ZoneStatusReport Status;
        ZoneSchemeReport Scheme;
        RouteStatusReport RouteStatus;

        public ZoneDetailReport(Zone Zone)
        {
            this.Zone = Zone;
            Status = new ZoneStatusReport(Zone);
            Scheme = new ZoneSchemeReport(Zone);
            RouteStatus = new RouteStatusReport(null);
        }

        public override String Run()
        {
            var builder = new StringBuilder();
            builder.Append(Status.Run());
            builder.Append("\r\n\r\n");

            foreach (var Route in Zone.Routes)
            {
                RouteStatus.Route = Route;
                builder.Append(RouteStatus.Run());
                builder.Append("\r\n");
            }

            builder.Append(Scheme.Run());

            return builder.ToString();
        }
    }
}
