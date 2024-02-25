using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public UserConfiguration()
        {
            HasOptional(x=>x.UserProfile).WithRequired(x => x.User);

            Property(x => x.UserName).IsRequired();
            Property(x => x.Password).IsRequired();
        }
    }
}
