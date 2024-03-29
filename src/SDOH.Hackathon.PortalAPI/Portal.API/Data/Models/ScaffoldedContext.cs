﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Data.Models;

public partial class ScaffoldedContext : DbContext
{
    public ScaffoldedContext()
    {
    }

    public ScaffoldedContext(DbContextOptions<ScaffoldedContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HighRiskQc> HighRiskQcs { get; set; }

    public virtual DbSet<Intervention> Interventions { get; set; }

    public virtual DbSet<InterventionResource> InterventionResources { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<PatientCondition> PatientConditions { get; set; }

    public virtual DbSet<PatientIntervention> PatientInterventions { get; set; }

    public virtual DbSet<PatientInterventionNotification> PatientInterventionNotifications { get; set; }

    public virtual DbSet<PatientRiskFactor> PatientRiskFactors { get; set; }

    public virtual DbSet<PatientRiskLevel> PatientRiskLevels { get; set; }

    public virtual DbSet<RiskFactor> RiskFactors { get; set; }

    public virtual DbSet<RiskFactorGroup> RiskFactorGroups { get; set; }

    public virtual DbSet<RiskLevel> RiskLevels { get; set; }

    public virtual DbSet<RiskLevelIntervention> RiskLevelInterventions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("PUBLIC");

        modelBuilder.Entity<HighRiskQc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HIGH_RISK_QC");

            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.Birthdate).HasColumnName("BIRTHDATE");
            entity.Property(e => e.Birthplace).HasColumnName("BIRTHPLACE");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.County).HasColumnName("COUNTY");
            entity.Property(e => e.Deathdate).HasColumnName("DEATHDATE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Drivers).HasColumnName("DRIVERS");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
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
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Prefix).HasColumnName("PREFIX");
            entity.Property(e => e.Race).HasColumnName("RACE");
            entity.Property(e => e.Smoker)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("SMOKER");
            entity.Property(e => e.Ssn).HasColumnName("SSN");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Stop).HasColumnName("STOP");
            entity.Property(e => e.Suffix).HasColumnName("SUFFIX");
            entity.Property(e => e.Zip)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Intervention>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_8385a574-2f6f-4b9a-837f-474298ad36dd");

            entity.ToTable("INTERVENTION", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name).HasColumnName("NAME");
        });

        modelBuilder.Entity<InterventionResource>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_a22519b8-b2f2-42c9-b7ec-18a3bcd2ef55");

            entity.ToTable("INTERVENTION_RESOURCE", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Document).HasColumnName("DOCUMENT");
            entity.Property(e => e.TypeId)
                .HasMaxLength(255)
                .HasColumnName("TYPE_ID");
            entity.Property(e => e.Url).HasColumnName("URL");
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_adb2d237-1d76-4342-a634-f64bd796de83");

            entity.ToTable("NOTIFICATION", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeliveredDate).HasColumnName("DELIVERED_DATE");
            entity.Property(e => e.InsertDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP()")
                .HasColumnName("INSERT_DATE");
            entity.Property(e => e.IsDeleted)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("IS_DELETED");
            entity.Property(e => e.Message).HasColumnName("MESSAGE");
            entity.Property(e => e.NotificationTypeId).HasColumnName("NOTIFICATION_TYPE_ID");
            entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");
            entity.Property(e => e.ReadDate).HasColumnName("READ_DATE");
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_b34de94c-3d87-40cf-825e-69a66ab55a09");

            entity.ToTable("NOTIFICATION_TYPE", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Template).HasColumnName("TEMPLATE");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PATIENTS");

            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.AllowsPushNotifications)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ALLOWS_PUSH_NOTIFICATIONS");
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

        modelBuilder.Entity<PatientCondition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PATIENT_CONDITION");

            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.Stop).HasColumnName("STOP");
        });

        modelBuilder.Entity<PatientIntervention>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_469e832a-dd88-433b-b0c1-1da76988cb43");

            entity.ToTable("PATIENT_INTERVENTION", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EnrolledDate).HasColumnName("ENROLLED_DATE");
            entity.Property(e => e.InterventionId).HasColumnName("INTERVENTION_ID");
            entity.Property(e => e.IsManual)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("IS_MANUAL");
            entity.Property(e => e.OptOutDate).HasColumnName("OPT_OUT_DATE");
            entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");
            entity.Property(e => e.SentToUserDate).HasColumnName("SENT_TO_USER_DATE");
            entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");
        });

        modelBuilder.Entity<PatientInterventionNotification>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_b1d9f573-d359-421a-be19-da18019fee4f");

            entity.ToTable("PATIENT_INTERVENTION_NOTIFICATION", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NotificationId).HasColumnName("NOTIFICATION_ID");
            entity.Property(e => e.PatientInterventionId).HasColumnName("PATIENT_INTERVENTION_ID");
        });

        modelBuilder.Entity<PatientRiskFactor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_d11f692c-9222-4f5b-b9de-c4019150a9a7");

            entity.ToTable("PATIENT_RISK_FACTOR", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");
            entity.Property(e => e.RiskFactorId).HasColumnName("RISK_FACTOR_ID");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<PatientRiskLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_16155c98-d727-4860-aed2-9013c78d5937");

            entity.ToTable("PATIENT_RISK_LEVEL", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FromDate).HasColumnName("FROM_DATE");
            entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");
            entity.Property(e => e.RiskLevelId).HasColumnName("RISK_LEVEL_ID");
            entity.Property(e => e.ToDate).HasColumnName("TO_DATE");
        });

        modelBuilder.Entity<RiskFactor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_cae1c3a4-c10c-4c82-8d43-26ad3fc490e1");

            entity.ToTable("RISK_FACTOR", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.RiskFactorGroupId).HasColumnName("RISK_FACTOR_GROUP_ID");
        });

        modelBuilder.Entity<RiskFactorGroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_da4b05b4-2189-4ff7-85f6-747ce46dbca8");

            entity.ToTable("RISK_FACTOR_GROUP", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Name).HasColumnName("NAME");
        });

        modelBuilder.Entity<RiskLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_dbca300f-0e41-4b67-828e-0520aa2d795f");

            entity.ToTable("RISK_LEVEL", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Severity).HasColumnName("SEVERITY");
        });

        modelBuilder.Entity<RiskLevelIntervention>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("SYS_CONSTRAINT_f39324af-ad3e-4be9-9476-ce689e4aa798");

            entity.ToTable("RISK_LEVEL_INTERVENTION", "PUBLIC");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InterventionId).HasColumnName("INTERVENTION_ID");
            entity.Property(e => e.RiskLevelId).HasColumnName("RISK_LEVEL_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
