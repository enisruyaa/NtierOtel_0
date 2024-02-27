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

        public Form3()
        {
            InitializeComponent();
        }

        int hesap = 0;
        TimeSpan gunSayisi;

        private void Form3_Load(object sender, System.EventArgs e)
        {
            List<Room> rooms = new List<Room>
            {
                new Room{ RoomNo = "1" , RoomType = "Suit" , Price = 2000  },
                new Room{ RoomNo = "2" , RoomType = "Kral" , Price = 6000  },
                new Room{ RoomNo = "2" , RoomType = "Elit" , Price = 10000  },
            };
            cmbOdaTipi.DataSource = rooms;
            cmbOdaTipi.DisplayMember = "RoomType";
            cmbOdaTipi.SelectedIndex = -1;

            cmbKonaklamaTipi.DataSource = Enum.GetValues(typeof(RoomStatus));
            cmbKonaklamaTipi.SelectedIndex = -1;

            foreach (Room item in rooms)
            {
                item.Price += hesap;
            }
        }

        public void GunHesapla()
        {
            Reservation r = new Reservation();
            r.GirisTarihi = dtGirisTarihi.Value.Date;
            r.CikisTarihi = dtGirisTarihi.Value.Date;
            gunSayisi = r.CikisTarihi - r.GirisTarihi;
        }
        public void TutarHesapla()
        {
            
        }

        private void btnRandevuYap_Click(object sender, System.EventArgs e)
        {
            if (cmbKonaklamaTipi.SelectedIndex > -1 && cmbOdaTipi.SelectedIndex > -1)
            {
                Reservation r = new Reservation
                {
                };
            }
        }

        Room _secilen;
        private void cmbOdaTipi_Click(object sender, EventArgs e)
        {
            if (cmbOdaTipi.SelectedIndex > -1)
            {
                _secilen = cmbOdaTipi.SelectedItem as Room;
            }
        }
    }
}
