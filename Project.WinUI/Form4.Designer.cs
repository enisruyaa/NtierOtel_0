namespace Project.WinUI
{
    partial class Form4
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
            this.btnRandevuSil = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRandevular = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOdaNo = new System.Windows.Forms.TextBox();
            this.txtOdaFiyati = new System.Windows.Forms.TextBox();
            this.txtOdaTipi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstOdalar = new System.Windows.Forms.ListBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRandevuSil
            // 
            this.btnRandevuSil.Location = new System.Drawing.Point(564, 171);
            this.btnRandevuSil.Name = "btnRandevuSil";
            this.btnRandevuSil.Size = new System.Drawing.Size(75, 23);
            this.btnRandevuSil.TabIndex = 0;
            this.btnRandevuSil.Text = "Sil";
            this.btnRandevuSil.UseVisualStyleBackColor = true;
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKullanici.Location = new System.Drawing.Point(452, 9);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(139, 24);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Admin";
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(369, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoş Geldin :";
            // 
            // lstRandevular
            // 
            this.lstRandevular.FormattingEnabled = true;
            this.lstRandevular.Location = new System.Drawing.Point(645, 77);
            this.lstRandevular.Name = "lstRandevular";
            this.lstRandevular.Size = new System.Drawing.Size(396, 251);
            this.lstRandevular.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(494, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 304);
            this.label2.TabIndex = 8;
            // 
            // txtOdaNo
            // 
            this.txtOdaNo.Location = new System.Drawing.Point(87, 90);
            this.txtOdaNo.Name = "txtOdaNo";
            this.txtOdaNo.Size = new System.Drawing.Size(113, 20);
            this.txtOdaNo.TabIndex = 9;
            // 
            // txtOdaFiyati
            // 
            this.txtOdaFiyati.Location = new System.Drawing.Point(87, 116);
            this.txtOdaFiyati.Name = "txtOdaFiyati";
            this.txtOdaFiyati.Size = new System.Drawing.Size(113, 20);
            this.txtOdaFiyati.TabIndex = 9;
            // 
            // txtOdaTipi
            // 
            this.txtOdaTipi.Location = new System.Drawing.Point(87, 142);
            this.txtOdaTipi.Name = "txtOdaTipi";
            this.txtOdaTipi.Size = new System.Drawing.Size(113, 20);
            this.txtOdaTipi.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Oda Numarası :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Oda Fiyatı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Oda Tipi :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(87, 195);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstOdalar
            // 
            this.lstOdalar.FormattingEnabled = true;
            this.lstOdalar.Location = new System.Drawing.Point(227, 90);
            this.lstOdalar.Name = "lstOdalar";
            this.lstOdalar.Size = new System.Drawing.Size(234, 238);
            this.lstOdalar.TabIndex = 12;
            this.lstOdalar.Click += new System.EventHandler(this.lstOdalar_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(87, 224);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(87, 253);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1053, 351);
            this.Controls.Add(this.lstOdalar);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOdaTipi);
            this.Controls.Add(this.txtOdaFiyati);
            this.Controls.Add(this.txtOdaNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRandevular);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRandevuSil);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRandevuSil;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRandevular;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOdaNo;
        private System.Windows.Forms.TextBox txtOdaFiyati;
        private System.Windows.Forms.TextBox txtOdaTipi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstOdalar;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}