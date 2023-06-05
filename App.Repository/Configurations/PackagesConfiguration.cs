
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using App.Core.Models;

namespace App.Repository.Configurations
{
    internal class PackagesConfiguration : IEntityTypeConfiguration<Package>
    {
        public void Configure(EntityTypeBuilder<Package> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.VolumetricWeight).IsRequired();
            builder.Property(x => x.Barcode).IsRequired();
        }

    }
}

