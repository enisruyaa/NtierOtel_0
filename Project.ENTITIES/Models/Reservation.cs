using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Reservation : BaseEntity
    {
        public DateTime GirisTarihi { get; set; }

        public DateTime CikisTarihi { get; set; }

        public int KisiSayisi { get; set; }

        public Room OdaTipi { get; set; }

        public RoomStatus RoomStatus { get; set; }

        public decimal Fiyat { get; set; }

        

    }
}
