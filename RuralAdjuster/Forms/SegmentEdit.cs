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
    public partial class SegmentEdit : UserControl
    {
        public DataModel.Segment Segment;
        private Color textboxBackColor;
        public event EventHandler<EventArgs> OnCloseClicked;

        public SegmentEdit()
        {
            InitializeComponent();
            this.Enabled = false;
            textboxBackColor = this.tbRegularBoxes.BackColor;
        }

        public void SetSegment(DataModel.Segment Segment)
        {
            this.Segment = Segment;
            this.Enabled = Segment != null;

            if (Segment != null)
            {
                tbComment.Text = Segment.Comment;
                tbRegularBoxes.Text = Segment.RegularBoxes.ToString();
                tbCentralizedBoxes.Text = Segment.CentralizedBoxes.ToString();
                tbCollectionSlots.Text = Segment.CollectionSlots.ToString();
                tbParcelLockers.Text = Segment.ParcelLockers.ToString();
                tbMiles.Text = Segment.Miles.ToString();
                tbDismounts.Text = Segment.Dismounts.ToString();
                tbDismountDistance.Text = Segment.DismountDistance.ToString();
            }

            RebuildSchemeTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Segment != null)
                this.Segment.Scheme.Add(new DataModel.SchemeEntry());
            RebuildSchemeTable();
            
        }

        private void RebuildSchemeTable()
        {
            this.pScheme.Controls.Clear();
            this.SuspendLayout();
            Utility.SuspendDrawing(this);
            if (this.Segment != null)
            {
                foreach (var schemeEntry in this.Segment.Scheme)
                {
                    var schemeEditor = new SchemeEdit();
                    schemeEditor.SetSchemeEntry(schemeEntry);
                    schemeEditor.Dock = DockStyle.Top;
                    this.pScheme.Controls.Add(schemeEditor);
                }
            }
            Utility.ResumeDrawing(this);
            this.ResumeLayout();
            //this.pScheme.LayoutEngine.Layout(this.pScheme.Controls, new LayoutEventArgs(this.pScheme, ""));
        }

        private void tbComment_TextChanged(object sender, EventArgs e)
        {
            if (this.Segment != null) this.Segment.Comment = this.tbComment.Text;
        }

        private void tbRegularBoxes_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.Segment != null)
                this.Segment.RegularBoxes = newValue.Value;
        }

        private void tbCentralizedBoxes_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.Segment != null)
                this.Segment.CentralizedBoxes = newValue.Value;
        }

        private void tbCollectionSlots_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.Segment != null)
                this.Segment.CollectionSlots = newValue.Value;
        }

        private void tbParcelLockers_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.Segment != null)
                this.Segment.ParcelLockers = newValue.Value;
        }

        private void tbMiles_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyFloatTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.Segment != null)
                this.Segment.Miles = newValue.Value;
        }

        private void tbDismounts_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.Segment != null)
                this.Segment.Dismounts = newValue.Value;
        }

        private void tbDismountDistance_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue && this.Segment != null)
                this.Segment.DismountDistance = newValue.Value;
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (OnCloseClicked != null) OnCloseClicked(this, e);
        }

        private void bDeleteSelectedScheme_Click(object sender, EventArgs e)
        {
            if (this.Segment != null)
                foreach (var control in this.pScheme.Controls)
                {
                    var scheme = control as SchemeEdit;
                    if (scheme != null && scheme.Selected)
                        this.Segment.Scheme.Remove(scheme.SchemeEntry);
                }

            RebuildSchemeTable();
        }


    }
}
