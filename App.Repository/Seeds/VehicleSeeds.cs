using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using App.Core.Models;

namespace App.Repository.Seeds
{
	internal class VehicleSeeds : IEntityTypeConfiguration<Vehicle>
	{
		public void Configure(EntityTypeBuilder<Vehicle> builder)
		{
			builder.HasData( new Vehicle { Id = Guid.NewGuid(), Plate = "34 TR 321" });
		}
	}
}

