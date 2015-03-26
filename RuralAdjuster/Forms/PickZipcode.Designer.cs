namespace RuralAdjuster.Forms
{
    partial class PickZipcode
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
            this.tbRouteNumber = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bCreateRoute = new System.Windows.Forms.Button();
            this.lError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbRouteNumber
            // 
            this.tbRouteNumber.Location = new System.Drawing.Point(12, 12);
            this.tbRouteNumber.Name = "tbRouteNumber";
            this.tbRouteNumber.Size = new System.Drawing.Size(100, 20);
            this.tbRouteNumber.TabIndex = 0;
            this.tbRouteNumber.TextChanged += new System.EventHandler(this.tbRouteNumber_TextChanged);
            // 
            // bCancel
            // 
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(12, 60);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 1;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bCreateRoute
            // 
            this.bCreateRoute.Location = new System.Drawing.Point(118, 9);
            this.bCreateRoute.Name = "bCreateRoute";
            this.bCreateRoute.Size = new System.Drawing.Size(89, 23);
            this.bCreateRoute.TabIndex = 2;
            this.bCreateRoute.Text = "Create Zone";
            this.bCreateRoute.UseVisualStyleBackColor = true;
            this.bCreateRoute.Click += new System.EventHandler(this.bCreateRoute_Click);
            // 
            // lError
            // 
            this.lError.Location = new System.Drawing.Point(12, 39);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(195, 18);
            this.lError.TabIndex = 3;
            // 
            // PickZipcode
            // 
            this.AcceptButton = this.bCreateRoute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(215, 93);
            this.ControlBox = false;
            this.Controls.Add(this.lError);
            this.Controls.Add(this.bCreateRoute);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.tbRouteNumber);
            this.Name = "PickZipcode";
            this.Text = "Enter Zipcode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbRouteNumber;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bCreateRoute;
        private System.Windows.Forms.Label lError;
    }
}