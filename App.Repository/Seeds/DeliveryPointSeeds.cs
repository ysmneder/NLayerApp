using System;
using App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace App.Repository.Seeds
{
	internal class DeliveryPointSeeds: IEntityTypeConfiguration<DeliveryPoint>
	{
		public void Configure(EntityTypeBuilder<DeliveryPoint> builder)
		{
			builder.HasData(
				new DeliveryPoint { Id = new Guid(), DeliveryPointName = "Branch", Value = 1},
				new DeliveryPoint { Id = new Guid(), DeliveryPointName = "Distribution Center", Value = 2 },
                new DeliveryPoint { Id = new Guid(), DeliveryPointName = "Transfer Center", Value = 3 }
                );
		}
		
	}
}

