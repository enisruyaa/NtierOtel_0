using Project.ENTITIES.Models;

namespace Project.CONF.Options
{
	public class UserConfiguration : BaseConfiguration<User>
	{
		public UserConfiguration()
		{
			HasOptional(x => x.UserProfile).WithRequired(x => x.User);

			Property(x => x.UserName).IsRequired();
			Property(x => x.Password).IsRequired();
		}
	}
}
