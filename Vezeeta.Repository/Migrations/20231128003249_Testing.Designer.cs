﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vezeeta.Repository;

#nullable disable

namespace Vezeeta.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231128003249_Testing")]
    partial class Testing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Appointment", b =>
                {
                    b.Property<int>("appointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("appointmentId"));

                    b.Property<string>("doctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("appointmentId");

                    b.HasIndex("doctorId");

                    b.ToTable("Appointment");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Booking", b =>
                {
                    b.Property<int>("bookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bookingId"));

                    b.Property<int?>("discountCodeId")
                        .HasColumnType("int");

                    b.Property<string>("doctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("finalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("patientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("timeSlotId")
                        .HasColumnType("int");

                    b.HasKey("bookingId");

                    b.HasIndex("discountCodeId");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.HasIndex("timeSlotId");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.DaySchedule", b =>
                {
                    b.Property<int>("dayScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("dayScheduleId"));

                    b.Property<int>("appointmentId")
                        .HasColumnType("int");

                    b.Property<short>("dayOfWeek")
                        .HasColumnType("smallint");

                    b.HasKey("dayScheduleId");

                    b.HasIndex("appointmentId");

                    b.ToTable("DaySchedule");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.DiscountCode", b =>
                {
                    b.Property<int>("discountCodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("discountCodeId"));

                    b.Property<string>("discountCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("discountType")
                        .HasColumnType("smallint");

                    b.Property<decimal>("discountValue")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("isValid")
                        .HasColumnType("bit");

                    b.Property<int>("numberOfRequiredBooking")
                        .HasColumnType("int");

                    b.HasKey("discountCodeId");

                    b.ToTable("DiscountCode");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Feedback", b =>
                {
                    b.Property<int>("feedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("feedbackId"));

                    b.Property<int>("bookingId")
                        .HasColumnType("int");

                    b.Property<string>("doctorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patientId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("feedbackId");

                    b.HasIndex("bookingId");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Specialization", b =>
                {
                    b.Property<int>("specializationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("specializationId"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("specializationId");

                    b.ToTable("Specializations");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.TimeSlot", b =>
                {
                    b.Property<int>("tiemSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tiemSlotId"));

                    b.Property<int>("dayScheduleId")
                        .HasColumnType("int");

                    b.Property<DateTime>("endTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isBooked")
                        .HasColumnType("bit");

                    b.Property<DateTime>("startTime")
                        .HasColumnType("datetime2");

                    b.HasKey("tiemSlotId");

                    b.HasIndex("dayScheduleId");

                    b.ToTable("TimeSlot");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Users.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<DateTime>("dateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("gender")
                        .HasColumnType("smallint");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Users.Doctor", b =>
                {
                    b.HasBaseType("Vezeeta.Core.Models.Users.ApplicationUser");

                    b.Property<int>("specializationId")
                        .HasColumnType("int");

                    b.HasIndex("specializationId");

                    b.ToTable("Doctors", (string)null);
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Users.Patient", b =>
                {
                    b.HasBaseType("Vezeeta.Core.Models.Users.ApplicationUser");

                    b.ToTable("Patients", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Users.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Appointment", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Users.Doctor", "doctor")
                        .WithMany("appointments")
                        .HasForeignKey("doctorId");

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Booking", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.DiscountCode", "discountCode")
                        .WithMany()
                        .HasForeignKey("discountCodeId");

                    b.HasOne("Vezeeta.Core.Models.Users.Doctor", "doctor")
                        .WithMany("bookings")
                        .HasForeignKey("doctorId");

                    b.HasOne("Vezeeta.Core.Models.Users.Patient", "patient")
                        .WithMany("bookings")
                        .HasForeignKey("patientId");

                    b.HasOne("Vezeeta.Core.Models.TimeSlot", "timeSlot")
                        .WithMany()
                        .HasForeignKey("timeSlotId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("discountCode");

                    b.Navigation("doctor");

                    b.Navigation("patient");

                    b.Navigation("timeSlot");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.DaySchedule", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Appointment", "appointment")
                        .WithMany("daySchedules")
                        .HasForeignKey("appointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("appointment");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Feedback", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Booking", "booking")
                        .WithMany()
                        .HasForeignKey("bookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.Users.Doctor", "doctor")
                        .WithMany("feedbacks")
                        .HasForeignKey("doctorId");

                    b.HasOne("Vezeeta.Core.Models.Users.Patient", "patient")
                        .WithMany("feedbacks")
                        .HasForeignKey("patientId");

                    b.Navigation("booking");

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.TimeSlot", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.DaySchedule", "daySchedule")
                        .WithMany("timeSlots")
                        .HasForeignKey("dayScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("daySchedule");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Users.Doctor", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Users.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("Vezeeta.Core.Models.Users.Doctor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.Specialization", "specialization")
                        .WithMany("Doctors")
                        .HasForeignKey("specializationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("specialization");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Users.Patient", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.Users.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("Vezeeta.Core.Models.Users.Patient", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Appointment", b =>
                {
                    b.Navigation("daySchedules");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.DaySchedule", b =>
                {
                    b.Navigation("timeSlots");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Specialization", b =>
                {
                    b.Navigation("Doctors");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Users.Doctor", b =>
                {
                    b.Navigation("appointments");

                    b.Navigation("bookings");

                    b.Navigation("feedbacks");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Users.Patient", b =>
                {
                    b.Navigation("bookings");

                    b.Navigation("feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
