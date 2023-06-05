using System;
using Microsoft.EntityFrameworkCore;
using App.Core.Models;
using System.Reflection;

namespace App.Repository
{
	public class AppDbContext:DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<Vehicle> Vehicles;
		public DbSet<DeliveryPoint> DeliveryPoints;
		public DbSet<Bag> Bags;
		public DbSet<Package> Packages;
		public DbSet<PackageStatus> PackageStatues;
		public DbSet<BagStatus> BagStatues;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
		
	}
}

