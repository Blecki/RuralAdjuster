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
    public partial class RouteEdit : UserControl
    {
        public DataModel.Route Route;
        public DataModel.Zone Zone;
        private Color textboxBackColor;
        public event EventHandler<EventArgs> OnCloseClicked;
        private DataModel.Reports.RouteBoxReport BoxReport = null;

        public RouteEdit()
        {
            InitializeComponent();
            textboxBackColor = this.tbBoxFactor.BackColor;

            foreach (var item in typeof(DataModel.LStatus).GetEnumNames())
                this.cbLStatus.Items.Add(item);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            if (OnCloseClicked != null) OnCloseClicked(this, e);
        }

        public void SetRoute(DataModel.Zone Zone, DataModel.Route Route)
        {
            this.Route = Route;
            this.Zone = Zone;
            this.BoxReport = new DataModel.Reports.RouteBoxReport(Route);

            lRouteNumber.Text = String.Format("Route R{0,3:000}", Route.Number);
            tbBoxFactor.Text = Route.BoxFactor.ToString();
            cbLStatus.SelectedItem = Route.LStatus.ToString();

            tbPreEvaluation.Text = DataModel.Evaluation.ToStringEvaluation(Route.PreEvaluation);

            DataModel.Evaluation.BuildEvaluationTable();
            foreach (var entry in DataModel.Evaluation.EvaluationTable)
                this.cbTargetEvaluation.Items.Add(entry.Key);

            tbTargetEvaluation.Text = DataModel.Evaluation.ToStringEvaluation(Route.TargetEvaluation);
            cbTargetEvaluation.Text = DataModel.Evaluation.Name(Route.TargetEvaluation);

            tbRegularBoxes.Text = Route.RegularBoxes.ToString();
            tbCentralizedBoxes.Text = Route.CentralizedBoxes.ToString();
            tbCollectionSlots.Text = Route.CollectionSlots.ToString();
            tbParcelLockers.Text = Route.ParcelLockers.ToString();
            tbMiles.Text = Route.PreMiles.ToString();
            tbDismounts.Text = Route.Dismounts.ToString();
            tbDismountDistance.Text = Route.DismountDistance.ToString();
            tbLockedPouchStops.Text = Route.LockedPouchStops.ToString();

            tbSuitableAllowance.Text = Route.SuitableAllowance.ToString();

            RebuildBoth();
        }
                
        public void RebuildSegmentList(IEnumerable<DataModel.Segment> segments, Panel view, 
            SegmentQuickEdit.SegmentSection Section)
        {
            this.SuspendLayout();
            
            foreach (var item in view.Controls)
            {
                if (item is SegmentQuickEdit)
                    (item as SegmentQuickEdit).ClearSegment();
            }

            view.Controls.Clear();
            
            foreach (var item in segments)
            {
                var entry = new SegmentQuickEdit(this, Section, item, Zone);
                entry.Dock = DockStyle.Top;
                view.Controls.Add(entry);
            }

            this.ResumeLayout();
        }

        public void RebuildBoth()
        {
            RebuildSegmentList(this.Route.PreSegments, pPreSegments, SegmentQuickEdit.SegmentSection.Pre);
            RebuildSegmentList(this.Route.PostSegments, pPostSegments, SegmentQuickEdit.SegmentSection.Post);
            tbBoxReport.Text = BoxReport.Run();
        }

        public void RefreshSegments()
        {
            foreach (var control in pPreSegments.Controls)
                if (control is SegmentQuickEdit) (control as SegmentQuickEdit).RefreshLabels();
            foreach (var control in pPostSegments.Controls)
                if (control is SegmentQuickEdit) (control as SegmentQuickEdit).RefreshLabels();
            tbBoxReport.Text = BoxReport.Run();
        }

        public void entry_SegmentMoved(SegmentQuickEdit control)
        {
            DataModel.Operations.MoveSegment(control.Segment, control.DestinationRoute);
            RebuildBoth();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newSegment = this.Route.CreateNewSegment();
            var segmentEdit = new SegmentModal(newSegment);
            segmentEdit.ShowDialog();
            RebuildBoth();
        }

        private void bDeleteSelected_Click(object sender, EventArgs e)
        {
            foreach (var control in pPreSegments.Controls)
            {
                var quickEdit = control as SegmentQuickEdit;
                if (quickEdit != null && quickEdit.Selected)
                    DataModel.Operations.DeleteSegment(quickEdit.Segment);
            }
            RebuildBoth();
        }

        private void tbBoxFactor_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyFloatTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.BoxFactor = newValue.Value;

            RefreshSegments();
        }

        private void cbLStatus_TextChanged(object sender, EventArgs e)
        {
            DataModel.LStatus newValue;
            var valid = Enum.TryParse(this.cbLStatus.Text, out newValue);
            if (valid)
            {
                this.cbLStatus.BackColor = textboxBackColor;
                this.Route.LStatus = newValue;
            }
            else
            {
                this.cbLStatus.BackColor = Color.Red;
            }

            RefreshSegments();
        }

        private void tbRegularBoxes_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.RegularBoxes = newValue.Value;
            tbBoxReport.Text = BoxReport.Run();
        }

        private void tbCentralizedBoxes_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.CentralizedBoxes = newValue.Value;
            tbBoxReport.Text = BoxReport.Run();
        }

        private void tbCollectionSlots_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.CollectionSlots = newValue.Value;
            tbBoxReport.Text = BoxReport.Run();
        }


        private void tbParcelLockers_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.ParcelLockers = newValue.Value;
            tbBoxReport.Text = BoxReport.Run();
        }

        private void tbPreMiles_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyFloatTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.PreMiles = newValue.Value;
        }

        private void tbDismounts_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.Dismounts = newValue.Value;
            tbBoxReport.Text = BoxReport.Run();
        }

        private void tbDismountDistance_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.DismountDistance = newValue.Value;
            tbBoxReport.Text = BoxReport.Run();
        }

        private void tbLockedPouchStops_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyNumberTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.LockedPouchStops = newValue.Value;
        }

        private void tbPreEvaluation_TextChanged(object sender, EventArgs e)
        {
            if (this.tbPreEvaluation.Text.Contains(":"))
            {
                var parts = this.tbPreEvaluation.Text.Split(new char[] { ':' });
                if (parts.Length != 2)
                    this.tbPreEvaluation.BackColor = Color.Red;
                else
                {
                    int hourValue = 0;
                    int minuteValue = 0;
                    if (Int32.TryParse(parts[0], out hourValue) &&
                        Int32.TryParse(parts[1], out minuteValue))
                    {
                        this.Route.PreEvaluation = (int)DataModel.Evaluation.ToMinutes(hourValue, minuteValue);
                        this.tbPreEvaluation.BackColor = textboxBackColor;
                    }
                    else
                        this.tbPreEvaluation.BackColor = Color.Red;
                }
            }
            else
            {
                int integerValue = 0;
                if (Int32.TryParse(this.tbPreEvaluation.Text, out integerValue))
                {
                    this.Route.PreEvaluation = integerValue;
                    this.tbPreEvaluation.BackColor = textboxBackColor;
                }
                else
                    this.tbPreEvaluation.BackColor = Color.Red;
            }
        }

        private bool UpdatingTextBox = false;

        private void tbTargetEvaluation_TextChanged(object sender, EventArgs e)
        {
            if (UpdatingTextBox) return;
            if (this.tbTargetEvaluation.Text.Contains(":"))
            {
                var parts = this.tbTargetEvaluation.Text.Split(new char[] { ':' });
                if (parts.Length != 2)
                    this.tbTargetEvaluation.BackColor = Color.Red;
                else
                {
                    int hourValue = 0;
                    int minuteValue = 0;
                    if (Int32.TryParse(parts[0], out hourValue) &&
                        Int32.TryParse(parts[1], out minuteValue))
                    {
                        this.Route.TargetEvaluation = (int)DataModel.Evaluation.ToMinutes(hourValue, minuteValue);
                        this.tbTargetEvaluation.BackColor = textboxBackColor;
                        UpdatingTextBox = true;
                        this.cbTargetEvaluation.Text = DataModel.Evaluation.Name(this.Route.TargetEvaluation);
                        UpdatingTextBox = false;
                    }
                    else
                        this.tbTargetEvaluation.BackColor = Color.Red;
                }
            }
            else
            {
                int integerValue = 0;
                if (Int32.TryParse(this.tbTargetEvaluation.Text, out integerValue))
                {
                    this.Route.TargetEvaluation = integerValue;
                    this.tbTargetEvaluation.BackColor = textboxBackColor;
                    UpdatingTextBox = true;
                    this.cbTargetEvaluation.Text = DataModel.Evaluation.Name(this.Route.TargetEvaluation);
                    UpdatingTextBox = false;
                }
                else
                    this.tbTargetEvaluation.BackColor = Color.Red;
            }
        }

        private void cbTargetEvaluation_TextUpdate(object sender, EventArgs e)
        {
            if (UpdatingTextBox) return;
            this.Route.TargetEvaluation = (int)DataModel.Evaluation.EvaluationTable[this.cbTargetEvaluation.Text].Low;
            this.tbTargetEvaluation.Text = DataModel.Evaluation.ToStringEvaluation(this.Route.TargetEvaluation);
        }

        private void bSchemeReport_Click(object sender, EventArgs e)
        {
            var report = new DataModel.Reports.RouteSchemeReport(this.Route);
            var window = new Report(report.Run());
            window.Show();
        }

        private void bRouteSummary_Click(object sender, EventArgs e)
        {
            var report = new DataModel.Reports.RouteStatusReport(this.Route);
            var window = new Report(report.Run());
            window.Show();
        }

        private void tbSuitableAllowance_TextChanged(object sender, EventArgs e)
        {
            var newValue = Utility.VerifyFloatTextBox(sender, textboxBackColor);
            if (newValue.HasValue)
                this.Route.SuitableAllowance = newValue.Value;
            tbBoxReport.Text = BoxReport.Run();
        }
    }
}
