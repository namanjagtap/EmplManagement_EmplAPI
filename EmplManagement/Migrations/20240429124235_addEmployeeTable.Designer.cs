﻿// <auto-generated />
using System;
using EmplManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EmplManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429124235_addEmployeeTable")]
    partial class addEmployeeTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmplManagement.Model.Employee", b =>
                {
                    b.Property<int>("EmplID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmplID"));

                    b.Property<string>("BloodGroup")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CTC")
                        .HasColumnType("float");

                    b.Property<DateOnly>("CareerStartDate")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DOB")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DOJ")
                        .HasColumnType("date");

                    b.Property<string>("EmplName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ExperienceYears")
                        .HasColumnType("int");

                    b.Property<DateOnly>("InterviewedDate")
                        .HasColumnType("date");

                    b.Property<long>("Phone")
                        .HasColumnType("bigint");

                    b.Property<string>("PreviousCompany")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmplID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmplID = 1,
                            BloodGroup = "A+",
                            CTC = 750000.0,
                            CareerStartDate = new DateOnly(2010, 7, 1),
                            DOB = new DateOnly(1990, 5, 15),
                            DOJ = new DateOnly(2015, 8, 20),
                            EmplName = "John Doe",
                            ExperienceYears = 6,
                            InterviewedDate = new DateOnly(2015, 8, 10),
                            Phone = 1234567890L,
                            PreviousCompany = "ABC Corp"
                        },
                        new
                        {
                            EmplID = 2,
                            BloodGroup = "B-",
                            CTC = 850000.0,
                            CareerStartDate = new DateOnly(2008, 9, 15),
                            DOB = new DateOnly(1985, 12, 10),
                            DOJ = new DateOnly(2017, 3, 25),
                            EmplName = "Jane Smith",
                            ExperienceYears = 8,
                            InterviewedDate = new DateOnly(2017, 3, 20),
                            Phone = 9876543210L,
                            PreviousCompany = "XYZ Inc"
                        },
                        new
                        {
                            EmplID = 3,
                            BloodGroup = "O+",
                            CTC = 700000.0,
                            CareerStartDate = new DateOnly(2010, 5, 20),
                            DOB = new DateOnly(1988, 8, 25),
                            DOJ = new DateOnly(2016, 6, 12),
                            EmplName = "Michael Johnson",
                            ExperienceYears = 7,
                            InterviewedDate = new DateOnly(2016, 6, 5),
                            Phone = 5551234567L,
                            PreviousCompany = "LMN Ltd"
                        },
                        new
                        {
                            EmplID = 4,
                            BloodGroup = "AB-",
                            CTC = 650000.0,
                            CareerStartDate = new DateOnly(2015, 8, 10),
                            DOB = new DateOnly(1992, 2, 28),
                            DOJ = new DateOnly(2019, 11, 3),
                            EmplName = "Emily Brown",
                            ExperienceYears = 4,
                            InterviewedDate = new DateOnly(2019, 10, 25),
                            Phone = 9998887776L,
                            PreviousCompany = "PQR Solutions"
                        },
                        new
                        {
                            EmplID = 5,
                            BloodGroup = "A-",
                            CTC = 950000.0,
                            CareerStartDate = new DateOnly(2002, 12, 1),
                            DOB = new DateOnly(1980, 7, 7),
                            DOJ = new DateOnly(2010, 10, 18),
                            EmplName = "David Wilson",
                            ExperienceYears = 12,
                            InterviewedDate = new DateOnly(2010, 10, 10),
                            Phone = 1112223334L,
                            PreviousCompany = "DEF Corporation"
                        },
                        new
                        {
                            EmplID = 6,
                            BloodGroup = "B+",
                            CTC = 600000.0,
                            CareerStartDate = new DateOnly(2018, 1, 20),
                            DOB = new DateOnly(1995, 10, 12),
                            DOJ = new DateOnly(2020, 4, 30),
                            EmplName = "Jennifer Lee",
                            ExperienceYears = 3,
                            InterviewedDate = new DateOnly(2020, 4, 25),
                            Phone = 4445556665L,
                            PreviousCompany = "GHI Tech"
                        },
                        new
                        {
                            EmplID = 7,
                            BloodGroup = "AB+",
                            CTC = 800000.0,
                            CareerStartDate = new DateOnly(2007, 6, 15),
                            DOB = new DateOnly(1983, 3, 20),
                            DOJ = new DateOnly(2014, 12, 5),
                            EmplName = "Daniel Garcia",
                            ExperienceYears = 9,
                            InterviewedDate = new DateOnly(2014, 12, 1),
                            Phone = 7778889998L,
                            PreviousCompany = "JKL Innovations"
                        },
                        new
                        {
                            EmplID = 8,
                            BloodGroup = "O-",
                            CTC = 720000.0,
                            CareerStartDate = new DateOnly(2013, 3, 10),
                            DOB = new DateOnly(1991, 9, 18),
                            DOJ = new DateOnly(2018, 8, 15),
                            EmplName = "Sarah Martinez",
                            ExperienceYears = 5,
                            InterviewedDate = new DateOnly(2018, 8, 10),
                            Phone = 2223334447L,
                            PreviousCompany = "MNO Enterprises"
                        },
                        new
                        {
                            EmplID = 9,
                            BloodGroup = "B+",
                            CTC = 900000.0,
                            CareerStartDate = new DateOnly(2009, 8, 1),
                            DOB = new DateOnly(1987, 6, 5),
                            DOJ = new DateOnly(2011, 5, 20),
                            EmplName = "Christopher Taylor",
                            ExperienceYears = 10,
                            InterviewedDate = new DateOnly(2011, 5, 15),
                            Phone = 6667778889L,
                            PreviousCompany = "STU Solutions"
                        },
                        new
                        {
                            EmplID = 10,
                            BloodGroup = "A-",
                            CTC = 620000.0,
                            CareerStartDate = new DateOnly(2019, 7, 5),
                            DOB = new DateOnly(1994, 11, 30),
                            DOJ = new DateOnly(2021, 2, 10),
                            EmplName = "Jessica Rodriguez",
                            ExperienceYears = 2,
                            InterviewedDate = new DateOnly(2021, 2, 5),
                            Phone = 3334445556L,
                            PreviousCompany = "VWX Technologies"
                        },
                        new
                        {
                            EmplID = 11,
                            BloodGroup = "AB-",
                            CTC = 780000.0,
                            CareerStartDate = new DateOnly(2012, 11, 20),
                            DOB = new DateOnly(1989, 4, 22),
                            DOJ = new DateOnly(2017, 9, 8),
                            EmplName = "Kevin Thomas",
                            ExperienceYears = 6,
                            InterviewedDate = new DateOnly(2017, 9, 3),
                            Phone = 8889990001L,
                            PreviousCompany = "YZA Corporation"
                        },
                        new
                        {
                            EmplID = 12,
                            BloodGroup = "O+",
                            CTC = 850000.0,
                            CareerStartDate = new DateOnly(2006, 5, 10),
                            DOB = new DateOnly(1984, 1, 17),
                            DOJ = new DateOnly(2013, 7, 22),
                            EmplName = "Amanda Clark",
                            ExperienceYears = 8,
                            InterviewedDate = new DateOnly(2013, 7, 15),
                            Phone = 4445556667L,
                            PreviousCompany = "BCD Solutions"
                        },
                        new
                        {
                            EmplID = 13,
                            BloodGroup = "B-",
                            CTC = 700000.0,
                            CareerStartDate = new DateOnly(2010, 10, 5),
                            DOB = new DateOnly(1990, 8, 8),
                            DOJ = new DateOnly(2016, 3, 15),
                            EmplName = "James Lewis",
                            ExperienceYears = 7,
                            InterviewedDate = new DateOnly(2016, 3, 10),
                            Phone = 1112223334L,
                            PreviousCompany = "EFG Inc"
                        },
                        new
                        {
                            EmplID = 14,
                            BloodGroup = "AB+",
                            CTC = 820000.0,
                            CareerStartDate = new DateOnly(2009, 8, 20),
                            DOB = new DateOnly(1986, 5, 25),
                            DOJ = new DateOnly(2015, 1, 28),
                            EmplName = "Melissa Walker",
                            ExperienceYears = 9,
                            InterviewedDate = new DateOnly(2015, 1, 25),
                            Phone = 5556667778L,
                            PreviousCompany = "HIJ Tech"
                        },
                        new
                        {
                            EmplID = 15,
                            BloodGroup = "A+",
                            CTC = 670000.0,
                            CareerStartDate = new DateOnly(2016, 7, 15),
                            DOB = new DateOnly(1993, 12, 3),
                            DOJ = new DateOnly(2020, 10, 5),
                            EmplName = "Matthew Hall",
                            ExperienceYears = 4,
                            InterviewedDate = new DateOnly(2020, 10, 1),
                            Phone = 9998887776L,
                            PreviousCompany = "KLM Enterprises"
                        },
                        new
                        {
                            EmplID = 16,
                            BloodGroup = "O-",
                            CTC = 920000.0,
                            CareerStartDate = new DateOnly(2003, 9, 10),
                            DOB = new DateOnly(1981, 6, 15),
                            DOJ = new DateOnly(2011, 11, 20),
                            EmplName = "Laura White",
                            ExperienceYears = 11,
                            InterviewedDate = new DateOnly(2011, 11, 15),
                            Phone = 3334445556L,
                            PreviousCompany = "NOP Corporation"
                        },
                        new
                        {
                            EmplID = 17,
                            BloodGroup = "B+",
                            CTC = 640000.0,
                            CareerStartDate = new DateOnly(2019, 4, 5),
                            DOB = new DateOnly(1996, 9, 28),
                            DOJ = new DateOnly(2021, 7, 15),
                            EmplName = "Ryan Perez",
                            ExperienceYears = 3,
                            InterviewedDate = new DateOnly(2021, 7, 10),
                            Phone = 7778889992L,
                            PreviousCompany = "QRS Solutions"
                        },
                        new
                        {
                            EmplID = 18,
                            BloodGroup = "A-",
                            CTC = 880000.0,
                            CareerStartDate = new DateOnly(2008, 6, 25),
                            DOB = new DateOnly(1982, 4, 10),
                            DOJ = new DateOnly(2014, 5, 2),
                            EmplName = "Taylor Scott",
                            ExperienceYears = 10,
                            InterviewedDate = new DateOnly(2014, 4, 25),
                            Phone = 4445556667L,
                            PreviousCompany = "TUV Inc"
                        },
                        new
                        {
                            EmplID = 19,
                            BloodGroup = "AB-",
                            CTC = 730000.0,
                            CareerStartDate = new DateOnly(2012, 10, 15),
                            DOB = new DateOnly(1988, 11, 20),
                            DOJ = new DateOnly(2018, 12, 12),
                            EmplName = "Rachel Turner",
                            ExperienceYears = 7,
                            InterviewedDate = new DateOnly(2018, 12, 8),
                            Phone = 5556667778L,
                            PreviousCompany = "WXY Corporation"
                        },
                        new
                        {
                            EmplID = 20,
                            BloodGroup = "O+",
                            CTC = 790000.0,
                            CareerStartDate = new DateOnly(2014, 3, 10),
                            DOB = new DateOnly(1992, 7, 2),
                            DOJ = new DateOnly(2019, 4, 18),
                            EmplName = "Brandon Baker",
                            ExperienceYears = 5,
                            InterviewedDate = new DateOnly(2019, 4, 15),
                            Phone = 1112223334L,
                            PreviousCompany = "ZAB Tech"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
