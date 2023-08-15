using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using App.Core.Models;

namespace App.Repository.Seeds
{
	public class BagStatusSeeds: IEntityTypeConfiguration<BagStatus>
	{
		public void Configure(EntityTypeBuilder<BagStatus> builder)
		{
			builder.HasData(
                new BagStatus {  Status = "Created", Value = 1 },
                new BagStatus {  Status = "Loaded", Value = 2 },
                new BagStatus {  Status = "Unloaded", Value = 3 }
                );
		}

	}
}

