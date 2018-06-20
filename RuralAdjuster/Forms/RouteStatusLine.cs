using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RuralAdjuster.Forms
{
    public partial class RouteStatusLine : UserControl
    {
        public DataModel.Route Route;
        public DataModel.Zone Zone;
        public ZoneEdit ZoneEdit;

        public RouteStatusLine()
        {
            InitializeComponent();
        }

        public void SetRoute(DataModel.Zone Zone, DataModel.Route Route)
        {
            this.Zone = Zone;
            this.Route = Route;

            RefreshData();
        }

        public void RefreshData()
        {
            this.lRoute.Text = String.Format("R{0,3:000}", Route.Number);
            this.lPreEval.Text = DataModel.Evaluation.ToStringEvaluation(Route.PreEvaluation);
            this.lPreEvalWords.Text = DataModel.Evaluation.Name(Route.PreEvaluation);
            this.lTargetEval.Text = DataModel.Evaluation.ToStringEvaluation(Route.TargetEvaluation);
            this.lTargetEvalWords.Text = DataModel.Evaluation.Name(Route.TargetEvaluation);

            var postEval = Route.NewEvaluation;
            this.lPostEval.Text = DataModel.Evaluation.ToStringEvaluation(postEval);
            this.lPostEvalWords.Text = DataModel.Evaluation.Name(postEval);

            var evalDifference = Route.NewEvaluation - Route.TargetEvaluation;
            var boxValue = Route.BoxFactor + (Route.LStatus == DataModel.LStatus.L ? 1.82f : 2.0f);
            this.lBoxesToRemove.Text = String.Format("{0}", Math.Ceiling(evalDifference / boxValue));
        }

        private void bEditRoute_Click(object sender, EventArgs e)
        {
            var modal = new RouteModal(Zone, Route);
            modal.ShowDialog();
            ZoneEdit.RebuildRouteStatus();
        }
    }
}
