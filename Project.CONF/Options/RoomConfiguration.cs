using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
