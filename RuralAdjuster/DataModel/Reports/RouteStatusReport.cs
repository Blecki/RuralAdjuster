using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuralAdjuster.DataModel.Reports
{
    public class RouteStatusReport : Report
    {
        public Route Route;

        public RouteStatusReport(Route Route)
        {
            this.Route = Route;
        }

        public override String Run()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("R{0:000} Status Report\r\n", Route.Number);
            builder.AppendFormat("Pre-Eval: {0} ({1}) Post-Eval: {2} ({3}) Target-Eval: {4} ({5})\r\n",
                Evaluation.ToStringEvaluation(Route.PreEvaluation),
                Evaluation.Name(Route.PreEvaluation),
                Evaluation.ToStringEvaluation(Route.NewEvaluation),
                Evaluation.Name(Route.NewEvaluation),
                Evaluation.ToStringEvaluation(Route.TargetEvaluation),
                Evaluation.Name(Route.TargetEvaluation));
            builder.AppendFormat("Base Data - RegBoxes:{0,4:####} CentBoxes:{1,4:####} CSlots:{2,3:###} PLockers:{3,3:###} Dismounts:{4,4:####} Distance:{5,5:#####}\r\n",
                Route.RegularBoxes,
                Route.CentralizedBoxes,
                Route.CollectionSlots,
                Route.ParcelLockers,
                Route.Dismounts,
                Route.DismountDistance);
            builder.AppendFormat("SA: {2} Miles:{0} Locked Pouch Stops: {1}\r\n\r\n",
                Route.PreMiles,
                Route.LockedPouchStops,
                Route.SuitableAllowance);

            builder.Append("Pre-adjustment Segments");
            foreach (var Segment in Route.PreSegments)
            {
                builder.Append("\r\n");
                builder.Append(Segment.DetailedString("- "));
            }

            builder.Append("\r\n\r\nPost-adjustment Segments");
            foreach (var Segment in Route.PostSegments)
            {
                builder.Append("\r\n");
                builder.Append(Segment.DetailedString("+ "));
            }

            builder.Append("\r\n\r\n");
            var boxReport = new RouteBoxReport(Route);
            builder.Append(boxReport.Run());
            return builder.ToString();
        }
    }
}
