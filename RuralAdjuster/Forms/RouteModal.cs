using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RuralAdjuster.Forms
{
    public partial class RouteModal : Form
    {
        public RouteModal(DataModel.Zone Zone, DataModel.Route Route)
        {
            InitializeComponent();
            routeEdit1.SetRoute(Zone, Route);
        }

        private void routeEdit1_OnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
