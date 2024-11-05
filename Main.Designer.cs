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
            this.lblInitialPrices_Main = new System.Windows.Forms.Label();
            this.tbInitialPrice_Main = new System.Windows.Forms.TextBox();
            this.btnCalculatePrice_Main = new System.Windows.Forms.Button();
            this.lblPD1_Main = new System.Windows.Forms.Label();
            this.lblPD2_Main = new System.Windows.Forms.Label();
            this.lblPD3_Main = new System.Windows.Forms.Label();
            this.lblPD4_Main = new System.Windows.Forms.Label();
            this.lblPD5_Main = new System.Windows.Forms.Label();
            this.lblPrice1_Main = new System.Windows.Forms.Label();
            this.lblPrice2_Main = new System.Windows.Forms.Label();
            this.lblPrice3_Main = new System.Windows.Forms.Label();
            this.lblPrice4_Main = new System.Windows.Forms.Label();
            this.lblPrice5_Main = new System.Windows.Forms.Label();
            this.pnlHeader_Main.SuspendLayout();
            this.pnlMain_Main.SuspendLayout();
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
            this.pnlMain_Main.Controls.Add(this.lblPrice5_Main);
            this.pnlMain_Main.Controls.Add(this.lblPrice4_Main);
            this.pnlMain_Main.Controls.Add(this.lblPrice3_Main);
            this.pnlMain_Main.Controls.Add(this.lblPrice2_Main);
            this.pnlMain_Main.Controls.Add(this.lblPrice1_Main);
            this.pnlMain_Main.Controls.Add(this.lblPD5_Main);
            this.pnlMain_Main.Controls.Add(this.lblPD4_Main);
            this.pnlMain_Main.Controls.Add(this.lblPD3_Main);
            this.pnlMain_Main.Controls.Add(this.lblPD2_Main);
            this.pnlMain_Main.Controls.Add(this.lblPD1_Main);
            this.pnlMain_Main.Controls.Add(this.btnCalculatePrice_Main);
            this.pnlMain_Main.Controls.Add(this.tbInitialPrice_Main);
            this.pnlMain_Main.Controls.Add(this.lblInitialPrices_Main);
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
            this.lblX_Main.Click += new System.EventHandler(this.lblX_Main_Click);
            // 
            // lblInitialPrices_Main
            // 
            this.lblInitialPrices_Main.AutoSize = true;
            this.lblInitialPrices_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInitialPrices_Main.Location = new System.Drawing.Point(62, 60);
            this.lblInitialPrices_Main.Name = "lblInitialPrices_Main";
            this.lblInitialPrices_Main.Size = new System.Drawing.Size(230, 29);
            this.lblInitialPrices_Main.TabIndex = 0;
            this.lblInitialPrices_Main.Text = "Enter the Initial Price";
            // 
            // tbInitialPrice_Main
            // 
            this.tbInitialPrice_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbInitialPrice_Main.Location = new System.Drawing.Point(317, 67);
            this.tbInitialPrice_Main.Name = "tbInitialPrice_Main";
            this.tbInitialPrice_Main.Size = new System.Drawing.Size(180, 22);
            this.tbInitialPrice_Main.TabIndex = 1;
            // 
            // btnCalculatePrice_Main
            // 
            this.btnCalculatePrice_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculatePrice_Main.Location = new System.Drawing.Point(214, 128);
            this.btnCalculatePrice_Main.Name = "btnCalculatePrice_Main";
            this.btnCalculatePrice_Main.Size = new System.Drawing.Size(430, 39);
            this.btnCalculatePrice_Main.TabIndex = 2;
            this.btnCalculatePrice_Main.Text = "Calculate Sales Day Prices";
            this.btnCalculatePrice_Main.UseVisualStyleBackColor = true;
            this.btnCalculatePrice_Main.Click += new System.EventHandler(this.btnCalculatePrice_Main_Click);
            // 
            // lblPD1_Main
            // 
            this.lblPD1_Main.AutoSize = true;
            this.lblPD1_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPD1_Main.Location = new System.Drawing.Point(62, 217);
            this.lblPD1_Main.Name = "lblPD1_Main";
            this.lblPD1_Main.Size = new System.Drawing.Size(204, 29);
            this.lblPD1_Main.TabIndex = 3;
            this.lblPD1_Main.Text = "Price on Day 1 is R";
            // 
            // lblPD2_Main
            // 
            this.lblPD2_Main.AutoSize = true;
            this.lblPD2_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPD2_Main.Location = new System.Drawing.Point(62, 281);
            this.lblPD2_Main.Name = "lblPD2_Main";
            this.lblPD2_Main.Size = new System.Drawing.Size(204, 29);
            this.lblPD2_Main.TabIndex = 4;
            this.lblPD2_Main.Text = "Price on Day 2 is R";
            // 
            // lblPD3_Main
            // 
            this.lblPD3_Main.AutoSize = true;
            this.lblPD3_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPD3_Main.Location = new System.Drawing.Point(62, 344);
            this.lblPD3_Main.Name = "lblPD3_Main";
            this.lblPD3_Main.Size = new System.Drawing.Size(204, 29);
            this.lblPD3_Main.TabIndex = 5;
            this.lblPD3_Main.Text = "Price on Day 3 is R";
            // 
            // lblPD4_Main
            // 
            this.lblPD4_Main.AutoSize = true;
            this.lblPD4_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPD4_Main.Location = new System.Drawing.Point(62, 406);
            this.lblPD4_Main.Name = "lblPD4_Main";
            this.lblPD4_Main.Size = new System.Drawing.Size(204, 29);
            this.lblPD4_Main.TabIndex = 6;
            this.lblPD4_Main.Text = "Price on Day 4 is R";
            // 
            // lblPD5_Main
            // 
            this.lblPD5_Main.AutoSize = true;
            this.lblPD5_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPD5_Main.Location = new System.Drawing.Point(62, 465);
            this.lblPD5_Main.Name = "lblPD5_Main";
            this.lblPD5_Main.Size = new System.Drawing.Size(204, 29);
            this.lblPD5_Main.TabIndex = 7;
            this.lblPD5_Main.Text = "Price on Day 5 is R";
            // 
            // lblPrice1_Main
            // 
            this.lblPrice1_Main.AutoSize = true;
            this.lblPrice1_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice1_Main.Location = new System.Drawing.Point(272, 217);
            this.lblPrice1_Main.Name = "lblPrice1_Main";
            this.lblPrice1_Main.Size = new System.Drawing.Size(25, 29);
            this.lblPrice1_Main.TabIndex = 8;
            this.lblPrice1_Main.Text = "0";
            // 
            // lblPrice2_Main
            // 
            this.lblPrice2_Main.AutoSize = true;
            this.lblPrice2_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice2_Main.Location = new System.Drawing.Point(272, 281);
            this.lblPrice2_Main.Name = "lblPrice2_Main";
            this.lblPrice2_Main.Size = new System.Drawing.Size(25, 29);
            this.lblPrice2_Main.TabIndex = 9;
            this.lblPrice2_Main.Text = "0";
            // 
            // lblPrice3_Main
            // 
            this.lblPrice3_Main.AutoSize = true;
            this.lblPrice3_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice3_Main.Location = new System.Drawing.Point(272, 344);
            this.lblPrice3_Main.Name = "lblPrice3_Main";
            this.lblPrice3_Main.Size = new System.Drawing.Size(25, 29);
            this.lblPrice3_Main.TabIndex = 10;
            this.lblPrice3_Main.Text = "0";
            // 
            // lblPrice4_Main
            // 
            this.lblPrice4_Main.AutoSize = true;
            this.lblPrice4_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice4_Main.Location = new System.Drawing.Point(272, 406);
            this.lblPrice4_Main.Name = "lblPrice4_Main";
            this.lblPrice4_Main.Size = new System.Drawing.Size(25, 29);
            this.lblPrice4_Main.TabIndex = 11;
            this.lblPrice4_Main.Text = "0";
            // 
            // lblPrice5_Main
            // 
            this.lblPrice5_Main.AutoSize = true;
            this.lblPrice5_Main.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice5_Main.Location = new System.Drawing.Point(272, 465);
            this.lblPrice5_Main.Name = "lblPrice5_Main";
            this.lblPrice5_Main.Size = new System.Drawing.Size(25, 29);
            this.lblPrice5_Main.TabIndex = 12;
            this.lblPrice5_Main.Text = "0";
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
            this.pnlMain_Main.ResumeLayout(false);
            this.pnlMain_Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo_Main)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader_Main;
        private System.Windows.Forms.PictureBox pbLogo_Main;
        private System.Windows.Forms.Panel pnlMain_Main;
        private System.Windows.Forms.Label lblNSS_Main;
        private System.Windows.Forms.Label lblX_Main;
        private System.Windows.Forms.Label lblInitialPrices_Main;
        private System.Windows.Forms.TextBox tbInitialPrice_Main;
        private System.Windows.Forms.Button btnCalculatePrice_Main;
        private System.Windows.Forms.Label lblPrice5_Main;
        private System.Windows.Forms.Label lblPrice4_Main;
        private System.Windows.Forms.Label lblPrice3_Main;
        private System.Windows.Forms.Label lblPrice2_Main;
        private System.Windows.Forms.Label lblPrice1_Main;
        private System.Windows.Forms.Label lblPD5_Main;
        private System.Windows.Forms.Label lblPD4_Main;
        private System.Windows.Forms.Label lblPD3_Main;
        private System.Windows.Forms.Label lblPD2_Main;
        private System.Windows.Forms.Label lblPD1_Main;
    }
}

