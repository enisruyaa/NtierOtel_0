using Project.BLL.DesignPatterns.GenericRepository.ConsRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form1 : Form
    {
        UserRepository _uR;
        UserProfileRepository _upR;

        public Form1()
        {
            InitializeComponent();
            _uR = new UserRepository();
            _upR = new UserProfileRepository();
        }

		private void btnEkle_Click(object sender, EventArgs e)
		{
            if (txtIsim.Text != null && txtKullaniciAdi.Text != null && txtMail.Text != null && txtSifre.Text !=null && txtSoyIsim.Text !=null && txtYas.Text != null)
            {
                User u = new User()
                {
                    UserName = txtKullaniciAdi.Text,
                    Password = txtSifre.Text
                };
                _uR.Add(u);
                UserProfile up = new UserProfile()
                {
                    ID = u.ID,
                    FirstName = txtIsim.Text,
                    LastName = txtSoyIsim.Text,
                    Age = Convert.ToInt32(txtSifre.Text),
                    Email = txtMail.Text
                };
                _upR.Add(up);
                DialogResult dr = MessageBox.Show("Giriş Yapmak İster Misiniz", "Kayıt Başarıyla Oluşturulmuştur ",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Form2 frm2 = new Form2();
                    frm2.ShowDialog();
                }
                else
                {
                        
                }
            }
            else MessageBox.Show("Lütfen Boş Kısım Bırakmayınız");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }
    }
}
