using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        //Relational Properties

        public virtual User User { get; set; }
    }
}
