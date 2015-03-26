using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuralAdjuster.DataModel.Reports
{
    public class RouteBoxReport : Report
    {
        internal class BoxEntry
        {
            public int RegularBoxes;
            public int CentralizedBoxes;
            public int CollectionSlots;
            public int ParcelLockers;
            public int Dismounts;
            public int DismountDistance;
        }

        public Route Route;

        public RouteBoxReport(Route Route)
        {
            this.Route = Route;
        }

        public override String Run()
        {
            var accumulator = new Dictionary<String, BoxEntry>();
            var baseEntry = new BoxEntry
            {
                RegularBoxes = Route.RegularBoxes,
                CentralizedBoxes = Route.CentralizedBoxes,
                CollectionSlots = Route.CollectionSlots,
                ParcelLockers = Route.ParcelLockers,
                Dismounts = Route.Dismounts,
                DismountDistance = Route.DismountDistance
            };
            accumulator.Add(Route.ToString(), baseEntry);

            foreach (var Segment in Route.PreSegments)
            {
                if (Segment.SourceRoute != Segment.DestinationRoute)
                {
                    baseEntry.RegularBoxes -= Segment.RegularBoxes;
                    baseEntry.CentralizedBoxes -= Segment.CentralizedBoxes;
                    baseEntry.CollectionSlots -= Segment.CollectionSlots;
                    baseEntry.ParcelLockers -= Segment.ParcelLockers;
                    baseEntry.Dismounts -= Segment.Dismounts;
                    baseEntry.DismountDistance -= Segment.DismountDistance;
                }
            }

            foreach (var Segment in Route.PostSegments)
            {
                if (Segment.SourceRoute != Segment.DestinationRoute)
                {
                    BoxEntry addTo = null;
                    if (accumulator.ContainsKey(Segment.SourceRoute.ToString())) 
                        addTo = accumulator[Segment.SourceRoute.ToString()];
                    else
                    {
                        addTo = new BoxEntry();
                        accumulator.Add(Segment.SourceRoute.ToString(), addTo);
                    }

                    addTo.RegularBoxes += Segment.RegularBoxes;
                    addTo.CentralizedBoxes += Segment.CentralizedBoxes;
                    addTo.CollectionSlots += Segment.CollectionSlots;
                    addTo.ParcelLockers += Segment.ParcelLockers;
                    addTo.Dismounts += Segment.Dismounts;
                    addTo.DismountDistance += Segment.DismountDistance;
                }
            }

            var totals = new BoxEntry();
            foreach (var entry in accumulator)
            {
                totals.RegularBoxes += entry.Value.RegularBoxes;
                totals.CentralizedBoxes += entry.Value.CentralizedBoxes;
                totals.CollectionSlots += entry.Value.CollectionSlots;
                totals.ParcelLockers += entry.Value.ParcelLockers;
                totals.Dismounts += entry.Value.Dismounts;
                totals.DismountDistance += entry.Value.DismountDistance;
            }

            accumulator.Add("TOTL", totals);

            var builder = new StringBuilder();
            builder.AppendFormat("R{0:000} Box Report", Route.Number);
            foreach (var entry in accumulator)
                builder.AppendFormat("\r\n{0} RB:{1,4:####} CB:{2,4:####} CS:{3,3:####} PL:{4,3:####} DISMOUNT:{5,3:###} DISTANCE:{6}",
                    entry.Key,
                    entry.Value.RegularBoxes,
                    entry.Value.CentralizedBoxes,
                    entry.Value.CollectionSlots,
                    entry.Value.ParcelLockers,
                    entry.Value.Dismounts,
                    entry.Value.DismountDistance);

            return builder.ToString();
        }
    }
}
