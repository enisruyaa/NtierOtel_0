using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class ProfileConfiguration : BaseConfiguration<UserProfile>
    {
        public ProfileConfiguration()
        {
            Property(x => x.FirstName).IsRequired();
            Property(x => x.LastName).IsRequired();
            Property(x => x.Age).IsRequired();
            Property(x => x.Email).IsRequired();
        }
    }
}
