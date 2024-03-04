using Project.BLL.DesignPatterns.GenericRepository.ConsRep;
using Project.ENTITIES.Enums;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project.WinUI
{
    public partial class Form3 : Form
    {
        RoomRepository _rR;
        Reservation r;
        public Form3()
        {
            InitializeComponent();
            _rR = new RoomRepository();
            r = new Reservation();
        }

        TimeSpan gunSayisi;

        private void Form3_Load(object sender, System.EventArgs e)
        {
            cmbOdaTipi.DataSource = _rR.GetActives();
            cmbOdaTipi.DisplayMember = "RoomType";
            cmbOdaTipi.SelectedIndex = -1;

            cmbKonaklamaTipi.DataSource = Enum.GetValues(typeof(RoomStatus));
            cmbKonaklamaTipi.SelectedIndex = -1;
        }

        public int GunHesapla()
        {
            
            r.GirisTarihi = dtGirisTarihi.Value.Date;
            r.CikisTarihi = dtGirisTarihi.Value.Date;
            gunSayisi = r.CikisTarihi - r.GirisTarihi;
            return gunSayisi.Days;
        }

        int _hesap = 0;

        public void Hesapla()
        {
           
           
        }

        private void btnRandevuYap_Click(object sender, System.EventArgs e)
        {
            if (cmbKonaklamaTipi.SelectedIndex > -1 && cmbOdaTipi.SelectedIndex > -1  )
            {
                r.GirisTarihi = dtGirisTarihi.Value.Date;
                r.CikisTarihi = dtGirisTarihi.Value.Date;
                r.KisiSayisi = Convert.ToInt32(nmrKisiSayisi.Value);
                lstRandevular.DataSource = r;
            }
            else MessageBox.Show("Lütfen Gerekli Olan Kısımları Seçiniz");
        }

        private void cmbOdaTipi_Click(object sender, EventArgs e)
        {
            
        }
    }
}
