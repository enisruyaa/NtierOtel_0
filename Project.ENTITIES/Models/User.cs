using System.Collections.Generic;

namespace Project.ENTITIES.Models
{
	public class User : BaseEntity
	{
		public string UserName { get; set; }

		public string Password { get; set; }

		// Relational Properties

		public virtual UserProfile UserProfile { get; set; }

		public virtual List<Room> Rooms { get; set; }
		public virtual List<Reservation> Reservations { get; set; }
	}
}
