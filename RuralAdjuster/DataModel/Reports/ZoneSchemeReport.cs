using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuralAdjuster.DataModel.Reports
{
    public class ZoneSchemeReport : Report
    {
        public Zone Zone;

        public ZoneSchemeReport(Zone Zone)
        {
            this.Zone = Zone;
        }

        public override String Run()
        {
            var schemeMap = new Dictionary<String, List<SchemeEntry>>();

            foreach (var route in Zone.Routes)
            {
                foreach (var segment in route.PreSegments)
                {
                    if (segment.DestinationRoute != segment.SourceRoute)
                    {
                        var pairName = String.Format("R{0:000} -> R{1:000}", segment.SourceRoute.Number, segment.DestinationRoute.Number);
                        List<SchemeEntry> schemeList = null;
                        if (schemeMap.ContainsKey(pairName)) schemeList = schemeMap[pairName];
                        else
                        {
                            schemeList = new List<SchemeEntry>();
                            schemeMap.Add(pairName, schemeList);
                        }
                        foreach (var schemeEntry in segment.Scheme)
                            schemeList.Add(schemeEntry);
                    }
                }
            }

            var builder = new StringBuilder();
            builder.AppendFormat("{0} Scheme Report\n", Zone.Zipcode);
            foreach (var pair in schemeMap)
            {
                builder.Append("\n" + pair.Key + "\n");
                foreach (var SchemeEntry in pair.Value)
                {
                    var streetName = SchemeEntry.StreetName;
                    if (streetName.Length > 50) streetName = streetName.Substring(0, 50);
                    else if (streetName.Length < 50) streetName = streetName + new String(' ', 50 - streetName.Length);
                    builder.AppendFormat("{0}, {1}, {2}, {3}, {4}\n",
                        streetName,
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
