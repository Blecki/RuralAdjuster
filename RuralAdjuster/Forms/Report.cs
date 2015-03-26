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
    public partial class Report : Form
    {
        public Report(String data)
        {
            InitializeComponent();
            this.tbOutput.Text = data;
        }

        private void saveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileDialog = new SaveFileDialog();
            var result = fileDialog.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.Cancel)
            {
                System.IO.File.WriteAllText(fileDialog.FileName, this.tbOutput.Text);
            }
        }
    }
}
