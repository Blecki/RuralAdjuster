using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RuralAdjuster
{
    public partial class MainForm : Form
    {
        private DataModel.Zone Zone;

        public MainForm()
        {
            InitializeComponent();
            this.zoneEdit1.Enabled = false;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileChooser = new SaveFileDialog();
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                DataModel.Operations.Serialize(Zone, fileChooser.FileName);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileChooser = new OpenFileDialog();
            if (fileChooser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var loaded = DataModel.Operations.Deserialize(fileChooser.FileName);
                if (loaded != null)
                {
                    this.Zone = loaded;
                    this.zoneEdit1.SetZone(loaded);
                    this.Text = String.Format("Adjusting Zone {0}", loaded.Zipcode);
                    this.zoneEdit1.Enabled = true;
                }
                else
                    MessageBox.Show(String.Format("Could not load zone data from file {0}.", fileChooser.FileName));
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zipcodePopup = new Forms.PickZipcode();
            zipcodePopup.ShowDialog();
            if (zipcodePopup.WasCancelled) return;
            Zone = new DataModel.Zone();
            Zone.Zipcode = zipcodePopup.EnteredNumber;
            this.zoneEdit1.SetZone(Zone);
            this.zoneEdit1.Enabled = true;
            this.Text = String.Format("Adjusting Zone {0}", Zone.Zipcode);
        }
    }
}
