using Project.ENTITIES.Enums;
using System;

namespace Project.ENTITIES.Models
{
	public abstract class BaseEntity
	{
		public BaseEntity()
		{
			CreatedDate = DateTime.Now;
			Status = DataStatus.Inserted;
		}

		public int ID { get; set; }

		public DateTime CreatedDate { get; set; }

		public DateTime? ModifiedDate { get; set; }

		public DateTime? DeletedDate { get; set; }

		public DataStatus Status { get; set; }
	}
}
