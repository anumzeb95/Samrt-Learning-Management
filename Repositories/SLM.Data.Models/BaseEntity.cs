﻿

using System.ComponentModel.DataAnnotations;

namespace SLM.Data.Models
{
	public class BaseEntity
	{
		[Key]
		public int Id { get; set; }

		public DateTime CreatedOn { get; set; }
		public DateTime UpdatedOn { get; set; }

		public bool isActive { get; set; } = true;
		public bool IsDeleted { get; set; }

	}
}
