using System;

namespace App.Core.Models
{
	public abstract class BaseEntity
	{
		public Guid Id { get; set; }
		public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset? UpdatedAt { get; set; }
    }
}
	
