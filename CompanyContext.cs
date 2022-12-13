using System;

public class CompanyContext : DbContext
{
	public CompanyContext() : base ("CompanyContext")
	{

	public DbSet<VehicleMake> VehicleMakes { get; set; }
	public DbSet<Registration> Registrations { get; set; }
	public DbSet<VehicleModel> VehicleModels { get; set; }

	protected override void OnModelCreating(DbModelBuilder)
	{ 
	modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
	}
	}
}
