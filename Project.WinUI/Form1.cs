using Project.DAL.ContextClass;
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
        MyContext _my;

        public Form1()
        {
            InitializeComponent();
            _my = new MyContext();
        }

		private void btnEkle_Click(object sender, EventArgs e)
		{
            User up = new User();
            up.UserProfile.FirstName = txtIsim.Text;
            up.UserProfile.LastName = txtSoyIsim.Text;
            up.UserProfile.Age = Convert.ToInt32(txtYas.Text);
            up.UserProfile.Email = txtMail.Text;
            up.UserName = txtKullaniciAdi.Text;
            up.Password = txtSifre.Text;

            if (txtIsim.Text != null && txtKullaniciAdi.Text != null && txtSoyIsim.Text != null && txtMail.Text != null && txtYas.Text != null &&)
            {
                _my.Users.Add(up);
                _my.SaveChanges();
                MessageBox.Show($"Kayıt işleminiz gerçekleştirildi.");
            }
            else
            {
                MessageBox.Show("Lütfen form'da boş kutu bırakmayınız.");
            }
		}
	}
}
