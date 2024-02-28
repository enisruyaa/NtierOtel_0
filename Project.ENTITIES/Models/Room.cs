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

		public RoomStatus RoomStatus { get; set; }

		public int? ReservationID { get; set; }

		// Relatioanl properties

		public virtual Reservation Reservation { get; set; }

	}
}
