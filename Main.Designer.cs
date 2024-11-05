namespace Nkabi_Sales_Shop
{
    partial class Main
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
            this.pnlHeader_Main = new System.Windows.Forms.Panel();
            this.pnlMain_Main = new System.Windows.Forms.Panel();
            this.pbLogo_Main = new System.Windows.Forms.PictureBox();
            this.lblNSS_Main = new System.Windows.Forms.Label();
            this.lblX_Main = new System.Windows.Forms.Label();
            this.pnlHeader_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Main)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader_Main
            // 
            this.pnlHeader_Main.Controls.Add(this.lblX_Main);
            this.pnlHeader_Main.Controls.Add(this.lblNSS_Main);
            this.pnlHeader_Main.Controls.Add(this.pbLogo_Main);
            this.pnlHeader_Main.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader_Main.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader_Main.Name = "pnlHeader_Main";
            this.pnlHeader_Main.Size = new System.Drawing.Size(900, 100);
            this.pnlHeader_Main.TabIndex = 0;
            // 
            // pnlMain_Main
            // 
            this.pnlMain_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain_Main.Location = new System.Drawing.Point(0, 100);
            this.pnlMain_Main.Name = "pnlMain_Main";
            this.pnlMain_Main.Size = new System.Drawing.Size(900, 550);
            this.pnlMain_Main.TabIndex = 1;
            // 
            // pbLogo_Main
            // 
            this.pbLogo_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogo_Main.Image = global::Nkabi_Sales_Shop.Properties.Resources.logo_main;
            this.pbLogo_Main.Location = new System.Drawing.Point(0, 0);
            this.pbLogo_Main.Name = "pbLogo_Main";
            this.pbLogo_Main.Size = new System.Drawing.Size(98, 100);
            this.pbLogo_Main.TabIndex = 0;
            this.pbLogo_Main.TabStop = false;
            // 
            // lblNSS_Main
            // 
            this.lblNSS_Main.AutoSize = true;
            this.lblNSS_Main.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSS_Main.Location = new System.Drawing.Point(236, 26);
            this.lblNSS_Main.Name = "lblNSS_Main";
            this.lblNSS_Main.Size = new System.Drawing.Size(408, 50);
            this.lblNSS_Main.TabIndex = 1;
            this.lblNSS_Main.Text = "Nkabi Sales Shop";
            // 
            // lblX_Main
            // 
            this.lblX_Main.AutoSize = true;
            this.lblX_Main.Font = new System.Drawing.Font("Cooper Black", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX_Main.Location = new System.Drawing.Point(831, 9);
            this.lblX_Main.Name = "lblX_Main";
            this.lblX_Main.Size = new System.Drawing.Size(57, 50);
            this.lblX_Main.TabIndex = 2;
            this.lblX_Main.Text = "X";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.pnlMain_Main);
            this.Controls.Add(this.pnlHeader_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.pnlHeader_Main.ResumeLayout(false);
            this.pnlHeader_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader_Main;
        private System.Windows.Forms.PictureBox pbLogo_Main;
        private System.Windows.Forms.Panel pnlMain_Main;
        private System.Windows.Forms.Label lblNSS_Main;
        private System.Windows.Forms.Label lblX_Main;
    }
}

