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
    public partial class PickRouteNumber : Form
    {
        public int EnteredNumber = 0;
        public bool WasCancelled = false;
        public DataModel.Zone Zone;
        private Color textboxBackColor;

        public PickRouteNumber(DataModel.Zone Zone)
        {
            this.Zone = Zone;

            InitializeComponent();

            textboxBackColor = this.tbRouteNumber.BackColor;
        }

        public bool CheckNumber(int num)
        {
            foreach (var Route in Zone.Routes)
                if (Route.Number == num) return false;
            return true;
        }

        private void tbRouteNumber_TextChanged(object sender, EventArgs e)
        {
            lError.Text = "";

            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
            {
                if (CheckNumber(newValue.Value))
                    EnteredNumber = newValue.Value;
                else
                {
                    tbRouteNumber.BackColor = Color.Red;
                    lError.Text = "There is already a route with that number.";
                }
            }
            else
                this.lError.Text = "Please enter an integer.";
        }

        private void bCreateRoute_Click(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(tbRouteNumber, textboxBackColor);
            if (newValue.HasValue)
            {
                if (CheckNumber(newValue.Value))
                {
                    EnteredNumber = newValue.Value;
                    this.Close();
                }
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.WasCancelled = true;
            this.Close();
        }
    }
}
