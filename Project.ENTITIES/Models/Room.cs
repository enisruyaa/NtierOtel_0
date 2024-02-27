using Project.ENTITIES.Enums;
using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
	public class Room : BaseEntity
	{
		public string RoomNo { get; set; }

		public decimal Price { get; set; } // Databaseye geçreken bu decimal'ın money olarak değiştirilmesi gerekmektedir.

        public string RoomType { get; set; }

        public int UserNumber { get; set; }

		public int? UserID { get; set; }

		public RoomStatus RoomStatus { get; set; }

		// Relatioanl properties

		public virtual User User { get; set; }

		public virtual List<Reservation> Reservations { get; set; }
	}
}
