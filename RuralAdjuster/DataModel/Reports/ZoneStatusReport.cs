using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuralAdjuster.DataModel.Reports
{
    public class ZoneStatusReport : Report
    {
        public Zone Zone;

        public ZoneStatusReport(Zone Zone)
        {
            this.Zone = Zone;
        }

        public override String Run()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("Zone {0} Status Report\r\n",
                Zone.Zipcode);

            foreach (var route in Zone.Routes)
            {
                builder.Append("\r\n");
                builder.Append(route.DescriptionString());
            }
            return builder.ToString();
        }
    }
}
