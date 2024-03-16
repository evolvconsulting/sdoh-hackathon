using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Data.Interfaces;
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

    public virtual DbSet<Allergy> Allergies { get; set; }

    public virtual DbSet<Careplan> Careplans { get; set; }

    public virtual DbSet<Claim> Claims { get; set; }

    public virtual DbSet<ClaimTransaction> ClaimTransactions { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Condition1> Conditions1 { get; set; }

    public virtual DbSet<Device> Devices { get; set; }

    public virtual DbSet<Encounter> Encounters { get; set; }

    public virtual DbSet<ImagingStudy> ImagingStudies { get; set; }

    public virtual DbSet<Immunization> Immunizations { get; set; }

    public virtual DbSet<Medication> Medications { get; set; }

    public virtual DbSet<Observation> Observations { get; set; }

    public virtual DbSet<ObservationsTst> ObservationsTsts { get; set; }

    public virtual DbSet<Organization> Organizations { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    public virtual DbSet<Patient1> Patients1 { get; set; }

    public virtual DbSet<Payer> Payers { get; set; }

    public virtual DbSet<PayerTransaction> PayerTransactions { get; set; }

    public virtual DbSet<PayerTransition> PayerTransitions { get; set; }

    public virtual DbSet<Procedure> Procedures { get; set; }

    public virtual DbSet<Provider> Providers { get; set; }

    public virtual DbSet<Supply> Supplies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSnowflake("account=LRB04982;host=aovnged-evolv_health.snowflakecomputing.com;user=SVC_EVOLV_SDOH;password=pUB+^ONZrg<w{[6%95Aa;db=EVOLV_SDOH;schema=PUBLIC;warehouse=COMPUTE_WH");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("PUBLIC");

        modelBuilder.Entity<Allergy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ALLERGIES", "HL7");

            entity.Property(e => e.Category).HasColumnName("CATEGORY");
            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Description1).HasColumnName("DESCRIPTION1");
            entity.Property(e => e.Description2).HasColumnName("DESCRIPTION2");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Reaction1)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("REACTION1");
            entity.Property(e => e.Reaction2)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("REACTION2");
            entity.Property(e => e.Severity1).HasColumnName("SEVERITY1");
            entity.Property(e => e.Severity2).HasColumnName("SEVERITY2");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.Stop).HasColumnName("STOP");
            entity.Property(e => e.System).HasColumnName("SYSTEM");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<Careplan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CAREPLANS", "HL7");

            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Reasoncode)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("REASONCODE");
            entity.Property(e => e.Reasondescription).HasColumnName("REASONDESCRIPTION");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.Stop).HasColumnName("STOP");
        });

        modelBuilder.Entity<Claim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLAIMS", "HL7");

            entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");
            entity.Property(e => e.Currentillnessdate).HasColumnName("CURRENTILLNESSDATE");
            entity.Property(e => e.Departmentid)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DEPARTMENTID");
            entity.Property(e => e.Diagnosis1)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS1");
            entity.Property(e => e.Diagnosis2)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS2");
            entity.Property(e => e.Diagnosis3)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS3");
            entity.Property(e => e.Diagnosis4)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS4");
            entity.Property(e => e.Diagnosis5)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS5");
            entity.Property(e => e.Diagnosis6)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS6");
            entity.Property(e => e.Diagnosis7)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS7");
            entity.Property(e => e.Diagnosis8)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSIS8");
            entity.Property(e => e.Healthcareclaimtypeid1)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("HEALTHCARECLAIMTYPEID1");
            entity.Property(e => e.Healthcareclaimtypeid2)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("HEALTHCARECLAIMTYPEID2");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lastbilleddate1).HasColumnName("LASTBILLEDDATE1");
            entity.Property(e => e.Lastbilleddate2).HasColumnName("LASTBILLEDDATE2");
            entity.Property(e => e.Lastbilleddatep).HasColumnName("LASTBILLEDDATEP");
            entity.Property(e => e.Outstanding1)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("OUTSTANDING1");
            entity.Property(e => e.Outstanding2)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("OUTSTANDING2");
            entity.Property(e => e.Outstandingp)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("OUTSTANDINGP");
            entity.Property(e => e.Patientdepartmentid)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("PATIENTDEPARTMENTID");
            entity.Property(e => e.Patientid).HasColumnName("PATIENTID");
            entity.Property(e => e.Primarypatientinsuranceid).HasColumnName("PRIMARYPATIENTINSURANCEID");
            entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");
            entity.Property(e => e.Referringproviderid).HasColumnName("REFERRINGPROVIDERID");
            entity.Property(e => e.Secondarypatientinsuranceid).HasColumnName("SECONDARYPATIENTINSURANCEID");
            entity.Property(e => e.Servicedate).HasColumnName("SERVICEDATE");
            entity.Property(e => e.Status1).HasColumnName("STATUS1");
            entity.Property(e => e.Status2).HasColumnName("STATUS2");
            entity.Property(e => e.Statusp).HasColumnName("STATUSP");
            entity.Property(e => e.Supervisingproviderid).HasColumnName("SUPERVISINGPROVIDERID");
        });

        modelBuilder.Entity<ClaimTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CLAIM_TRANSACTIONS", "HL7");

            entity.Property(e => e.Adjustments)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ADJUSTMENTS");
            entity.Property(e => e.Amount)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("AMOUNT");
            entity.Property(e => e.Appointmentid).HasColumnName("APPOINTMENTID");
            entity.Property(e => e.Chargeid)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CHARGEID");
            entity.Property(e => e.Claimid).HasColumnName("CLAIMID");
            entity.Property(e => e.Departmentid)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DEPARTMENTID");
            entity.Property(e => e.Diagnosisref1)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSISREF1");
            entity.Property(e => e.Diagnosisref2)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSISREF2");
            entity.Property(e => e.Diagnosisref3)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSISREF3");
            entity.Property(e => e.Diagnosisref4)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DIAGNOSISREF4");
            entity.Property(e => e.Feescheduleid)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("FEESCHEDULEID");
            entity.Property(e => e.Fromdate).HasColumnName("FROMDATE");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Linenote).HasColumnName("LINENOTE");
            entity.Property(e => e.Method).HasColumnName("METHOD");
            entity.Property(e => e.Modifier1).HasColumnName("MODIFIER1");
            entity.Property(e => e.Modifier2).HasColumnName("MODIFIER2");
            entity.Property(e => e.Notes).HasColumnName("NOTES");
            entity.Property(e => e.Outstanding)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("OUTSTANDING");
            entity.Property(e => e.Patientid).HasColumnName("PATIENTID");
            entity.Property(e => e.Patientinsuranceid).HasColumnName("PATIENTINSURANCEID");
            entity.Property(e => e.Payments)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("PAYMENTS");
            entity.Property(e => e.Placeofservice).HasColumnName("PLACEOFSERVICE");
            entity.Property(e => e.Procedurecode)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("PROCEDURECODE");
            entity.Property(e => e.Providerid).HasColumnName("PROVIDERID");
            entity.Property(e => e.Supervisingproviderid).HasColumnName("SUPERVISINGPROVIDERID");
            entity.Property(e => e.Todate).HasColumnName("TODATE");
            entity.Property(e => e.Transferoutid)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("TRANSFEROUTID");
            entity.Property(e => e.Transfers)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("TRANSFERS");
            entity.Property(e => e.Transfertype).HasColumnName("TRANSFERTYPE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
            entity.Property(e => e.Unitamount)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("UNITAMOUNT");
            entity.Property(e => e.Units)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("UNITS");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CONDITIONS", "HL7");

            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.Stop).HasColumnName("STOP");
        });

        modelBuilder.Entity<Condition1>(entity =>
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

        modelBuilder.Entity<Device>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DEVICES", "HL7");

            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.StopTime).HasColumnName("STOP_TIME");
            entity.Property(e => e.Udi).HasColumnName("UDI");
        });

        modelBuilder.Entity<Encounter>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ENCOUNTERS", "HL7");

            entity.Property(e => e.BaseEncounterCost)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("BASE_ENCOUNTER_COST");
            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounterclass).HasColumnName("ENCOUNTERCLASS");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Organization).HasColumnName("ORGANIZATION");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Payer).HasColumnName("PAYER");
            entity.Property(e => e.PayerCoverage)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("PAYER_COVERAGE");
            entity.Property(e => e.Provider).HasColumnName("PROVIDER");
            entity.Property(e => e.Reasoncode)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("REASONCODE");
            entity.Property(e => e.Reasondescription).HasColumnName("REASONDESCRIPTION");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.StopTime).HasColumnName("STOP_TIME");
            entity.Property(e => e.TotalClaimCost)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("TOTAL_CLAIM_COST");
        });

        modelBuilder.Entity<ImagingStudy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMAGING_STUDIES", "HL7");

            entity.Property(e => e.BodysiteCode)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("BODYSITE_CODE");
            entity.Property(e => e.BodysiteDescription).HasColumnName("BODYSITE_DESCRIPTION");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InstanceUid).HasColumnName("INSTANCE_UID");
            entity.Property(e => e.ModalityCode).HasColumnName("MODALITY_CODE");
            entity.Property(e => e.ModalityDescription).HasColumnName("MODALITY_DESCRIPTION");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.ProcedureCode)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("PROCEDURE_CODE");
            entity.Property(e => e.SeriesUid).HasColumnName("SERIES_UID");
            entity.Property(e => e.SopCode).HasColumnName("SOP_CODE");
            entity.Property(e => e.SopDescription).HasColumnName("SOP_DESCRIPTION");
        });

        modelBuilder.Entity<Immunization>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IMMUNIZATIONS", "HL7");

            entity.Property(e => e.BaseCost)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("BASE_COST");
            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
        });

        modelBuilder.Entity<Medication>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MEDICATIONS", "HL7");

            entity.Property(e => e.BaseCost)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("BASE_COST");
            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Dispenses)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("DISPENSES");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Payer).HasColumnName("PAYER");
            entity.Property(e => e.PayerCoverage)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("PAYER_COVERAGE");
            entity.Property(e => e.Reasoncode)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("REASONCODE");
            entity.Property(e => e.Reasondescription).HasColumnName("REASONDESCRIPTION");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.StopTime).HasColumnName("STOP_TIME");
            entity.Property(e => e.Totalcost)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("TOTALCOST");
        });

        modelBuilder.Entity<Observation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OBSERVATIONS", "HL7");
        });

        modelBuilder.Entity<ObservationsTst>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OBSERVATIONS_TST", "HL7");
        });

        modelBuilder.Entity<Organization>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ORGANIZATIONS", "HL7");

            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lat)
                .HasColumnType("NUMBER(38,15)")
                .HasColumnName("LAT");
            entity.Property(e => e.Lon)
                .HasColumnType("NUMBER(38,14)")
                .HasColumnName("LON");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.Revenue)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("REVENUE");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Utilization)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("UTILIZATION");
            entity.Property(e => e.Zip)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PATIENTS", "HL7");

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
            entity.Property(e => e.Ssn).HasColumnName("SSN");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Suffix).HasColumnName("SUFFIX");
            entity.Property(e => e.Zip)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Patient1>(entity =>
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
            entity.Property(e => e.Smoker).HasColumnName("SMOKER");
            entity.Property(e => e.Ssn).HasColumnName("SSN");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Suffix).HasColumnName("SUFFIX");
            entity.Property(e => e.Zip)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Payer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PAYERS", "HL7");

            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.AmountCovered)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("AMOUNT_COVERED");
            entity.Property(e => e.AmountUncovered)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("AMOUNT_UNCOVERED");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.CoveredEncounters)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("COVERED_ENCOUNTERS");
            entity.Property(e => e.CoveredImmunizations)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("COVERED_IMMUNIZATIONS");
            entity.Property(e => e.CoveredMedications)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("COVERED_MEDICATIONS");
            entity.Property(e => e.CoveredProcedures)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("COVERED_PROCEDURES");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MemberMonths)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("MEMBER_MONTHS");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Ownership).HasColumnName("OWNERSHIP");
            entity.Property(e => e.Phone).HasColumnName("PHONE");
            entity.Property(e => e.QolsAvg)
                .HasColumnType("NUMBER(38,17)")
                .HasColumnName("QOLS_AVG");
            entity.Property(e => e.Revenue)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("REVENUE");
            entity.Property(e => e.StateHeadquartered).HasColumnName("STATE_HEADQUARTERED");
            entity.Property(e => e.UncoveredEncounters)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("UNCOVERED_ENCOUNTERS");
            entity.Property(e => e.UncoveredImmunizations)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("UNCOVERED_IMMUNIZATIONS");
            entity.Property(e => e.UncoveredMedications)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("UNCOVERED_MEDICATIONS");
            entity.Property(e => e.UncoveredProcedures)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("UNCOVERED_PROCEDURES");
            entity.Property(e => e.UniqueCustomers)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("UNIQUE_CUSTOMERS");
            entity.Property(e => e.Zip).HasColumnName("ZIP");
        });

        modelBuilder.Entity<PayerTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PAYER_TRANSACTIONS", "HL7");

            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.Memberid).HasColumnName("MEMBERID");
            entity.Property(e => e.OwnerName).HasColumnName("OWNER_NAME");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Payer).HasColumnName("PAYER");
            entity.Property(e => e.PlanOwnership).HasColumnName("PLAN_OWNERSHIP");
            entity.Property(e => e.SecondaryPayer).HasColumnName("SECONDARY_PAYER");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
        });

        modelBuilder.Entity<PayerTransition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PAYER_TRANSITIONS", "HL7");

            entity.Property(e => e.EndDate).HasColumnName("END_DATE");
            entity.Property(e => e.Memberid).HasColumnName("MEMBERID");
            entity.Property(e => e.OwnerName).HasColumnName("OWNER_NAME");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Payer).HasColumnName("PAYER");
            entity.Property(e => e.PlanOwnership).HasColumnName("PLAN_OWNERSHIP");
            entity.Property(e => e.SecondaryPayer).HasColumnName("SECONDARY_PAYER");
            entity.Property(e => e.StartDate).HasColumnName("START_DATE");
        });

        modelBuilder.Entity<Procedure>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROCEDURES", "HL7");

            entity.Property(e => e.BaseCost)
                .HasColumnType("NUMBER(38,2)")
                .HasColumnName("BASE_COST");
            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Reasoncode)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("REASONCODE");
            entity.Property(e => e.Reasondescription).HasColumnName("REASONDESCRIPTION");
            entity.Property(e => e.StartTime).HasColumnName("START_TIME");
            entity.Property(e => e.StopTime).HasColumnName("STOP_TIME");
        });

        modelBuilder.Entity<Provider>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROVIDERS", "HL7");

            entity.Property(e => e.Address).HasColumnName("ADDRESS");
            entity.Property(e => e.City).HasColumnName("CITY");
            entity.Property(e => e.Encounters)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ENCOUNTERS");
            entity.Property(e => e.Gender).HasColumnName("GENDER");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lat)
                .HasColumnType("NUMBER(38,15)")
                .HasColumnName("LAT");
            entity.Property(e => e.Lon)
                .HasColumnType("NUMBER(38,14)")
                .HasColumnName("LON");
            entity.Property(e => e.Name).HasColumnName("NAME");
            entity.Property(e => e.Organization).HasColumnName("ORGANIZATION");
            entity.Property(e => e.Procedures)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("PROCEDURES");
            entity.Property(e => e.Speciality).HasColumnName("SPECIALITY");
            entity.Property(e => e.State).HasColumnName("STATE");
            entity.Property(e => e.Zip)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<Supply>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SUPPLIES", "HL7");

            entity.Property(e => e.Code)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("CODE");
            entity.Property(e => e.Date).HasColumnName("DATE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Encounter).HasColumnName("ENCOUNTER");
            entity.Property(e => e.Patient).HasColumnName("PATIENT");
            entity.Property(e => e.Quantity)
                .HasColumnType("NUMBER(38,0)")
                .HasColumnName("QUANTITY");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
