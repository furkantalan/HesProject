﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HES.Migrations
{
    [DbContext(typeof(HESContext))]
    partial class HESContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-preview.1.22076.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OpenAddress1")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.ToTable("Addresses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 2,
                            DistrictId = 2,
                            Name = "Can İş",
                            OpenAddress1 = "Acıbadem meydan"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            DistrictId = 1,
                            Name = "Muhammed iş",
                            OpenAddress1 = "Acıbadem meydan"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 3,
                            DistrictId = 3,
                            Name = "Oğuz iş",
                            OpenAddress1 = "Acıbadem meydan"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 3,
                            DistrictId = 2,
                            Name = "Furkan iş",
                            OpenAddress1 = "Acıbadem meydan"
                        },
                        new
                        {
                            Id = 5,
                            CityId = 3,
                            DistrictId = 1,
                            Name = "Cafer iş",
                            OpenAddress1 = "Acıbadem meydan "
                        });
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Istanbul"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Bartın"
                        });
                });

            modelBuilder.Entity("District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Districts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Name = "Kecioren"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 1,
                            Name = "Mamak"
                        },
                        new
                        {
                            Id = 3,
                            CityId = 2,
                            Name = "Bagcılar"
                        },
                        new
                        {
                            Id = 4,
                            CityId = 2,
                            Name = "Besiktas"
                        });
                });

            modelBuilder.Entity("HES.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("BirtDay")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HESCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsSick")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AddressID");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressID = 1,
                            BirtDay = "1991",
                            FirstName = "Muhammed",
                            HESCode = "23232323",
                            IsSick = false,
                            LastName = "Bayram",
                            PhoneNumber = "1234",
                            gender = 0
                        },
                        new
                        {
                            Id = 2,
                            AddressID = 2,
                            BirtDay = "1994",
                            FirstName = "Galip Can",
                            HESCode = "5555555555",
                            IsSick = false,
                            LastName = "Karaarslan",
                            PhoneNumber = "155234",
                            gender = 0
                        });
                });

            modelBuilder.Entity("Report", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("ProfileID")
                        .HasColumnType("int");

                    b.Property<int>("ReporterID")
                        .HasColumnType("int");

                    b.Property<int>("TypeOfInfraction")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.HasIndex("DistrictId");

                    b.HasIndex("ProfileID");

                    b.HasIndex("ReporterID");

                    b.ToTable("Reports");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            AddressID = 1,
                            ProfileID = 1,
                            ReporterID = 1,
                            TypeOfInfraction = 0
                        },
                        new
                        {
                            ID = 2,
                            AddressID = 2,
                            ProfileID = 1,
                            ReporterID = 2,
                            TypeOfInfraction = 1
                        });
                });

            modelBuilder.Entity("Reporter", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProfileID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ProfileID");

                    b.ToTable("Reporters");
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany("Addresses")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("District", "District")
                        .WithMany("Addresses")
                        .HasForeignKey("DistrictId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("District");
                });

            modelBuilder.Entity("District", b =>
                {
                    b.HasOne("City", "City")
                        .WithMany("District")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("HES.Profile", b =>
                {
                    b.HasOne("Address", "Address")
                        .WithMany("Profiles")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Report", b =>
                {
                    b.HasOne("Address", "Address")
                        .WithMany("Reports")
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("District", null)
                        .WithMany("ReportList")
                        .HasForeignKey("DistrictId");

                    b.HasOne("HES.Profile", "Profile")
                        .WithMany("Reports")
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reporter", "Reporter")
                        .WithMany("Reports")
                        .HasForeignKey("ReporterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Profile");

                    b.Navigation("Reporter");
                });

            modelBuilder.Entity("Reporter", b =>
                {
                    b.HasOne("HES.Profile", "Profile")
                        .WithMany()
                        .HasForeignKey("ProfileID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profile");
                });

            modelBuilder.Entity("Address", b =>
                {
                    b.Navigation("Profiles");

                    b.Navigation("Reports");
                });

            modelBuilder.Entity("City", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("District");
                });

            modelBuilder.Entity("District", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("ReportList");
                });

            modelBuilder.Entity("HES.Profile", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("Reporter", b =>
                {
                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}
