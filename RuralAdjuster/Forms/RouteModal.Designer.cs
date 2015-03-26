namespace RuralAdjuster.Forms
{
    partial class RouteModal
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
            this.routeEdit1 = new RuralAdjuster.Forms.RouteEdit();
            this.SuspendLayout();
            // 
            // routeEdit1
            // 
            this.routeEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.routeEdit1.Location = new System.Drawing.Point(0, 0);
            this.routeEdit1.Name = "routeEdit1";
            this.routeEdit1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.routeEdit1.Size = new System.Drawing.Size(846, 517);
            this.routeEdit1.TabIndex = 0;
            this.routeEdit1.OnCloseClicked += new System.EventHandler<System.EventArgs>(this.routeEdit1_OnCloseClicked);
            // 
            // RouteModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 517);
            this.Controls.Add(this.routeEdit1);
            this.Name = "RouteModal";
            this.Text = "RouteModal";
            this.ResumeLayout(false);

        }

        #endregion

        private RouteEdit routeEdit1;
    }
}