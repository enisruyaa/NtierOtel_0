using Project.DAL.ContextClass;

namespace Project.BLL.DesignPatterns.SingletonPattern
{
	public class DBTool
	{
		public DBTool() { }

		static MyContext _dbInstance;

		public static MyContext DbInstance
		{
			get
			{
				if (_dbInstance == null) _dbInstance = new MyContext();
				return _dbInstance;
			}
		}
	}
}
