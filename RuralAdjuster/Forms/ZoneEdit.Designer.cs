namespace RuralAdjuster.Forms
{
    partial class ZoneEdit
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pRouteStatus = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pSide = new System.Windows.Forms.Panel();
            this.bStatus = new System.Windows.Forms.Button();
            this.bNewRoute = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bZoneScheme = new System.Windows.Forms.Button();
            this.bZoneDetail = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pRouteStatus);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.MaximumSize = new System.Drawing.Size(539, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 501);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Routes";
            // 
            // pRouteStatus
            // 
            this.pRouteStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pRouteStatus.Location = new System.Drawing.Point(3, 35);
            this.pRouteStatus.Name = "pRouteStatus";
            this.pRouteStatus.Size = new System.Drawing.Size(531, 463);
            this.pRouteStatus.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 19);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(176, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pre";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(272, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Target";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(365, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Post";
            // 
            // pSide
            // 
            this.pSide.Controls.Add(this.bZoneDetail);
            this.pSide.Controls.Add(this.bZoneScheme);
            this.pSide.Controls.Add(this.bStatus);
            this.pSide.Controls.Add(this.bNewRoute);
            this.pSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.pSide.Location = new System.Drawing.Point(537, 0);
            this.pSide.Name = "pSide";
            this.pSide.Size = new System.Drawing.Size(82, 501);
            this.pSide.TabIndex = 1;
            // 
            // bStatus
            // 
            this.bStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.bStatus.Location = new System.Drawing.Point(0, 23);
            this.bStatus.Name = "bStatus";
            this.bStatus.Size = new System.Drawing.Size(82, 23);
            this.bStatus.TabIndex = 1;
            this.bStatus.Text = "Zone Status";
            this.bStatus.UseVisualStyleBackColor = true;
            this.bStatus.Click += new System.EventHandler(this.bStatus_Click);
            // 
            // bNewRoute
            // 
            this.bNewRoute.Dock = System.Windows.Forms.DockStyle.Top;
            this.bNewRoute.Location = new System.Drawing.Point(0, 0);
            this.bNewRoute.Name = "bNewRoute";
            this.bNewRoute.Size = new System.Drawing.Size(82, 23);
            this.bNewRoute.TabIndex = 0;
            this.bNewRoute.Text = "New Route";
            this.bNewRoute.UseVisualStyleBackColor = true;
            this.bNewRoute.Click += new System.EventHandler(this.bNewRoute_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 501);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(619, 49);
            this.panel3.TabIndex = 2;
            // 
            // bZoneScheme
            // 
            this.bZoneScheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.bZoneScheme.Location = new System.Drawing.Point(0, 46);
            this.bZoneScheme.Name = "bZoneScheme";
            this.bZoneScheme.Size = new System.Drawing.Size(82, 23);
            this.bZoneScheme.TabIndex = 2;
            this.bZoneScheme.Text = "Zone Scheme";
            this.bZoneScheme.UseVisualStyleBackColor = true;
            this.bZoneScheme.Click += new System.EventHandler(this.bZoneScheme_Click);
            // 
            // bZoneDetail
            // 
            this.bZoneDetail.Dock = System.Windows.Forms.DockStyle.Top;
            this.bZoneDetail.Location = new System.Drawing.Point(0, 69);
            this.bZoneDetail.Name = "bZoneDetail";
            this.bZoneDetail.Size = new System.Drawing.Size(82, 23);
            this.bZoneDetail.TabIndex = 3;
            this.bZoneDetail.Text = "Zone Detail";
            this.bZoneDetail.UseVisualStyleBackColor = true;
            this.bZoneDetail.Click += new System.EventHandler(this.bZoneDetail_Click);
            // 
            // ZoneEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pSide);
            this.Controls.Add(this.panel3);
            this.Name = "ZoneEdit";
            this.Size = new System.Drawing.Size(619, 550);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pSide.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSide;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pRouteStatus;
        private System.Windows.Forms.Button bNewRoute;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bStatus;
        private System.Windows.Forms.Button bZoneScheme;
        private System.Windows.Forms.Button bZoneDetail;
    }
}
