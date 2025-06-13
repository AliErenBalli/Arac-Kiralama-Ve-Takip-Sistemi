namespace AracKiralamaVeTakip
{
    partial class FormRaporlama
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnCokKiralanan = new System.Windows.Forms.Label();
            this.Aktif_Kiralamalar = new System.Windows.Forms.ListBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "En çok kiralanan araç bilgisi :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEnCokKiralanan
            // 
            this.lblEnCokKiralanan.AutoSize = true;
            this.lblEnCokKiralanan.Location = new System.Drawing.Point(291, 61);
            this.lblEnCokKiralanan.Name = "lblEnCokKiralanan";
            this.lblEnCokKiralanan.Size = new System.Drawing.Size(0, 16);
            this.lblEnCokKiralanan.TabIndex = 1;
            // 
            // Aktif_Kiralamalar
            // 
            this.Aktif_Kiralamalar.FormattingEnabled = true;
            this.Aktif_Kiralamalar.ItemHeight = 16;
            this.Aktif_Kiralamalar.Location = new System.Drawing.Point(2, 154);
            this.Aktif_Kiralamalar.Name = "Aktif_Kiralamalar";
            this.Aktif_Kiralamalar.Size = new System.Drawing.Size(1012, 596);
            this.Aktif_Kiralamalar.TabIndex = 2;
            this.Aktif_Kiralamalar.SelectedIndexChanged += new System.EventHandler(this.Aktif_Kiralamalar_SelectedIndexChanged);
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(774, 81);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(176, 45);
            this.btnGoster.TabIndex = 3;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // FormRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 763);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.Aktif_Kiralamalar);
            this.Controls.Add(this.lblEnCokKiralanan);
            this.Controls.Add(this.label1);
            this.Name = "FormRaporlama";
            this.Text = "FormRaporlama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEnCokKiralanan;
        private System.Windows.Forms.ListBox Aktif_Kiralamalar;
        private System.Windows.Forms.Button btnGoster;
    }
}