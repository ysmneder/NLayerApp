using System;
using App.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace App.Repository.Configurations
{
	public class PackageStatusConfiguration : IEntityTypeConfiguration<PackageStatus>
	{
	    public void Configure(EntityTypeBuilder<PackageStatus> builder)
		{
			builder.HasKey(x => x.Value);
			builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
			builder.Property(x => x.Value).IsRequired();
		}
	}
}




