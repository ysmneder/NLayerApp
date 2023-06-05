using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using App.Core.Models;
namespace App.Repository.Configurations
{
	public class BagStatusConfiguration: IEntityTypeConfiguration<BagStatus>
	{
		public void Configure(EntityTypeBuilder<BagStatus> builder)
		{
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Status).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Value).IsRequired();
        }
		
	}
}

