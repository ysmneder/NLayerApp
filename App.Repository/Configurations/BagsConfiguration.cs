using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using App.Core.Models;

namespace App.Repository.Configurations
{
	internal class BagsConfiguration : IEntityTypeConfiguration<Bag>
	{
		public void Configure(EntityTypeBuilder<Bag> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.VolumetricWeight).IsRequired();
			builder.Property(x => x.Barcode).IsRequired();
		}
		
	}
}

