using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PetBook.Models;

namespace PetBook.Data
{
    public partial class PetbookContext : DbContext
    {
        public PetbookContext()
        {
        }

        public PetbookContext(DbContextOptions<PetbookContext> options)
            : base(options)
        {

        }

        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Calendar> Calendar { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<ClientPet> ClientPet { get; set; }
        public DbSet<ClientVet> ClientVet { get; set; }
        public DbSet<MedicalFile> MedicalFile { get; set; }
        public DbSet<MedicalProcedure> MedicalProcedure { get; set; }
        public DbSet<Medication> Medication { get; set; }
        public DbSet<Pet> Pet { get; set; }
        public DbSet<PetCalendar> PetCalendar { get; set; }
        public DbSet<PetMed> PetMed { get; set; }
        public DbSet<Vaccination> Vaccination { get; set; }
        public DbSet<Veterinarian> Veterinarian { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-JO6THEP9\\SQLEXPRESS;Initial Catalog=Petbook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.AppointmentId)
                    .HasColumnName("Appointment ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmentDate)
                    .HasColumnName("Appointment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AppointmentDescription).HasColumnName("Appointment Description");
            });

            modelBuilder.Entity<Calendar>(entity =>
            {
                entity.Property(e => e.CalendarId)
                    .HasColumnName("Calendar ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EntryActionDate)
                    .HasColumnName("Entry Action Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntryCreated)
                    .HasColumnName("Entry Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntryNotes).HasColumnName("Entry Notes");

                entity.Property(e => e.EntryTitle).HasColumnName("Entry Title");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientId)
                    .HasColumnName("Client ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientPhoneNumber).HasColumnName("Client phone Number");

                entity.Property(e => e.ClientProfileImagePath).HasColumnName("Client Profile Image Path");

                entity.Property(e => e.DateOfProfileCreation)
                    .HasColumnName("Date of Profile Creation")
                    .HasColumnType("datetime");

                entity.Property(e => e.FirstName).HasColumnName("First Name");

                entity.Property(e => e.LastName).HasColumnName("Last Name");

                entity.Property(e => e.MiddleName).HasColumnName("Middle Name");

                entity.Property(e => e.TownOrCity).HasColumnName("Town or City");

                entity.Property(e => e.UserEMail).HasColumnName("User E-mail");

                entity.Property(e => e.UserStreetAddress).HasColumnName("User Street Address");
            });

            modelBuilder.Entity<ClientPet>(entity =>
            {
                entity.HasKey(e => e.IdexNumber)
                    .HasName("PK__ClientPe__36E7A3C7B4B929B0");

                entity.Property(e => e.IdexNumber)
                    .HasColumnName("Idex Number")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("Client ID");

                entity.Property(e => e.PetId).HasColumnName("Pet ID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientPet)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__ClientPet__Clien__2E1BDC42");

                entity.HasOne(d => d.Pet)
                    .WithMany(p => p.ClientPet)
                    .HasForeignKey(d => d.PetId)
                    .HasConstraintName("FK__ClientPet__Pet I__2F10007B");
            });

            modelBuilder.Entity<ClientVet>(entity =>
            {
                entity.HasKey(e => e.IdexNumber)
                    .HasName("PK__ClientVe__36E7A3C7F62723EE");

                entity.Property(e => e.IdexNumber)
                    .HasColumnName("Idex Number")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("Client ID");

                entity.Property(e => e.VetId).HasColumnName("Vet ID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.ClientVet)
                    .HasForeignKey(d => d.ClientId)
                    .HasConstraintName("FK__ClientVet__Clien__30F848ED");

                entity.HasOne(d => d.Vet)
                    .WithMany(p => p.ClientVet)
                    .HasForeignKey(d => d.VetId)
                    .HasConstraintName("FK__ClientVet__Vet I__300424B4");
            });

            modelBuilder.Entity<MedicalFile>(entity =>
            {
                entity.Property(e => e.MedicalFileId)
                    .HasColumnName("Medical File ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppointmentId).HasColumnName("Appointment ID");

                entity.Property(e => e.MedicationId).HasColumnName("Medication ID");

                entity.Property(e => e.PetId).HasColumnName("Pet ID");

                entity.Property(e => e.ProcedureId).HasColumnName("Procedure ID");

                entity.Property(e => e.VaccinationId).HasColumnName("Vaccination ID");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.MedicalFile)
                    .HasForeignKey(d => d.AppointmentId)
                    .HasConstraintName("FK__MedicalFi__Appoi__31EC6D26");

                entity.HasOne(d => d.Medication)
                    .WithMany(p => p.MedicalFile)
                    .HasForeignKey(d => d.MedicationId)
                    .HasConstraintName("FK__MedicalFi__Medic__33D4B598");

                entity.HasOne(d => d.Pet)
                    .WithMany(p => p.MedicalFile)
                    .HasForeignKey(d => d.PetId)
                    .HasConstraintName("FK__MedicalFi__Pet I__35BCFE0A");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.MedicalFile)
                    .HasForeignKey(d => d.ProcedureId)
                    .HasConstraintName("FK__MedicalFi__Proce__32E0915F");

                entity.HasOne(d => d.Vaccination)
                    .WithMany(p => p.MedicalFile)
                    .HasForeignKey(d => d.VaccinationId)
                    .HasConstraintName("FK__MedicalFi__Vacci__34C8D9D1");
            });

            modelBuilder.Entity<MedicalProcedure>(entity =>
            {
                entity.HasKey(e => e.ProcedureId)
                    .HasName("PK__MedicalP__98B85A155757579E");

                entity.Property(e => e.ProcedureId)
                    .HasColumnName("Procedure ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ProcedureDate)
                    .HasColumnName("Procedure Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcedureFollowUp)
                    .HasColumnName("Procedure Follow Up")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcedureNotes).HasColumnName("Procedure Notes");

                entity.Property(e => e.ProcedureType).HasColumnName("Procedure Type");
            });

            modelBuilder.Entity<Medication>(entity =>
            {
                entity.Property(e => e.MedicationId)
                    .HasColumnName("Medication ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicationDescription).HasColumnName("Medication Description");

                entity.Property(e => e.MedicationDirections).HasColumnName("Medication Directions");

                entity.Property(e => e.MedicationIssueDate)
                    .HasColumnName("Medication Issue Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MedicationName).HasColumnName("Medication Name");

                entity.Property(e => e.MedicationsRefillDate)
                    .HasColumnName("Medications Refill Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Pet>(entity =>
            {
                entity.Property(e => e.PetId)
                    .HasColumnName("Pet ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PetBreed).HasColumnName("Pet Breed");

                entity.Property(e => e.PetImage).HasColumnName("Pet Image");

                entity.Property(e => e.PetName).HasColumnName("Pet Name");

                entity.Property(e => e.PetProfileImagePath).HasColumnName("Pet Profile Image Path");

                entity.Property(e => e.PetSex).HasColumnName("Pet Sex");

                entity.Property(e => e.PetSpecies).HasColumnName("Pet Species");
            });

            modelBuilder.Entity<PetCalendar>(entity =>
            {
                entity.HasKey(e => e.IdexNumber)
                    .HasName("PK__PetCalen__36E7A3C7BD7B7EAA");

                entity.Property(e => e.IdexNumber)
                    .HasColumnName("Idex Number")
                    .ValueGeneratedNever();

                entity.Property(e => e.CalendarId).HasColumnName("Calendar ID");

                entity.Property(e => e.MedicalFileId).HasColumnName("Medical File ID");

                entity.Property(e => e.PetId).HasColumnName("Pet ID");

                entity.HasOne(d => d.Calendar)
                    .WithMany(p => p.PetCalendar)
                    .HasForeignKey(d => d.CalendarId)
                    .HasConstraintName("FK__PetCalend__Calen__2B3F6F97");

                entity.HasOne(d => d.MedicalFile)
                    .WithMany(p => p.PetCalendar)
                    .HasForeignKey(d => d.MedicalFileId)
                    .HasConstraintName("FK__PetCalend__Medic__29572725");

                entity.HasOne(d => d.Pet)
                    .WithMany(p => p.PetCalendar)
                    .HasForeignKey(d => d.PetId)
                    .HasConstraintName("FK__PetCalend__Pet I__2A4B4B5E");
            });

            modelBuilder.Entity<PetMed>(entity =>
            {
                entity.HasKey(e => e.IdexNumber)
                    .HasName("PK__PetMed__36E7A3C746D9B238");

                entity.Property(e => e.IdexNumber)
                    .HasColumnName("Idex Number")
                    .ValueGeneratedNever();

                entity.Property(e => e.MedicalFileId).HasColumnName("Medical File ID");

                entity.Property(e => e.PetId).HasColumnName("Pet ID");

                entity.HasOne(d => d.MedicalFile)
                    .WithMany(p => p.PetMed)
                    .HasForeignKey(d => d.MedicalFileId)
                    .HasConstraintName("FK__PetMed__Medical __2D27B809");

                entity.HasOne(d => d.Pet)
                    .WithMany(p => p.PetMed)
                    .HasForeignKey(d => d.PetId)
                    .HasConstraintName("FK__PetMed__Pet ID__2C3393D0");
            });

            modelBuilder.Entity<Vaccination>(entity =>
            {
                entity.Property(e => e.VaccinationId)
                    .HasColumnName("VACCINATION ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.VaccinationDate)
                    .HasColumnName("Vaccination Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.VaccinationExpiryDate)
                    .HasColumnName("Vaccination Expiry Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.VaccinationName).HasColumnName("Vaccination Name");

                entity.Property(e => e.VaccinationNotes).HasColumnName("Vaccination Notes");

                entity.Property(e => e.VaccinationType).HasColumnName("Vaccination Type");
            });

            modelBuilder.Entity<Veterinarian>(entity =>
            {
                entity.HasKey(e => e.VetId)
                    .HasName("PK__Veterina__7774A44E6F225AC9");

                entity.Property(e => e.VetId)
                    .HasColumnName("Vet ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TownOrCity).HasColumnName("Town or City");

                entity.Property(e => e.VetEMail).HasColumnName("Vet E-mail");

                entity.Property(e => e.VetName).HasColumnName("Vet Name");

                entity.Property(e => e.VetPhoneNumber).HasColumnName("Vet phone Number");

                entity.Property(e => e.VetProfileImagePath).HasColumnName("Vet Profile Image Path");

                entity.Property(e => e.VetStreetAddress).HasColumnName("Vet Street Address");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
