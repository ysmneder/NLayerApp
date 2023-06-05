﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Core.Models;
namespace App.Repository.Seeds
{
	public class PackageStatusSeeds : IEntityTypeConfiguration<PackageStatus>
	{
		public void Configure(EntityTypeBuilder<PackageStatus> builder)
		{
			builder.HasData(
				new PackageStatus { Id = new Guid(), Status = "Created" ,Value = 1 },
				new PackageStatus { Id = new Guid(), Status = "Loaded into Bag", Value = 2 },
                new PackageStatus { Id = new Guid(), Status = "Loaded", Value = 3 },
                new PackageStatus { Id = new Guid(), Status = "Unloaded", Value = 4 }
                );
		}
	}
}

