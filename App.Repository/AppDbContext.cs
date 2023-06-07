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


        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {

			foreach (var item in ChangeTracker.Entries())
			{
				if( item.Entity is BaseEntity entityReference)
				{
					switch (item.State)
					{
						case EntityState.Added:
							{
								entityReference.CreatedAt = DateTimeOffset.UtcNow;
								break;
							}
						case EntityState.Modified:
							{
                                Entry(entityReference).Property(x => x.CreatedAt).IsModified = false;
                                entityReference.UpdatedAt = DateTimeOffset.UtcNow;
								break;
							}
						
					}
				}
			} 

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges()
        {
            foreach (var item in ChangeTracker.Entries())
            {
                if (item.Entity is BaseEntity entityReference)
                {
                    switch (item.State)
                    {
                        case EntityState.Added:
                            {
                                entityReference.CreatedAt = DateTimeOffset.UtcNow;
                                break;
                            }
                        case EntityState.Modified:
                            {
								Entry(entityReference).Property(x => x.CreatedAt).IsModified = false;
                                entityReference.UpdatedAt = DateTimeOffset.UtcNow;
                                break;
                            }

                    }
                }
            }
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
		
	}
}

