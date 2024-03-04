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

        public int? UserID { get; set; }

        // Relational Properties

        public virtual List<RoomReservation> RoomReservations { get; set; }

        public virtual User User { get; set; }

        public void KonaklamaHesabi()
        {
            switch (SecilenKonaklama)
            {
                case RoomStatus.HerSeyDahil:
                    Fiyat += 500;
                    break;
                case RoomStatus.OdaKahvaltı:
                    Fiyat += 250;
                    break;
            }
        }
    }
}
