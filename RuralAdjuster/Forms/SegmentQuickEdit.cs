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
    public partial class SegmentQuickEdit : UserControl
    {
        public DataModel.Segment Segment;
        public RouteEdit LogicalParent;
        public SegmentSection Section;

        public enum SegmentSection
        {
            Pre,
            Post
        }

        public bool Selected { get { return cbSelected.Checked; } }

        public SegmentQuickEdit(RouteEdit LogicalParent, SegmentSection Section, DataModel.Segment Segment, DataModel.Zone Zone)
        {
            this.LogicalParent = LogicalParent;
            this.Section = Section;

            InitializeComponent();
            
            SetSegment(Segment, Zone);

            if (Section == SegmentSection.Post)
                cbSelected.Enabled = false;
        }

        public void SetSegment(DataModel.Segment Segment, DataModel.Zone Zone)
        {
            if (this.Segment != null)
                this.Segment.OnChanges -= this.RefreshLabels;

            this.Segment = Segment;

            if (this.Segment != null)
            {
                Segment.OnChanges += this.RefreshLabels;

                foreach (var route in Zone.Routes)
                    cbDestinationRoute.Items.Add(route);

                RefreshLabels();
                this.Enabled = true;
            }
            else
            {
                this.Enabled = false;
            }
        }

        public void ClearSegment()
        {
            if (this.Segment != null)
                this.Segment.OnChanges -= this.RefreshLabels;
            this.Segment = null;
            this.Enabled = false;
        }
        
        public DataModel.Route DestinationRoute { get { return this.cbDestinationRoute.SelectedItem as DataModel.Route; } }

        private bool Refreshing = false;
        public void RefreshLabels()
        {
            Refreshing = true;

            this.lComment.Text = Segment.Comment;
            this.lSourceRoute.Text = String.Format("Source: R{0,3:000}", Segment.SourceRoute.Number);

            cbDestinationRoute.SelectedItem = Segment.DestinationRoute;

            var valuePrefix = "  ";
            if (Section == SegmentSection.Pre && this.Segment.SourceRoute != this.Segment.DestinationRoute)
                valuePrefix = "- ";
            if (Section == SegmentSection.Post && this.Segment.SourceRoute != this.Segment.DestinationRoute)
                valuePrefix = "+ ";
            this.lValue.Text = valuePrefix + String.Format("{0,6:000.00}", this.Segment.Value);

            Refreshing = false;
        }

        private void bEditSegment_Click(object sender, EventArgs e)
        {
            var segmentEditor = new SegmentModal(this.Segment);
            segmentEditor.ShowDialog();
            this.Segment.MadeChanges();
        }

        private void cbDestinationRoute_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Refreshing) return;
            LogicalParent.entry_SegmentMoved(this);
        }
    }
}
