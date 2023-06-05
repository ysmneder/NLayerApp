using System;
namespace App.Core.Models
{
	public class PackageStatus : BaseEntity
    {
        public string Status { get; set; }
        public int Value { get; set; }

    }
}

