using System;

namespace App.Core.Models
{
	public class DeliveryPoint: BaseEntity
	{
		public string DeliveryPointName { get; set; }
		public int Value { get; set; }
	}
}

