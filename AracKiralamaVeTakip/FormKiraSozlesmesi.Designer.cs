namespace AracKiralamaVeTakip
{
    partial class FormKiraSozlesmesi
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
            this.cmbArac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnKirala = new System.Windows.Forms.Button();
            this.Kiralananlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmbArac
            // 
            this.cmbArac.FormattingEnabled = true;
            this.cmbArac.Location = new System.Drawing.Point(145, 12);
            this.cmbArac.Name = "cmbArac";
            this.cmbArac.Size = new System.Drawing.Size(367, 24);
            this.cmbArac.TabIndex = 0;
            this.cmbArac.SelectedIndexChanged += new System.EventHandler(this.cmbArac_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Araç Seçimi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Müşteri Seçimi :";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(145, 54);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(367, 24);
            this.cmbMusteri.TabIndex = 3;
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(129, 181);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(242, 22);
            this.dtBaslangic.TabIndex = 4;
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(129, 220);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(242, 22);
            this.dtBitis.TabIndex = 5;
            this.dtBitis.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kira Başlangıcı :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Teslim Tarihi :";
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(452, 194);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 23);
            this.btnKirala.TabIndex = 8;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // Kiralananlar
            // 
            this.Kiralananlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Kiralananlar.FormattingEnabled = true;
            this.Kiralananlar.ItemHeight = 16;
            this.Kiralananlar.Location = new System.Drawing.Point(3, 269);
            this.Kiralananlar.Name = "Kiralananlar";
            this.Kiralananlar.Size = new System.Drawing.Size(1072, 164);
            this.Kiralananlar.TabIndex = 9;
            // 
            // FormKiraSozlesmesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 450);
            this.Controls.Add(this.Kiralananlar);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbArac);
            this.Name = "FormKiraSozlesmesi";
            this.Text = "FormKiraSozlesmesi";
            this.Load += new System.EventHandler(this.FormKiraSozlesmesi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbArac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnKirala;
        private System.Windows.Forms.ListBox Kiralananlar;
    }
}