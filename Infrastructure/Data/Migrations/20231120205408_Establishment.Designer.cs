﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    [Migration("20231120205408_Establishment")]
    partial class Establishment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.13");

            modelBuilder.Entity("Core.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IconUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Core.Entities.Company.Description", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Detail")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PlanId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlanId");

                    b.ToTable("Descriptions");
                });

            modelBuilder.Entity("Core.Entities.Company.EstablichmentAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BranchName")
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .HasColumnType("TEXT");

                    b.Property<int>("EstablishmentId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsMain")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .HasColumnType("TEXT");

                    b.Property<string>("Zipcode")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EstablishmentId")
                        .IsUnique();

                    b.ToTable("EstablichmentAddresses");
                });

            modelBuilder.Entity("Core.Entities.Company.Establishment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<int>("PlanID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.HasIndex("PlanID");

                    b.ToTable("Establishments");
                });

            modelBuilder.Entity("Core.Entities.Company.EstablishmentService", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EstablishmentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ServiceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EstablishmentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("EstablishmentServices");
                });

            modelBuilder.Entity("Core.Entities.Company.Plan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Plans");
                });

            modelBuilder.Entity("Core.Entities.Company.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstablishmentId")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("TimeEnd")
                        .HasColumnType("TEXT");

                    b.Property<TimeSpan>("TimeStart")
                        .HasColumnType("TEXT");

                    b.Property<int>("WeekDay")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("EstablishmentId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("Core.Entities.Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstablishmentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NumberPhone")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("EstablishmentId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Core.Entities.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("Core.Entities.Company.Description", b =>
                {
                    b.HasOne("Core.Entities.Company.Plan", null)
                        .WithMany("Description")
                        .HasForeignKey("PlanId");
                });

            modelBuilder.Entity("Core.Entities.Company.EstablichmentAddress", b =>
                {
                    b.HasOne("Core.Entities.Company.Establishment", "Establishment")
                        .WithOne("EstablichmentAddresses")
                        .HasForeignKey("Core.Entities.Company.EstablichmentAddress", "EstablishmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Establishment");
                });

            modelBuilder.Entity("Core.Entities.Company.Establishment", b =>
                {
                    b.HasOne("Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Company.Plan", "Plan")
                        .WithMany()
                        .HasForeignKey("PlanID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Plan");
                });

            modelBuilder.Entity("Core.Entities.Company.EstablishmentService", b =>
                {
                    b.HasOne("Core.Entities.Company.Establishment", "Establishment")
                        .WithMany("EstablishmentServices")
                        .HasForeignKey("EstablishmentId");

                    b.HasOne("Core.Entities.Service", "Service")
                        .WithMany("EstablishmentServices")
                        .HasForeignKey("ServiceId");

                    b.Navigation("Establishment");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Core.Entities.Company.Schedule", b =>
                {
                    b.HasOne("Core.Entities.Company.Establishment", "Establishment")
                        .WithMany("Schedule")
                        .HasForeignKey("EstablishmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Establishment");
                });

            modelBuilder.Entity("Core.Entities.Phone", b =>
                {
                    b.HasOne("Core.Entities.Company.Establishment", "Establishment")
                        .WithMany("Phone")
                        .HasForeignKey("EstablishmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Establishment");
                });

            modelBuilder.Entity("Core.Entities.Service", b =>
                {
                    b.HasOne("Core.Entities.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.Entities.Company.Establishment", b =>
                {
                    b.Navigation("EstablichmentAddresses");

                    b.Navigation("EstablishmentServices");

                    b.Navigation("Phone");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Core.Entities.Company.Plan", b =>
                {
                    b.Navigation("Description");
                });

            modelBuilder.Entity("Core.Entities.Service", b =>
                {
                    b.Navigation("EstablishmentServices");
                });
#pragma warning restore 612, 618
        }
    }
}
