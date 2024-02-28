using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation : BaseEntity
    {
        public DateTime GirisTarihi { get; set; }

        public DateTime CikisTarihi { get; set; }

        public int KisiSayisi { get; set; }
        public RoomStatus SecilenKonaklama { get; set; }

        public decimal Fiyat { get; set; }

        public Room SecilenOda { get; set; }

        public int? UserID { get; set; }

        // Relational Properties

        public virtual List<Room> Rooms { get; set; }

        public virtual User User { get; set; }


        public int TutarHesapla()
        {
            Fiyat = SecilenOda.Price;
            switch (SecilenKonaklama)
            {
                case RoomStatus.HerSeyDahil:
                    Fiyat += 500;
                    break;
                case RoomStatus.YarımPansiyon:
                    Fiyat += 100;
                    break;
            }
            return Convert.ToInt32(Fiyat);
        }
    }
}
