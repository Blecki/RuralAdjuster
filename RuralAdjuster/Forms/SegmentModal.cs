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
    public partial class SegmentModal : Form
    {
        public SegmentModal(DataModel.Segment Segment)
        {
            InitializeComponent();
            segmentEdit1.SetSegment(Segment);
        }

        private void segmentEdit1_OnCloseClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
