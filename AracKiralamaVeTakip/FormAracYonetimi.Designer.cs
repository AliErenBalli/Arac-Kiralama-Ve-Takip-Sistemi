namespace AracKiralamaVeTakip
{
    partial class FormAracYonetimi
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
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.Araç_listesi = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAracTuru = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGunlukUcret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(102, 88);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(100, 22);
            this.txtPlaka.TabIndex = 24;
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(102, 63);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 22);
            this.txtYil.TabIndex = 23;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(102, 37);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 22;
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(102, 6);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 22);
            this.txtMarka.TabIndex = 21;
            // 
            // Araç_listesi
            // 
            this.Araç_listesi.FormattingEnabled = true;
            this.Araç_listesi.ItemHeight = 16;
            this.Araç_listesi.Location = new System.Drawing.Point(7, 225);
            this.Araç_listesi.Name = "Araç_listesi";
            this.Araç_listesi.Size = new System.Drawing.Size(765, 212);
            this.Araç_listesi.TabIndex = 20;
            this.Araç_listesi.SelectedIndexChanged += new System.EventHandler(this.Araç_listesi_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(273, 163);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Araç türü seçimi :";
            // 
            // cmbAracTuru
            // 
            this.cmbAracTuru.FormattingEnabled = true;
            this.cmbAracTuru.Location = new System.Drawing.Point(133, 163);
            this.cmbAracTuru.Name = "cmbAracTuru";
            this.cmbAracTuru.Size = new System.Drawing.Size(121, 24);
            this.cmbAracTuru.TabIndex = 17;
            this.cmbAracTuru.SelectedIndexChanged += new System.EventHandler(this.cmbAracTuru_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Plaka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Yıl :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Model :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = " Marka :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Günlük Ücret :";
            // 
            // txtGunlukUcret
            // 
            this.txtGunlukUcret.Location = new System.Drawing.Point(101, 116);
            this.txtGunlukUcret.Name = "txtGunlukUcret";
            this.txtGunlukUcret.Size = new System.Drawing.Size(100, 22);
            this.txtGunlukUcret.TabIndex = 26;
            // 
            // FormAracYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtGunlukUcret);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Controls.Add(this.Araç_listesi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAracTuru);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAracYonetimi";
            this.Text = "FormAracYonetimi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.ListBox Araç_listesi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAracTuru;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGunlukUcret;
    }
}