using System;
namespace App.Core.Models
{
	public class Bag: ShipmentBase
	{
        public Guid BagStatusId { get; set; }
        public BagStatus BagStatus { get; set; }
    }
}

