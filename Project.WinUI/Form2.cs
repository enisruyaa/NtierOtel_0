using Project.BLL.DesignPatterns.GenericRepository.ConsRep;
using Project.BLL.DesignPatterns.SingletonPattern;
using Project.ENTITIES.Models;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Project.WinUI
{
	public partial class Form2 : Form
	{
		UserRepository _uR;
		public Form2(UserRepository ur)
		{
			InitializeComponent();
			_uR = ur;
		}

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == "Admin" && txtSifre.Text == "123")
            {
                Form4 frm4 = new Form4();
                frm4.ShowDialog();
            }
            else if (_uR.Any(x => x.UserName == txtKullaniciAdi.Text && x.Password == txtSifre.Text))
            {
                MessageBox.Show($"Hoşgeldin -> {txtKullaniciAdi.Text} ");
                Form3 frm3 = new Form3();
                frm3.ShowDialog();
            }
            else MessageBox.Show("Böyle bir üye bulunamadı");
        }
    }
}
