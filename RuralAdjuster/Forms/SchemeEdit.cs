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
    public partial class SchemeEdit : UserControl
    {
        public DataModel.SchemeEntry SchemeEntry; 
        private Color textboxBackColor;

        public SchemeEdit()
        {
            InitializeComponent();

            textboxBackColor = this.tbLow.BackColor;
            foreach (var item in typeof(DataModel.SequenceType).GetEnumNames())
                this.cbSequenceType.Items.Add(item);
        }

        public bool Selected { get { return cbSelected.Checked; } }

        void tbStreetName_TextChanged(object sender, EventArgs e)
        {
            if (SchemeEntry != null)
                SchemeEntry.StreetName = (sender as TextBox).Text;
        }

        public void SetSchemeEntry(DataModel.SchemeEntry SchemeEntry)
        {
            this.SchemeEntry = SchemeEntry;
            this.tbStreetName.Text = SchemeEntry.StreetName;
            this.tbLow.Text = SchemeEntry.Low.ToString();
            this.tbHigh.Text = SchemeEntry.High.ToString();
            this.cbSequenceType.Text = SchemeEntry.SequenceType.ToString();
            this.tbBoxCount.Text = SchemeEntry.BoxCount.ToString();
        }

        private void tbLow_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.SchemeEntry != null)
                this.SchemeEntry.Low = newValue.Value;
        }

        private void tbHigh_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.SchemeEntry != null)
                this.SchemeEntry.High = newValue.Value;
        }

        private void tbBoxCount_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.SchemeEntry != null)
                this.SchemeEntry.BoxCount = newValue.Value;
        }

        private void cbSequenceType_TextChanged(object sender, EventArgs e)
        {
            DataModel.SequenceType newValue;
            var valid = Enum.TryParse(this.cbSequenceType.Text, out newValue);
            if (valid)
            {
                this.cbSequenceType.BackColor = textboxBackColor;
                this.SchemeEntry.SequenceType = newValue;
            }
            else
            {
                this.cbSequenceType.BackColor = Color.Red;
            }
        }
    }
}
