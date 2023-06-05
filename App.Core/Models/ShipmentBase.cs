using System;
namespace App.Core.Models
{
	public class ShipmentBase:BaseEntity
	{
		public decimal VolumetricWeight { get; set; } 
		public int DeliveryPointUnloading { get; set; }
		public string Barcode { get; set; }
	}
}

