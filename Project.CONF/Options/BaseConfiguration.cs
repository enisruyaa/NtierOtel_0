using Project.ENTITIES.Models;
using System.Data.Entity.ModelConfiguration;

namespace Project.CONF.Options
{
	public abstract class BaseConfiguration<T> : EntityTypeConfiguration<T> where T : BaseEntity
	{
		public BaseConfiguration()
		{

		}
	}
}
