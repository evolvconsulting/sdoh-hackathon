using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Data.Models;

namespace Data;

public partial class ScaffoldedContext : DbContext
{
    public ScaffoldedContext()
    {
    }

    public ScaffoldedContext(DbContextOptions<ScaffoldedContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("PUBLIC");

        modelBuilder.Entity<Condition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONDITIONS");

            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.Stop).HasColumnName("STOP");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PATIENTS");

            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.Birthdate).HasColumnName("BIRTHDATE");
            entity.Property(e => e.Birthplace).HasColumnName("BIRTHPLACE");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.County).HasColumnName("COUNTY");
            entity.Property(e => e.Deathdate).HasColumnName("DEATHDATE");
            entity.Property(e => e.Drivers).HasColumnName("DRIVERS");
            entity.Property(e => e.Ethnicity).HasColumnName("ETHNICITY");
            entity.Property(e => e.Fips)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("FIPS");
            entity.Property(e => e.First).HasColumnName("FIRST");
            entity.Property(e => e.Gender).HasColumnName("GENDER");
            entity.Property(e => e.HealthcareCoverage)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("HEALTHCARE_COVERAGE");
            entity.Property(e => e.HealthcareExpenses)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("HEALTHCARE_EXPENSES");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Income)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("INCOME");
            entity.Property(e => e.Last).HasColumnName("LAST");
            entity.Property(e => e.Lat)
                .HasColumnType("NUMBER(38,15)")
                .HasColumnName("LAT");
            entity.Property(e => e.Lon)
                .HasColumnType("NUMBER(38,14)")
                .HasColumnName("LON");
            entity.Property(e => e.Maiden).HasColumnName("MAIDEN");
            entity.Property(e => e.Marital).HasColumnName("MARITAL");
            entity.Property(e => e.Passport).HasColumnName("PASSPORT");
            entity.Property(e => e.Prefix).HasColumnName("PREFIX");
            entity.Property(e => e.Race).HasColumnName("RACE");
            entity.Property(e => e.Smoker)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("SMOKER");
            entity.Property(e => e.Ssn).HasColumnName("SSN");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Suffix).HasColumnName("SUFFIX");
            entity.Property(e => e.Zip)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ZIP");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
