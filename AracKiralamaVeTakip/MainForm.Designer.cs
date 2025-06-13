namespace AracKiralamaVeTakip
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
            this.btnAracYonetimi = new System.Windows.Forms.Button();
            this.btnMusteriKaydi = new System.Windows.Forms.Button();
            this.btnKiraSozlesmesi = new System.Windows.Forms.Button();
            this.btnRaporlama = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAracYonetimi
            // 
            this.btnAracYonetimi.Location = new System.Drawing.Point(217, 179);
            this.btnAracYonetimi.Name = "btnAracYonetimi";
            this.btnAracYonetimi.Size = new System.Drawing.Size(120, 23);
            this.btnAracYonetimi.TabIndex = 0;
            this.btnAracYonetimi.Text = "Araç Yönetimi";
            this.btnAracYonetimi.UseVisualStyleBackColor = true;
            this.btnAracYonetimi.Click += new System.EventHandler(this.btnAracYonetimi_Click);
            // 
            // btnMusteriKaydi
            // 
            this.btnMusteriKaydi.Location = new System.Drawing.Point(411, 179);
            this.btnMusteriKaydi.Name = "btnMusteriKaydi";
            this.btnMusteriKaydi.Size = new System.Drawing.Size(141, 23);
            this.btnMusteriKaydi.TabIndex = 1;
            this.btnMusteriKaydi.Text = "Müşteri Kaydı";
            this.btnMusteriKaydi.UseVisualStyleBackColor = true;
            this.btnMusteriKaydi.Click += new System.EventHandler(this.btnMusteriKaydi_Click);
            // 
            // btnKiraSozlesmesi
            // 
            this.btnKiraSozlesmesi.Location = new System.Drawing.Point(217, 251);
            this.btnKiraSozlesmesi.Name = "btnKiraSozlesmesi";
            this.btnKiraSozlesmesi.Size = new System.Drawing.Size(120, 23);
            this.btnKiraSozlesmesi.TabIndex = 2;
            this.btnKiraSozlesmesi.Text = "Kira Sözleşmesi";
            this.btnKiraSozlesmesi.UseVisualStyleBackColor = true;
            this.btnKiraSozlesmesi.Click += new System.EventHandler(this.btnKiraSozlesmesi_Click);
            // 
            // btnRaporlama
            // 
            this.btnRaporlama.Location = new System.Drawing.Point(420, 251);
            this.btnRaporlama.Name = "btnRaporlama";
            this.btnRaporlama.Size = new System.Drawing.Size(132, 23);
            this.btnRaporlama.TabIndex = 3;
            this.btnRaporlama.Text = "Raporlama";
            this.btnRaporlama.UseVisualStyleBackColor = true;
            this.btnRaporlama.Click += new System.EventHandler(this.btnRaporlama_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRaporlama);
            this.Controls.Add(this.btnKiraSozlesmesi);
            this.Controls.Add(this.btnMusteriKaydi);
            this.Controls.Add(this.btnAracYonetimi);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAracYonetimi;
        private System.Windows.Forms.Button btnMusteriKaydi;
        private System.Windows.Forms.Button btnKiraSozlesmesi;
        private System.Windows.Forms.Button btnRaporlama;
    }
}