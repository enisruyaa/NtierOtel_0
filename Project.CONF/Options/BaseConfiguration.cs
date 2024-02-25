using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
    {
        public BaseConfiguration()
        {
            
        }
    }
}
