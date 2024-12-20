﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NobetYonetim.Data;

#nullable disable

namespace NobetYonetim.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NobetYonetim.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdminId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("NobetYonetim.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AppointmentId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("AssistantId")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("AppointmentId");

                    b.HasIndex("AdminId");

                    b.HasIndex("AssistantId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("NobetYonetim.Models.Assistant", b =>
                {
                    b.Property<int>("AssistantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AssistantId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<decimal>("Bonus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ShiftId")
                        .HasColumnType("int");

                    b.HasKey("AssistantId");

                    b.HasIndex("AdminId");

                    b.HasIndex("ShiftId");

                    b.ToTable("Assistants");
                });

            modelBuilder.Entity("NobetYonetim.Models.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int?>("AdminId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("AvailableEndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AvailableStartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId")
                        .IsUnique();

                    b.HasIndex("AdminId1");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("NobetYonetim.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("AvailableBeds")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OccupiedBeds")
                        .HasColumnType("int");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentId");

                    b.HasIndex("AdminId");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("NobetYonetim.Models.Emergency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Emergencies");
                });

            modelBuilder.Entity("NobetYonetim.Models.Log", b =>
                {
                    b.Property<int>("LogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LogId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OperationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LogId");

                    b.HasIndex("AdminId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("NobetYonetim.Models.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("AssistantId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.HasIndex("AssistantId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("NobetYonetim.Models.Professor", b =>
                {
                    b.Property<int>("ProfessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfessorId"));

                    b.Property<int>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Specialization")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfessorId");

                    b.HasIndex("AdminId");

                    b.ToTable("Professors");
                });

            modelBuilder.Entity("NobetYonetim.Models.Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShiftId"));

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<int>("AssistantId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShiftId");

                    b.HasIndex("AdminId");

                    b.HasIndex("AssistantId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("NobetYonetim.Models.Appointment", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithMany("Appointments")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NobetYonetim.Models.Assistant", "Assistant")
                        .WithMany("Appointments")
                        .HasForeignKey("AssistantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NobetYonetim.Models.Professor", "Professor")
                        .WithMany("Appointments")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Assistant");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("NobetYonetim.Models.Assistant", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithMany("Assistants")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NobetYonetim.Models.Shift", null)
                        .WithMany("Assistants")
                        .HasForeignKey("ShiftId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("NobetYonetim.Models.Calendar", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithOne("Calendar")
                        .HasForeignKey("NobetYonetim.Models.Calendar", "AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NobetYonetim.Models.Admin", null)
                        .WithMany("Calendars")
                        .HasForeignKey("AdminId1");

                    b.HasOne("NobetYonetim.Models.Professor", "Professor")
                        .WithMany("Calendars")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("NobetYonetim.Models.Department", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithMany("Departments")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NobetYonetim.Models.Professor", "Professor")
                        .WithMany("Departments")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("NobetYonetim.Models.Emergency", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithMany("Emergencies")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("NobetYonetim.Models.Log", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithMany("Logs")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("NobetYonetim.Models.Patient", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithMany("Patients")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("NobetYonetim.Models.Assistant", "Assistant")
                        .WithMany("Patients")
                        .HasForeignKey("AssistantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NobetYonetim.Models.Department", "Department")
                        .WithMany("Patients")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Admin");

                    b.Navigation("Assistant");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("NobetYonetim.Models.Professor", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", "Admin")
                        .WithMany("Professors")
                        .HasForeignKey("AdminId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("NobetYonetim.Models.Shift", b =>
                {
                    b.HasOne("NobetYonetim.Models.Admin", null)
                        .WithMany("Shifts")
                        .HasForeignKey("AdminId");

                    b.HasOne("NobetYonetim.Models.Assistant", "Assistant")
                        .WithMany("Shifts")
                        .HasForeignKey("AssistantId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NobetYonetim.Models.Department", "Department")
                        .WithMany("Shifts")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assistant");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("NobetYonetim.Models.Admin", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Assistants");

                    b.Navigation("Calendar");

                    b.Navigation("Calendars");

                    b.Navigation("Departments");

                    b.Navigation("Emergencies");

                    b.Navigation("Logs");

                    b.Navigation("Patients");

                    b.Navigation("Professors");

                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("NobetYonetim.Models.Assistant", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Patients");

                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("NobetYonetim.Models.Department", b =>
                {
                    b.Navigation("Patients");

                    b.Navigation("Shifts");
                });

            modelBuilder.Entity("NobetYonetim.Models.Professor", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Calendars");

                    b.Navigation("Departments");
                });

            modelBuilder.Entity("NobetYonetim.Models.Shift", b =>
                {
                    b.Navigation("Assistants");
                });
#pragma warning restore 612, 618
        }
    }
}
