using System;
namespace App.Core.Models
{
	public class ShipmentBase:BaseEntity
	{
		public decimal VolumetricWeight { get; set; } 
		public Guid DeliveryPointId { get; set; }
		public DeliveryPoint DeliveryPoint { get; set; }
		public string Barcode { get; set; }
		public Guid VehicleId { get; set; }
		public Vehicle Vehicle { get; set; }
	}
}

