namespace RuralAdjuster.Forms
{
    partial class SegmentQuickEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSelected = new System.Windows.Forms.CheckBox();
            this.bEditSegment = new System.Windows.Forms.Button();
            this.cbDestinationRoute = new System.Windows.Forms.ComboBox();
            this.lSourceRoute = new System.Windows.Forms.Label();
            this.lComment = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbSelected
            // 
            this.cbSelected.AutoSize = true;
            this.cbSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSelected.Location = new System.Drawing.Point(0, 0);
            this.cbSelected.Name = "cbSelected";
            this.cbSelected.Size = new System.Drawing.Size(15, 21);
            this.cbSelected.TabIndex = 0;
            this.cbSelected.UseVisualStyleBackColor = true;
            // 
            // bEditSegment
            // 
            this.bEditSegment.Dock = System.Windows.Forms.DockStyle.Right;
            this.bEditSegment.Location = new System.Drawing.Point(549, 0);
            this.bEditSegment.Name = "bEditSegment";
            this.bEditSegment.Size = new System.Drawing.Size(75, 21);
            this.bEditSegment.TabIndex = 1;
            this.bEditSegment.Text = "edit";
            this.bEditSegment.UseVisualStyleBackColor = true;
            this.bEditSegment.Click += new System.EventHandler(this.bEditSegment_Click);
            // 
            // cbDestinationRoute
            // 
            this.cbDestinationRoute.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbDestinationRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDestinationRoute.FormattingEnabled = true;
            this.cbDestinationRoute.Location = new System.Drawing.Point(428, 0);
            this.cbDestinationRoute.Name = "cbDestinationRoute";
            this.cbDestinationRoute.Size = new System.Drawing.Size(121, 21);
            this.cbDestinationRoute.TabIndex = 2;
            this.cbDestinationRoute.SelectionChangeCommitted += new System.EventHandler(this.cbDestinationRoute_SelectionChangeCommitted);
            // 
            // lSourceRoute
            // 
            this.lSourceRoute.Dock = System.Windows.Forms.DockStyle.Right;
            this.lSourceRoute.Location = new System.Drawing.Point(355, 0);
            this.lSourceRoute.Name = "lSourceRoute";
            this.lSourceRoute.Size = new System.Drawing.Size(73, 21);
            this.lSourceRoute.TabIndex = 3;
            this.lSourceRoute.Text = "Source: R000";
            this.lSourceRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lComment
            // 
            this.lComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lComment.Location = new System.Drawing.Point(70, 0);
            this.lComment.Name = "lComment";
            this.lComment.Size = new System.Drawing.Size(285, 21);
            this.lComment.TabIndex = 4;
            this.lComment.Text = "Comment";
            this.lComment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lValue
            // 
            this.lValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lValue.Location = new System.Drawing.Point(15, 0);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(53, 21);
            this.lValue.TabIndex = 5;
            this.lValue.Text = "000.00";
            this.lValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(68, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 21);
            this.panel1.TabIndex = 6;
            // 
            // SegmentQuickEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lComment);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lValue);
            this.Controls.Add(this.lSourceRoute);
            this.Controls.Add(this.cbDestinationRoute);
            this.Controls.Add(this.bEditSegment);
            this.Controls.Add(this.cbSelected);
            this.Name = "SegmentQuickEdit";
            this.Size = new System.Drawing.Size(624, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbSelected;
        private System.Windows.Forms.Button bEditSegment;
        private System.Windows.Forms.ComboBox cbDestinationRoute;
        private System.Windows.Forms.Label lSourceRoute;
        private System.Windows.Forms.Label lComment;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Panel panel1;
    }
}
