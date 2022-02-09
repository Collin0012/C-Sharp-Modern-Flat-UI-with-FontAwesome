namespace Modern_Flat_UI.Forms
{
    partial class Marketing
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
            this.labelMarketing = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMarketing
            // 
            this.labelMarketing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelMarketing.AutoSize = true;
            this.labelMarketing.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarketing.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMarketing.Location = new System.Drawing.Point(441, 277);
            this.labelMarketing.Name = "labelMarketing";
            this.labelMarketing.Size = new System.Drawing.Size(133, 31);
            this.labelMarketing.TabIndex = 0;
            this.labelMarketing.Text = "Marketing";
            this.labelMarketing.Click += new System.EventHandler(this.labelOrders_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(78)))));
            this.panelDesktop.Controls.Add(this.labelMarketing);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(984, 593);
            this.panelDesktop.TabIndex = 6;
            // 
            // Marketing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 593);
            this.Controls.Add(this.panelDesktop);
            this.Name = "Marketing";
            this.Text = "Marketing";
            this.Load += new System.EventHandler(this.FormMarketing_Load);
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMarketing;
        private System.Windows.Forms.Panel panelDesktop;
    }
}