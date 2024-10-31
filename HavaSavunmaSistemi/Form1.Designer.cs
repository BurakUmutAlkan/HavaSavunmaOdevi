namespace HavaSavunmaSistemi
{
    partial class MainForm
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
            this.btnCikis = new System.Windows.Forms.Button();
            this.lblMermiHizi = new System.Windows.Forms.Label();
            this.lblYukseklik = new System.Windows.Forms.Label();
            this.lblMesafe = new System.Windows.Forms.Label();
            this.txtMermiHizi = new System.Windows.Forms.TextBox();
            this.txtYukseklik = new System.Windows.Forms.TextBox();
            this.txtMesafe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.Location = new System.Drawing.Point(632, 494);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(92, 34);
            this.btnCikis.TabIndex = 0;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            // 
            // lblMermiHizi
            // 
            this.lblMermiHizi.AutoSize = true;
            this.lblMermiHizi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMermiHizi.Location = new System.Drawing.Point(12, 9);
            this.lblMermiHizi.Name = "lblMermiHizi";
            this.lblMermiHizi.Size = new System.Drawing.Size(83, 17);
            this.lblMermiHizi.TabIndex = 1;
            this.lblMermiHizi.Text = "Mermi Hızı";
            // 
            // lblYukseklik
            // 
            this.lblYukseklik.AutoSize = true;
            this.lblYukseklik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYukseklik.Location = new System.Drawing.Point(12, 72);
            this.lblYukseklik.Name = "lblYukseklik";
            this.lblYukseklik.Size = new System.Drawing.Size(76, 17);
            this.lblYukseklik.TabIndex = 2;
            this.lblYukseklik.Text = "Yükseklik";
            // 
            // lblMesafe
            // 
            this.lblMesafe.AutoSize = true;
            this.lblMesafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesafe.Location = new System.Drawing.Point(12, 138);
            this.lblMesafe.Name = "lblMesafe";
            this.lblMesafe.Size = new System.Drawing.Size(60, 17);
            this.lblMesafe.TabIndex = 3;
            this.lblMesafe.Text = "Mesafe";
            // 
            // txtMermiHizi
            // 
            this.txtMermiHizi.Location = new System.Drawing.Point(15, 29);
            this.txtMermiHizi.Name = "txtMermiHizi";
            this.txtMermiHizi.Size = new System.Drawing.Size(191, 20);
            this.txtMermiHizi.TabIndex = 4;
            // 
            // txtYukseklik
            // 
            this.txtYukseklik.Location = new System.Drawing.Point(15, 92);
            this.txtYukseklik.Name = "txtYukseklik";
            this.txtYukseklik.Size = new System.Drawing.Size(191, 20);
            this.txtYukseklik.TabIndex = 5;
            // 
            // txtMesafe
            // 
            this.txtMesafe.Location = new System.Drawing.Point(15, 158);
            this.txtMesafe.Name = "txtMesafe";
            this.txtMesafe.Size = new System.Drawing.Size(191, 20);
            this.txtMesafe.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 540);
            this.Controls.Add(this.txtMesafe);
            this.Controls.Add(this.txtYukseklik);
            this.Controls.Add(this.txtMermiHizi);
            this.Controls.Add(this.lblMesafe);
            this.Controls.Add(this.lblYukseklik);
            this.Controls.Add(this.lblMermiHizi);
            this.Controls.Add(this.btnCikis);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hava Savunma Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblMermiHizi;
        private System.Windows.Forms.Label lblYukseklik;
        private System.Windows.Forms.Label lblMesafe;
        private System.Windows.Forms.TextBox txtMermiHizi;
        private System.Windows.Forms.TextBox txtYukseklik;
        private System.Windows.Forms.TextBox txtMesafe;
    }
}

