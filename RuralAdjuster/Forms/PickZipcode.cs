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
    public partial class PickZipcode : Form
    {
        public int EnteredNumber = 0;
        public bool WasCancelled = false;
        private Color textboxBackColor;

        public PickZipcode()
        {
            InitializeComponent();

            textboxBackColor = this.tbRouteNumber.BackColor;
        }

        private void tbRouteNumber_TextChanged(object sender, EventArgs e)
        {
            lError.Text = "";

            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
            {
                if (tbRouteNumber.Text.Length == 5)
                    EnteredNumber = newValue.Value;
                else
                {
                    tbRouteNumber.BackColor = Color.Red;
                    lError.Text = "Please enter a 5 digit zipcode.";
                }
            }
            else
                this.lError.Text = "Please enter numbers only.";
        }

        private void bCreateRoute_Click(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(tbRouteNumber, textboxBackColor);
            if (newValue.HasValue)
            {
                if (tbRouteNumber.Text.Length == 5)
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
