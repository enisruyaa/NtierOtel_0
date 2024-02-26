using Project.ENTITIES.Models;

namespace Project.CONF.Options
{
	public class RoomConfiguration : BaseConfiguration<Room>
	{
		public RoomConfiguration()
		{
			Property(x => x.Price).HasColumnType("money");
		}
	}
}
