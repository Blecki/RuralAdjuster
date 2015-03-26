namespace RuralAdjuster.Forms
{
    partial class SegmentModal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.segmentEdit1 = new RuralAdjuster.Forms.SegmentEdit();
            this.SuspendLayout();
            // 
            // segmentEdit1
            // 
            this.segmentEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.segmentEdit1.Enabled = false;
            this.segmentEdit1.Location = new System.Drawing.Point(0, 0);
            this.segmentEdit1.Name = "segmentEdit1";
            this.segmentEdit1.Padding = new System.Windows.Forms.Padding(3);
            this.segmentEdit1.Size = new System.Drawing.Size(658, 534);
            this.segmentEdit1.TabIndex = 0;
            this.segmentEdit1.OnCloseClicked += new System.EventHandler<System.EventArgs>(this.segmentEdit1_OnCloseClicked);
            // 
            // SegmentModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 534);
            this.Controls.Add(this.segmentEdit1);
            this.Name = "SegmentModal";
            this.Text = "Editing Segment";
            this.ResumeLayout(false);

        }

        #endregion

        private SegmentEdit segmentEdit1;
    }
}