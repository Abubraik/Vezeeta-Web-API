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
    [Migration("20231203144311_AdminSeed")]
    partial class AdminSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
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

                    b.HasData(
                        new
                        {
                            Id = "1",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "2",
                            Name = "Patient",
                            NormalizedName = "PATIENT"
                        },
                        new
                        {
                            Id = "3",
                            Name = "Doctor",
                            NormalizedName = "DOCTOR"
                        });
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("IdentityUser");

                    b.HasData(
                        new
                        {
                            Id = "8f22b0be-7bf7-49fd-9e46-ff1122a96761",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c5c4d91e-c98e-4500-9e74-80dc073fb60d",
                            Email = "admin@vezeeta.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            PasswordHash = "AQAAAAIAAYagAAAAENJvlwnIGoJHVzMI0Dre+zGUj4GM6Ag/9XcTgiogTYIn9HMvy+sWS11ar8sghj4b4A==",
                            PhoneNumber = "01066147039",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1fa6895c-1a87-427c-b287-0948d576dad3",
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        });
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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("price")
                        .HasPrecision(18, 2)
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

                    b.Property<int>("discountCodeId")
                        .HasColumnType("int");

                    b.Property<string>("doctorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("finalPrice")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("patientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("status")
                        .HasColumnType("smallint");

                    b.Property<int>("timeSlotId")
                        .HasColumnType("int");

                    b.HasKey("bookingId");

                    b.HasIndex("discountCodeId");

                    b.HasIndex("doctorId");

                    b.HasIndex("patientId");

                    b.HasIndex("timeSlotId")
                        .IsUnique();

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
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("isValid")
                        .HasColumnType("bit");

                    b.Property<int>("numberOfRequiredBookings")
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
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("patientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("feedbackId");

                    b.HasIndex("bookingId")
                        .IsUnique();

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

                    b.HasData(
                        new
                        {
                            specializationId = 1,
                            name = "Cardiology"
                        },
                        new
                        {
                            specializationId = 2,
                            name = "Neurology"
                        },
                        new
                        {
                            specializationId = 3,
                            name = "Oncology"
                        },
                        new
                        {
                            specializationId = 4,
                            name = "Pediatrics"
                        },
                        new
                        {
                            specializationId = 5,
                            name = "Gastroenterology"
                        },
                        new
                        {
                            specializationId = 6,
                            name = "Orthopedics"
                        },
                        new
                        {
                            specializationId = 7,
                            name = "Dermatology"
                        },
                        new
                        {
                            specializationId = 8,
                            name = "Endocrinology"
                        },
                        new
                        {
                            specializationId = 9,
                            name = "Ophthalmology"
                        },
                        new
                        {
                            specializationId = 10,
                            name = "Obstetrics and Gynecology"
                        },
                        new
                        {
                            specializationId = 11,
                            name = "Urology"
                        },
                        new
                        {
                            specializationId = 12,
                            name = "Psychiatry"
                        },
                        new
                        {
                            specializationId = 13,
                            name = "Anesthesiology"
                        },
                        new
                        {
                            specializationId = 14,
                            name = "Pulmonology"
                        },
                        new
                        {
                            specializationId = 15,
                            name = "Rheumatology"
                        },
                        new
                        {
                            specializationId = 16,
                            name = "Nephrology"
                        },
                        new
                        {
                            specializationId = 17,
                            name = "ENT (Ear, Nose, and Throat)"
                        },
                        new
                        {
                            specializationId = 18,
                            name = "Radiology"
                        },
                        new
                        {
                            specializationId = 19,
                            name = "Immunology"
                        },
                        new
                        {
                            specializationId = 20,
                            name = "Pathology"
                        },
                        new
                        {
                            specializationId = 21,
                            name = "General Surgery"
                        },
                        new
                        {
                            specializationId = 22,
                            name = "Plastic Surgery"
                        },
                        new
                        {
                            specializationId = 23,
                            name = "Neurosurgery"
                        },
                        new
                        {
                            specializationId = 24,
                            name = "Cardiothoracic Surgery"
                        },
                        new
                        {
                            specializationId = 25,
                            name = "Vascular Surgery"
                        },
                        new
                        {
                            specializationId = 26,
                            name = "Emergency Medicine"
                        },
                        new
                        {
                            specializationId = 27,
                            name = "Sports Medicine"
                        },
                        new
                        {
                            specializationId = 28,
                            name = "Geriatrics"
                        },
                        new
                        {
                            specializationId = 29,
                            name = "Hematology"
                        },
                        new
                        {
                            specializationId = 30,
                            name = "Infectious Disease"
                        });
                });

            modelBuilder.Entity("Vezeeta.Core.Models.TimeSlot", b =>
                {
                    b.Property<int>("tiemSlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("tiemSlotId"));

                    b.Property<int>("dayScheduleId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("endTime")
                        .HasColumnType("time");

                    b.Property<bool>("isBooked")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("startTime")
                        .HasColumnType("time");

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
                        .IsRequired()
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
                        .HasForeignKey("doctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.Booking", b =>
                {
                    b.HasOne("Vezeeta.Core.Models.DiscountCode", "discountCode")
                        .WithMany("bookings")
                        .HasForeignKey("discountCodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.Users.Doctor", "doctor")
                        .WithMany("bookings")
                        .HasForeignKey("doctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.Users.Patient", "patient")
                        .WithMany("bookings")
                        .HasForeignKey("patientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.TimeSlot", "timeSlot")
                        .WithOne()
                        .HasForeignKey("Vezeeta.Core.Models.Booking", "timeSlotId")
                        .OnDelete(DeleteBehavior.Restrict)
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
                        .WithOne("feedback")
                        .HasForeignKey("Vezeeta.Core.Models.Feedback", "bookingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.Users.Doctor", "doctor")
                        .WithMany("feedbacks")
                        .HasForeignKey("doctorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Vezeeta.Core.Models.Users.Patient", "patient")
                        .WithMany("feedbacks")
                        .HasForeignKey("patientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

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

            modelBuilder.Entity("Vezeeta.Core.Models.Booking", b =>
                {
                    b.Navigation("feedback");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.DaySchedule", b =>
                {
                    b.Navigation("timeSlots");
                });

            modelBuilder.Entity("Vezeeta.Core.Models.DiscountCode", b =>
                {
                    b.Navigation("bookings");
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