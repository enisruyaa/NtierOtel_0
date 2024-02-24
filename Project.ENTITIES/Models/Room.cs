using Project.ENTITIES.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public abstract class Room : BaseEntity
    {
        public string RoomNo { get; set; }

        public decimal Price { get; set; } // Databaseye geçreken bu decimal'ın money olarak değiştirilmesi gerekmektedir.

        public int UserNumber { get; set; }

        public int? UserID { get; set; }

        public RoomStatus RoomStatus { get; set; }

        // Relatioanl properties

        public virtual User User { get; set; }
    }
}
