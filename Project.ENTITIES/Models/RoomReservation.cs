using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class RoomReservation : BaseEntity
    {
        public int RoomID { get; set; }

        public int ReservationID { get; set; }

        // Relation Properties

        public Room Room { get; set; }

        public Reservation Reservation { get; set; }
    }
}
