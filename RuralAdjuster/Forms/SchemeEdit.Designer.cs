namespace RuralAdjuster.Forms
{
    partial class SchemeEdit
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
            this.tbStreetName = new System.Windows.Forms.TextBox();
            this.tbLow = new System.Windows.Forms.TextBox();
            this.tbHigh = new System.Windows.Forms.TextBox();
            this.cbSequenceType = new System.Windows.Forms.ComboBox();
            this.tbBoxCount = new System.Windows.Forms.TextBox();
            this.cbSelected = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbStreetName
            // 
            this.tbStreetName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStreetName.Location = new System.Drawing.Point(15, 0);
            this.tbStreetName.Name = "tbStreetName";
            this.tbStreetName.Size = new System.Drawing.Size(380, 20);
            this.tbStreetName.TabIndex = 0;
            this.tbStreetName.TextChanged += new System.EventHandler(this.tbStreetName_TextChanged);
            // 
            // tbLow
            // 
            this.tbLow.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbLow.Location = new System.Drawing.Point(395, 0);
            this.tbLow.Name = "tbLow";
            this.tbLow.Size = new System.Drawing.Size(68, 20);
            this.tbLow.TabIndex = 1;
            this.tbLow.TextChanged += new System.EventHandler(this.tbLow_TextChanged);
            // 
            // tbHigh
            // 
            this.tbHigh.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbHigh.Location = new System.Drawing.Point(463, 0);
            this.tbHigh.Name = "tbHigh";
            this.tbHigh.Size = new System.Drawing.Size(62, 20);
            this.tbHigh.TabIndex = 2;
            this.tbHigh.TextChanged += new System.EventHandler(this.tbHigh_TextChanged);
            // 
            // cbSequenceType
            // 
            this.cbSequenceType.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbSequenceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSequenceType.FormattingEnabled = true;
            this.cbSequenceType.Location = new System.Drawing.Point(525, 0);
            this.cbSequenceType.Name = "cbSequenceType";
            this.cbSequenceType.Size = new System.Drawing.Size(56, 21);
            this.cbSequenceType.TabIndex = 3;
            this.cbSequenceType.TextChanged += new System.EventHandler(this.cbSequenceType_TextChanged);
            // 
            // tbBoxCount
            // 
            this.tbBoxCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbBoxCount.Location = new System.Drawing.Point(581, 0);
            this.tbBoxCount.Name = "tbBoxCount";
            this.tbBoxCount.Size = new System.Drawing.Size(43, 20);
            this.tbBoxCount.TabIndex = 4;
            this.tbBoxCount.TextChanged += new System.EventHandler(this.tbBoxCount_TextChanged);
            // 
            // cbSelected
            // 
            this.cbSelected.AutoSize = true;
            this.cbSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbSelected.Location = new System.Drawing.Point(0, 0);
            this.cbSelected.Name = "cbSelected";
            this.cbSelected.Size = new System.Drawing.Size(15, 24);
            this.cbSelected.TabIndex = 5;
            this.cbSelected.UseVisualStyleBackColor = true;
            // 
            // SchemeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbStreetName);
            this.Controls.Add(this.cbSelected);
            this.Controls.Add(this.tbLow);
            this.Controls.Add(this.tbHigh);
            this.Controls.Add(this.cbSequenceType);
            this.Controls.Add(this.tbBoxCount);
            this.Name = "SchemeEdit";
            this.Size = new System.Drawing.Size(624, 24);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStreetName;
        private System.Windows.Forms.TextBox tbLow;
        private System.Windows.Forms.TextBox tbHigh;
        private System.Windows.Forms.ComboBox cbSequenceType;
        private System.Windows.Forms.TextBox tbBoxCount;
        private System.Windows.Forms.CheckBox cbSelected;

    }
}
