using System;
using System.ComponentModel.DataAnnotations;

namespace App.Core.Models
{
	public class PackageStatus 
    {
        public int Value { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}

