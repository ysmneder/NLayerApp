using System;
namespace App.Core.Models
{
	public class Package: ShipmentBase
	{
		public string? AssignedBagBarcode { get; set; }
        public Guid PackageStatusId { get; set; }
		public PackageStatus PackageStatus { get; set; }

    }
}


