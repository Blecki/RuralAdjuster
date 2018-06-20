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
    public partial class ZoneEdit : UserControl
    {
        public DataModel.Zone Zone;

        public ZoneEdit()
        {
            InitializeComponent();
        }

        public void SetZone(DataModel.Zone Zone)
        {
            this.Zone = Zone;
            RebuildRouteStatus();
        }

        public void RebuildRouteStatus()
        {
            this.SuspendLayout();
            this.pRouteStatus.Controls.Clear();
            foreach (var route in Zone.Routes)
            {
                var entry = new RouteStatusLine();
                entry.SetRoute(Zone, route);
                entry.Dock = DockStyle.Top;
                entry.ZoneEdit = this;
                this.pRouteStatus.Controls.Add(entry);
            }
            this.ResumeLayout();
        }

        private void bNewRoute_Click(object sender, EventArgs e)
        {
            var numberPick = new PickRouteNumber(Zone);
            numberPick.ShowDialog();
            if (numberPick.WasCancelled) return;
            var route = new DataModel.Route();
            route.Number = numberPick.EnteredNumber;
            Zone.Routes.Add(route);
            var modal = new RouteModal(Zone, route);
            modal.ShowDialog();
            Zone.SortRoutes();
            RebuildRouteStatus();
        }

        private void bStatus_Click(object sender, EventArgs e)
        {
            var report = new DataModel.Reports.ZoneStatusReport(Zone);
            var popup = new Report(report.Run());
            popup.Show();
        }

        private void bZoneScheme_Click(object sender, EventArgs e)
        {
            var report = new DataModel.Reports.ZoneSchemeReport(Zone);
            var popup = new Report(report.Run());
            popup.Show();
        }

        private void bZoneDetail_Click(object sender, EventArgs e)
        {
            var report = new DataModel.Reports.ZoneDetailReport(Zone);
            var popup = new Report(report.Run());
            popup.Show();
        }
    }
}
