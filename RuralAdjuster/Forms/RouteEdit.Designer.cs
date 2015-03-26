namespace RuralAdjuster.Forms
{
    partial class RouteEdit
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.bRouteSummary = new System.Windows.Forms.Button();
            this.bSchemeReport = new System.Windows.Forms.Button();
            this.cbLStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbBoxFactor = new System.Windows.Forms.TextBox();
            this.lRouteNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbTargetEvaluation = new System.Windows.Forms.TextBox();
            this.cbTargetEvaluation = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPreEvaluation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbLockedPouchStops = new System.Windows.Forms.TextBox();
            this.tbCentralizedBoxes = new System.Windows.Forms.TextBox();
            this.tbRegularBoxes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbDismountDistance = new System.Windows.Forms.TextBox();
            this.tbCollectionSlots = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDismounts = new System.Windows.Forms.TextBox();
            this.tbParcelLockers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pPreSegments = new System.Windows.Forms.Panel();
            this.bDeleteSelected = new System.Windows.Forms.Button();
            this.bNewSegment = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pPostSegments = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbBoxReport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.splitContainer1.Size = new System.Drawing.Size(861, 513);
            this.splitContainer1.SplitterDistance = 224;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bDeleteSelected);
            this.panel1.Controls.Add(this.bRouteSummary);
            this.panel1.Controls.Add(this.bNewSegment);
            this.panel1.Controls.Add(this.bSchemeReport);
            this.panel1.Controls.Add(this.cbLStatus);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.tbBoxFactor);
            this.panel1.Controls.Add(this.lRouteNumber);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.bClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 513);
            this.panel1.TabIndex = 5;
            this.panel1.TabStop = false;
            this.panel1.Text = "Pre-Adjustment Data";
            // 
            // bRouteSummary
            // 
            this.bRouteSummary.Location = new System.Drawing.Point(5, 448);
            this.bRouteSummary.Name = "bRouteSummary";
            this.bRouteSummary.Size = new System.Drawing.Size(102, 23);
            this.bRouteSummary.TabIndex = 28;
            this.bRouteSummary.Text = "Route Summary";
            this.bRouteSummary.UseVisualStyleBackColor = true;
            this.bRouteSummary.Click += new System.EventHandler(this.bRouteSummary_Click);
            // 
            // bSchemeReport
            // 
            this.bSchemeReport.Location = new System.Drawing.Point(5, 419);
            this.bSchemeReport.Name = "bSchemeReport";
            this.bSchemeReport.Size = new System.Drawing.Size(102, 23);
            this.bSchemeReport.TabIndex = 27;
            this.bSchemeReport.Text = "Scheme Report";
            this.bSchemeReport.UseVisualStyleBackColor = true;
            this.bSchemeReport.Click += new System.EventHandler(this.bSchemeReport_Click);
            // 
            // cbLStatus
            // 
            this.cbLStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLStatus.FormattingEnabled = true;
            this.cbLStatus.Location = new System.Drawing.Point(107, 66);
            this.cbLStatus.Name = "cbLStatus";
            this.cbLStatus.Size = new System.Drawing.Size(99, 21);
            this.cbLStatus.TabIndex = 2;
            this.cbLStatus.TextChanged += new System.EventHandler(this.cbLStatus_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 71);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "L Status";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "Box Factor";
            // 
            // tbBoxFactor
            // 
            this.tbBoxFactor.Location = new System.Drawing.Point(107, 39);
            this.tbBoxFactor.Name = "tbBoxFactor";
            this.tbBoxFactor.Size = new System.Drawing.Size(100, 20);
            this.tbBoxFactor.TabIndex = 1;
            this.tbBoxFactor.TextChanged += new System.EventHandler(this.tbBoxFactor_TextChanged);
            // 
            // lRouteNumber
            // 
            this.lRouteNumber.AutoSize = true;
            this.lRouteNumber.Location = new System.Drawing.Point(9, 17);
            this.lRouteNumber.Name = "lRouteNumber";
            this.lRouteNumber.Size = new System.Drawing.Size(44, 13);
            this.lRouteNumber.TabIndex = 23;
            this.lRouteNumber.Text = "Number";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbTargetEvaluation);
            this.groupBox2.Controls.Add(this.cbTargetEvaluation);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbPreEvaluation);
            this.groupBox2.Location = new System.Drawing.Point(5, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 80);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Evaluation";
            // 
            // tbTargetEvaluation
            // 
            this.tbTargetEvaluation.Location = new System.Drawing.Point(103, 50);
            this.tbTargetEvaluation.Name = "tbTargetEvaluation";
            this.tbTargetEvaluation.Size = new System.Drawing.Size(46, 20);
            this.tbTargetEvaluation.TabIndex = 23;
            this.tbTargetEvaluation.TextChanged += new System.EventHandler(this.tbTargetEvaluation_TextChanged);
            // 
            // cbTargetEvaluation
            // 
            this.cbTargetEvaluation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTargetEvaluation.FormattingEnabled = true;
            this.cbTargetEvaluation.Location = new System.Drawing.Point(155, 50);
            this.cbTargetEvaluation.Name = "cbTargetEvaluation";
            this.cbTargetEvaluation.Size = new System.Drawing.Size(46, 21);
            this.cbTargetEvaluation.TabIndex = 22;
            this.cbTargetEvaluation.SelectedIndexChanged += new System.EventHandler(this.cbTargetEvaluation_TextUpdate);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Target-Evaluation";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Pre-Evaluation";
            // 
            // tbPreEvaluation
            // 
            this.tbPreEvaluation.Location = new System.Drawing.Point(102, 24);
            this.tbPreEvaluation.Name = "tbPreEvaluation";
            this.tbPreEvaluation.Size = new System.Drawing.Size(100, 20);
            this.tbPreEvaluation.TabIndex = 3;
            this.tbPreEvaluation.TextChanged += new System.EventHandler(this.tbPreEvaluation_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.tbLockedPouchStops);
            this.groupBox1.Controls.Add(this.tbCentralizedBoxes);
            this.groupBox1.Controls.Add(this.tbRegularBoxes);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbDismountDistance);
            this.groupBox1.Controls.Add(this.tbCollectionSlots);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDismounts);
            this.groupBox1.Controls.Add(this.tbParcelLockers);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbMiles);
            this.groupBox1.Location = new System.Drawing.Point(5, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Box Counts";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Lockd Pouch Stps";
            // 
            // tbLockedPouchStops
            // 
            this.tbLockedPouchStops.Location = new System.Drawing.Point(103, 205);
            this.tbLockedPouchStops.Name = "tbLockedPouchStops";
            this.tbLockedPouchStops.Size = new System.Drawing.Size(100, 20);
            this.tbLockedPouchStops.TabIndex = 18;
            this.tbLockedPouchStops.TextChanged += new System.EventHandler(this.tbLockedPouchStops_TextChanged);
            // 
            // tbCentralizedBoxes
            // 
            this.tbCentralizedBoxes.Location = new System.Drawing.Point(103, 46);
            this.tbCentralizedBoxes.Name = "tbCentralizedBoxes";
            this.tbCentralizedBoxes.Size = new System.Drawing.Size(100, 20);
            this.tbCentralizedBoxes.TabIndex = 6;
            this.tbCentralizedBoxes.TextChanged += new System.EventHandler(this.tbCentralizedBoxes_TextChanged);
            // 
            // tbRegularBoxes
            // 
            this.tbRegularBoxes.Location = new System.Drawing.Point(103, 20);
            this.tbRegularBoxes.Name = "tbRegularBoxes";
            this.tbRegularBoxes.Size = new System.Drawing.Size(100, 20);
            this.tbRegularBoxes.TabIndex = 5;
            this.tbRegularBoxes.TextChanged += new System.EventHandler(this.tbRegularBoxes_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Regular Boxes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dismount Distance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Centralized Boxes";
            // 
            // tbDismountDistance
            // 
            this.tbDismountDistance.Location = new System.Drawing.Point(103, 176);
            this.tbDismountDistance.Name = "tbDismountDistance";
            this.tbDismountDistance.Size = new System.Drawing.Size(100, 20);
            this.tbDismountDistance.TabIndex = 13;
            this.tbDismountDistance.TextChanged += new System.EventHandler(this.tbDismountDistance_TextChanged);
            // 
            // tbCollectionSlots
            // 
            this.tbCollectionSlots.Location = new System.Drawing.Point(103, 72);
            this.tbCollectionSlots.Name = "tbCollectionSlots";
            this.tbCollectionSlots.Size = new System.Drawing.Size(100, 20);
            this.tbCollectionSlots.TabIndex = 7;
            this.tbCollectionSlots.TextChanged += new System.EventHandler(this.tbCollectionSlots_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Dismounts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Collection Slots";
            // 
            // tbDismounts
            // 
            this.tbDismounts.Location = new System.Drawing.Point(103, 150);
            this.tbDismounts.Name = "tbDismounts";
            this.tbDismounts.Size = new System.Drawing.Size(100, 20);
            this.tbDismounts.TabIndex = 11;
            this.tbDismounts.TextChanged += new System.EventHandler(this.tbDismounts_TextChanged);
            // 
            // tbParcelLockers
            // 
            this.tbParcelLockers.Location = new System.Drawing.Point(103, 98);
            this.tbParcelLockers.Name = "tbParcelLockers";
            this.tbParcelLockers.Size = new System.Drawing.Size(100, 20);
            this.tbParcelLockers.TabIndex = 8;
            this.tbParcelLockers.TextChanged += new System.EventHandler(this.tbParcelLockers_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Miles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parcel Lockers";
            // 
            // tbMiles
            // 
            this.tbMiles.Location = new System.Drawing.Point(103, 124);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.Size = new System.Drawing.Size(100, 20);
            this.tbMiles.TabIndex = 9;
            this.tbMiles.TextChanged += new System.EventHandler(this.tbPreMiles_TextChanged);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.Location = new System.Drawing.Point(141, 487);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(75, 23);
            this.bClose.TabIndex = 20;
            this.bClose.Text = "Done";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.groupBox5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer2.Size = new System.Drawing.Size(630, 413);
            this.splitContainer2.SplitterDistance = 215;
            this.splitContainer2.TabIndex = 3;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pPreSegments);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(630, 215);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pre-Adjustment Segments";
            // 
            // pPreSegments
            // 
            this.pPreSegments.AutoScroll = true;
            this.pPreSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPreSegments.Location = new System.Drawing.Point(3, 16);
            this.pPreSegments.Name = "pPreSegments";
            this.pPreSegments.Size = new System.Drawing.Size(624, 196);
            this.pPreSegments.TabIndex = 1;
            // 
            // bDeleteSelected
            // 
            this.bDeleteSelected.Location = new System.Drawing.Point(110, 448);
            this.bDeleteSelected.Name = "bDeleteSelected";
            this.bDeleteSelected.Size = new System.Drawing.Size(106, 23);
            this.bDeleteSelected.TabIndex = 22;
            this.bDeleteSelected.Text = "Delete Selected";
            this.bDeleteSelected.UseVisualStyleBackColor = true;
            this.bDeleteSelected.Click += new System.EventHandler(this.bDeleteSelected_Click);
            // 
            // bNewSegment
            // 
            this.bNewSegment.Location = new System.Drawing.Point(110, 419);
            this.bNewSegment.Name = "bNewSegment";
            this.bNewSegment.Size = new System.Drawing.Size(106, 23);
            this.bNewSegment.TabIndex = 21;
            this.bNewSegment.Text = "Add New Segment";
            this.bNewSegment.UseVisualStyleBackColor = true;
            this.bNewSegment.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pPostSegments);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(630, 194);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Post-Adjustment Segments";
            // 
            // pPostSegments
            // 
            this.pPostSegments.AutoScroll = true;
            this.pPostSegments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPostSegments.Location = new System.Drawing.Point(3, 16);
            this.pPostSegments.Name = "pPostSegments";
            this.pPostSegments.Size = new System.Drawing.Size(624, 175);
            this.pPostSegments.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbBoxReport);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 413);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.groupBox3.Size = new System.Drawing.Size(630, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Post-Adjustment Totals";
            // 
            // tbBoxReport
            // 
            this.tbBoxReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbBoxReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBoxReport.Font = new System.Drawing.Font("Envy Code R", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoxReport.Location = new System.Drawing.Point(6, 16);
            this.tbBoxReport.Multiline = true;
            this.tbBoxReport.Name = "tbBoxReport";
            this.tbBoxReport.ReadOnly = true;
            this.tbBoxReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBoxReport.Size = new System.Drawing.Size(618, 81);
            this.tbBoxReport.TabIndex = 0;
            this.tbBoxReport.Text = "Box Report";
            // 
            // RouteEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "RouteEdit";
            this.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Size = new System.Drawing.Size(861, 516);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bNewSegment;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel pPreSegments;
        private System.Windows.Forms.Panel pPostSegments;
        private System.Windows.Forms.Button bDeleteSelected;
        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPreEvaluation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbCentralizedBoxes;
        private System.Windows.Forms.TextBox tbRegularBoxes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbDismountDistance;
        private System.Windows.Forms.TextBox tbCollectionSlots;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDismounts;
        private System.Windows.Forms.TextBox tbParcelLockers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lRouteNumber;
        private System.Windows.Forms.ComboBox cbLStatus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbBoxFactor;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbLockedPouchStops;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cbTargetEvaluation;
        private System.Windows.Forms.TextBox tbTargetEvaluation;
        private System.Windows.Forms.Button bSchemeReport;
        private System.Windows.Forms.Button bRouteSummary;
        private System.Windows.Forms.TextBox tbBoxReport;

    }
}
