using System;
using System.Collections.Generic;
using System.Linq;
using Service.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.ComponentModel.DataAnnotations;

public class CompanyContext : DbContext
{
    public CompanyContext() : base("CompanyContext")
    {
    
    }
   
    public DbSet<VehicleMake> VehicleMakes { get; set; }
    public DbSet<Registration> Registrations { get; set; }
    public DbSet<VehicleModel> VehicleModels { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }
}

