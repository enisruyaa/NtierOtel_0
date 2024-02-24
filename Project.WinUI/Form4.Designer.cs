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
            this.button2 = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRandevular = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblKullanici
            // 
            this.lblKullanici.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKullanici.Location = new System.Drawing.Point(418, 9);
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
            this.label1.Location = new System.Drawing.Point(335, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hoş Geldin :";
            // 
            // lstRandevular
            // 
            this.lstRandevular.FormattingEnabled = true;
            this.lstRandevular.Location = new System.Drawing.Point(161, 49);
            this.lstRandevular.Name = "lstRandevular";
            this.lstRandevular.Size = new System.Drawing.Size(396, 251);
            this.lstRandevular.TabIndex = 7;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(583, 342);
            this.Controls.Add(this.lstRandevular);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRandevular;
    }
}