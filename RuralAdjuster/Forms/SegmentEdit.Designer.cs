namespace RuralAdjuster.Forms
{
    partial class SegmentEdit
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
            this.tbComment = new System.Windows.Forms.TextBox();
            this.tbRegularBoxes = new System.Windows.Forms.TextBox();
            this.tbCentralizedBoxes = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bNewScheme = new System.Windows.Forms.Button();
            this.pScheme = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCollectionSlots = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbParcelLockers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDismounts = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDismountDistance = new System.Windows.Forms.TextBox();
            this.bDeleteSelectedScheme = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbComment
            // 
            this.tbComment.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbComment.Location = new System.Drawing.Point(3, 3);
            this.tbComment.Margin = new System.Windows.Forms.Padding(10);
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(685, 20);
            this.tbComment.TabIndex = 0;
            this.tbComment.TextChanged += new System.EventHandler(this.tbComment_TextChanged);
            // 
            // tbRegularBoxes
            // 
            this.tbRegularBoxes.Location = new System.Drawing.Point(101, 6);
            this.tbRegularBoxes.Name = "tbRegularBoxes";
            this.tbRegularBoxes.Size = new System.Drawing.Size(100, 20);
            this.tbRegularBoxes.TabIndex = 1;
            this.tbRegularBoxes.TextChanged += new System.EventHandler(this.tbRegularBoxes_TextChanged);
            // 
            // tbCentralizedBoxes
            // 
            this.tbCentralizedBoxes.Location = new System.Drawing.Point(101, 32);
            this.tbCentralizedBoxes.Name = "tbCentralizedBoxes";
            this.tbCentralizedBoxes.Size = new System.Drawing.Size(100, 20);
            this.tbCentralizedBoxes.TabIndex = 2;
            this.tbCentralizedBoxes.TextChanged += new System.EventHandler(this.tbCentralizedBoxes_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tbDismountDistance);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbDismounts);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbMiles);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbParcelLockers);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tbCollectionSlots);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbRegularBoxes);
            this.panel1.Controls.Add(this.tbCentralizedBoxes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 110);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Centralized Boxes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Regular Boxes";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bDeleteSelectedScheme);
            this.panel2.Controls.Add(this.bNewScheme);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 25);
            this.panel2.TabIndex = 5;
            // 
            // bNewScheme
            // 
            this.bNewScheme.Dock = System.Windows.Forms.DockStyle.Right;
            this.bNewScheme.Location = new System.Drawing.Point(571, 0);
            this.bNewScheme.Name = "bNewScheme";
            this.bNewScheme.Size = new System.Drawing.Size(114, 25);
            this.bNewScheme.TabIndex = 0;
            this.bNewScheme.Text = "New Scheme Entry";
            this.bNewScheme.UseVisualStyleBackColor = true;
            this.bNewScheme.Click += new System.EventHandler(this.button1_Click);
            // 
            // pScheme
            // 
            this.pScheme.AutoScroll = true;
            this.pScheme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pScheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pScheme.Location = new System.Drawing.Point(3, 158);
            this.pScheme.Name = "pScheme";
            this.pScheme.Size = new System.Drawing.Size(685, 380);
            this.pScheme.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Collection Slots";
            // 
            // tbCollectionSlots
            // 
            this.tbCollectionSlots.Location = new System.Drawing.Point(101, 58);
            this.tbCollectionSlots.Name = "tbCollectionSlots";
            this.tbCollectionSlots.Size = new System.Drawing.Size(100, 20);
            this.tbCollectionSlots.TabIndex = 5;
            this.tbCollectionSlots.TextChanged += new System.EventHandler(this.tbCollectionSlots_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parcel Lockers";
            // 
            // tbParcelLockers
            // 
            this.tbParcelLockers.Location = new System.Drawing.Point(101, 84);
            this.tbParcelLockers.Name = "tbParcelLockers";
            this.tbParcelLockers.Size = new System.Drawing.Size(100, 20);
            this.tbParcelLockers.TabIndex = 7;
            this.tbParcelLockers.TextChanged += new System.EventHandler(this.tbParcelLockers_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Miles";
            // 
            // tbMiles
            // 
            this.tbMiles.Location = new System.Drawing.Point(305, 5);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.Size = new System.Drawing.Size(100, 20);
            this.tbMiles.TabIndex = 9;
            this.tbMiles.TextChanged += new System.EventHandler(this.tbMiles_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dismounts";
            // 
            // tbDismounts
            // 
            this.tbDismounts.Location = new System.Drawing.Point(305, 32);
            this.tbDismounts.Name = "tbDismounts";
            this.tbDismounts.Size = new System.Drawing.Size(100, 20);
            this.tbDismounts.TabIndex = 11;
            this.tbDismounts.TextChanged += new System.EventHandler(this.tbDismounts_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dismount Distance";
            // 
            // tbDismountDistance
            // 
            this.tbDismountDistance.Location = new System.Drawing.Point(305, 58);
            this.tbDismountDistance.Name = "tbDismountDistance";
            this.tbDismountDistance.Size = new System.Drawing.Size(100, 20);
            this.tbDismountDistance.TabIndex = 13;
            this.tbDismountDistance.TextChanged += new System.EventHandler(this.tbDismountDistance_TextChanged);
            // 
            // bDeleteSelectedScheme
            // 
            this.bDeleteSelectedScheme.Dock = System.Windows.Forms.DockStyle.Right;
            this.bDeleteSelectedScheme.Location = new System.Drawing.Point(436, 0);
            this.bDeleteSelectedScheme.Name = "bDeleteSelectedScheme";
            this.bDeleteSelectedScheme.Size = new System.Drawing.Size(135, 25);
            this.bDeleteSelectedScheme.TabIndex = 1;
            this.bDeleteSelectedScheme.Text = "Delete Selected Scheme";
            this.bDeleteSelectedScheme.UseVisualStyleBackColor = true;
            this.bDeleteSelectedScheme.Click += new System.EventHandler(this.bDeleteSelectedScheme_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(607, 84);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 15;
            this.bClose.Text = "Done";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // SegmentEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pScheme);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbComment);
            this.Name = "SegmentEdit";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Size = new System.Drawing.Size(691, 541);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.TextBox tbRegularBoxes;
        private System.Windows.Forms.TextBox tbCentralizedBoxes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bNewScheme;
        private System.Windows.Forms.Panel pScheme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDismountDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDismounts;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbParcelLockers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCollectionSlots;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bDeleteSelectedScheme;
    }
}
