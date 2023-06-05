using System;
using App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Repository.Configurations
{
	internal class VehiclesConfiguration: IEntityTypeConfiguration<Vehicle>
	{
		public void Configure(EntityTypeBuilder<Vehicle> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Plate).IsRequired().HasMaxLength(50);
            
        }
		
	}
}

