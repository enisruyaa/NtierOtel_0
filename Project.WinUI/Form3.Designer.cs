namespace Project.WinUI
{
    partial class Form3
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.dtGirisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dtCikisTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbOdaTipi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrKisiSayisi = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRandevuYap = new System.Windows.Forms.Button();
            this.lstRandevular = new System.Windows.Forms.ListBox();
            this.cmbKonaklamaTipi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisiSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(333, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoş Geldin :";
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKullanici.Location = new System.Drawing.Point(416, 9);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(139, 24);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtGirisTarihi
            // 
            this.dtGirisTarihi.Location = new System.Drawing.Point(12, 52);
            this.dtGirisTarihi.Name = "dtGirisTarihi";
            this.dtGirisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtGirisTarihi.TabIndex = 1;
            // 
            // dtCikisTarihi
            // 
            this.dtCikisTarihi.Location = new System.Drawing.Point(12, 114);
            this.dtCikisTarihi.Name = "dtCikisTarihi";
            this.dtCikisTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtCikisTarihi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Giriş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(65, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // cmbOdaTipi
            // 
            this.cmbOdaTipi.FormattingEnabled = true;
            this.cmbOdaTipi.Location = new System.Drawing.Point(8, 200);
            this.cmbOdaTipi.Name = "cmbOdaTipi";
            this.cmbOdaTipi.Size = new System.Drawing.Size(137, 21);
            this.cmbOdaTipi.TabIndex = 3;
            this.cmbOdaTipi.Click += new System.EventHandler(this.cmbOdaTipi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Oda Tipi Seçiniz";
            // 
            // nmrKisiSayisi
            // 
            this.nmrKisiSayisi.Location = new System.Drawing.Point(175, 200);
            this.nmrKisiSayisi.Name = "nmrKisiSayisi";
            this.nmrKisiSayisi.Size = new System.Drawing.Size(45, 20);
            this.nmrKisiSayisi.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(161, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kişi Sayısı";
            // 
            // btnRandevuYap
            // 
            this.btnRandevuYap.Location = new System.Drawing.Point(69, 304);
            this.btnRandevuYap.Name = "btnRandevuYap";
            this.btnRandevuYap.Size = new System.Drawing.Size(109, 26);
            this.btnRandevuYap.TabIndex = 5;
            this.btnRandevuYap.Text = "Rezervasyon Yap";
            this.btnRandevuYap.UseVisualStyleBackColor = true;
            this.btnRandevuYap.Click += new System.EventHandler(this.btnRandevuYap_Click);
            // 
            // lstRandevular
            // 
            this.lstRandevular.FormattingEnabled = true;
            this.lstRandevular.Location = new System.Drawing.Point(267, 52);
            this.lstRandevular.Name = "lstRandevular";
            this.lstRandevular.Size = new System.Drawing.Size(288, 251);
            this.lstRandevular.TabIndex = 6;
            // 
            // cmbKonaklamaTipi
            // 
            this.cmbKonaklamaTipi.FormattingEnabled = true;
            this.cmbKonaklamaTipi.Location = new System.Drawing.Point(8, 267);
            this.cmbKonaklamaTipi.Name = "cmbKonaklamaTipi";
            this.cmbKonaklamaTipi.Size = new System.Drawing.Size(137, 21);
            this.cmbKonaklamaTipi.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(8, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Konaklama Tipi Seçiniz";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 342);
            this.Controls.Add(this.lstRandevular);
            this.Controls.Add(this.btnRandevuYap);
            this.Controls.Add(this.nmrKisiSayisi);
            this.Controls.Add(this.cmbKonaklamaTipi);
            this.Controls.Add(this.cmbOdaTipi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCikisTarihi);
            this.Controls.Add(this.dtGirisTarihi);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrKisiSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.DateTimePicker dtGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtCikisTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOdaTipi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrKisiSayisi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRandevuYap;
        private System.Windows.Forms.ListBox lstRandevular;
        private System.Windows.Forms.ComboBox cmbKonaklamaTipi;
        private System.Windows.Forms.Label label6;
    }
}