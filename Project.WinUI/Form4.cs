using Project.BLL.DesignPatterns.GenericRepository.ConsRep;
using Project.ENTITIES.Models;
using System;
using System.Windows.Forms;

namespace Project.WinUI
{
	public partial class Form4 : Form
	{
		RoomRepository _rR;
		public Form4()
		{
			InitializeComponent();
			_rR = new RoomRepository();
		}

		private void btnEkle_Click(object sender, System.EventArgs e)
		{
			Room r = new Room()
			{
				RoomNo = txtOdaNo.Text,
				RoomType = txtOdaTipi.Text,
				Price = Convert.ToDecimal(txtOdaFiyati.Text)
			};
			_rR.Add(r);
			OdalariListele();
            YazilariTemizle();
        }

		private void Form4_Load(object sender, EventArgs e)
		{
			OdalariListele();
		}

		private void OdalariListele()
		{
			lstOdalar.DataSource = _rR.GetAll();
			lstOdalar.DisplayMember = "RoomType";
			lstOdalar.SelectedIndex = -1;
		}

		Room _secilen;

		private void lstOdalar_Click(object sender, EventArgs e)
		{
			if (lstOdalar.SelectedIndex>-1)
			{
				_secilen = lstOdalar.SelectedItem as Room;
				txtOdaTipi.Text = _secilen.RoomType;
				txtOdaNo.Text = _secilen.RoomNo.ToString();
				txtOdaFiyati.Text = _secilen.Price.ToString();
			}
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
			if (_secilen != null)
			{
				_rR.Destroy(_secilen);
				_secilen = null;
				OdalariListele();
                YazilariTemizle();
            }
			else MessageBox.Show("Lütfen Silmek İstediğin Odayı Seçiniz");
		}

		private void btnGuncelle_Click(object sender, EventArgs e)
		{
			if (_secilen != null)
			{
				_secilen.Price = Convert.ToDecimal(txtOdaFiyati.Text);
				_secilen.RoomType = txtOdaTipi.Text;
				_secilen.RoomNo = txtOdaNo.Text;
				_rR.Update(_secilen);
				_secilen = null;
                OdalariListele();
				YazilariTemizle();
            }
			else MessageBox.Show("Lütfen Güncellemek İstediğiniz Odayı Seçiniz");
		}

		public void YazilariTemizle()
		{
			txtOdaFiyati.Text = txtOdaNo.Text = txtOdaTipi.Text = string.Empty;
		}
	}
}
