using System;
using App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Repository.Configurations
{
	internal class DeliveryPointsConfiguration: IEntityTypeConfiguration<DeliveryPoint>
	{
        public void Configure(EntityTypeBuilder<DeliveryPoint> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DeliveryPointName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Value).IsRequired();

        }

    }
}

