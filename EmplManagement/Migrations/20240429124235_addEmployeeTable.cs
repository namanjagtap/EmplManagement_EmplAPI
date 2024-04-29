using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmplManagement.Migrations
{
    /// <inheritdoc />
    public partial class addEmployeeTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmplID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmplName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOB = table.Column<DateOnly>(type: "date", nullable: false),
                    DOJ = table.Column<DateOnly>(type: "date", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<long>(type: "bigint", nullable: false),
                    ExperienceYears = table.Column<int>(type: "int", nullable: false),
                    CareerStartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    InterviewedDate = table.Column<DateOnly>(type: "date", nullable: false),
                    PreviousCompany = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CTC = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmplID);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmplID", "BloodGroup", "CTC", "CareerStartDate", "DOB", "DOJ", "EmplName", "ExperienceYears", "InterviewedDate", "Phone", "PreviousCompany" },
                values: new object[,]
                {
                    { 1, "A+", 750000.0, new DateOnly(2010, 7, 1), new DateOnly(1990, 5, 15), new DateOnly(2015, 8, 20), "John Doe", 6, new DateOnly(2015, 8, 10), 1234567890L, "ABC Corp" },
                    { 2, "B-", 850000.0, new DateOnly(2008, 9, 15), new DateOnly(1985, 12, 10), new DateOnly(2017, 3, 25), "Jane Smith", 8, new DateOnly(2017, 3, 20), 9876543210L, "XYZ Inc" },
                    { 3, "O+", 700000.0, new DateOnly(2010, 5, 20), new DateOnly(1988, 8, 25), new DateOnly(2016, 6, 12), "Michael Johnson", 7, new DateOnly(2016, 6, 5), 5551234567L, "LMN Ltd" },
                    { 4, "AB-", 650000.0, new DateOnly(2015, 8, 10), new DateOnly(1992, 2, 28), new DateOnly(2019, 11, 3), "Emily Brown", 4, new DateOnly(2019, 10, 25), 9998887776L, "PQR Solutions" },
                    { 5, "A-", 950000.0, new DateOnly(2002, 12, 1), new DateOnly(1980, 7, 7), new DateOnly(2010, 10, 18), "David Wilson", 12, new DateOnly(2010, 10, 10), 1112223334L, "DEF Corporation" },
                    { 6, "B+", 600000.0, new DateOnly(2018, 1, 20), new DateOnly(1995, 10, 12), new DateOnly(2020, 4, 30), "Jennifer Lee", 3, new DateOnly(2020, 4, 25), 4445556665L, "GHI Tech" },
                    { 7, "AB+", 800000.0, new DateOnly(2007, 6, 15), new DateOnly(1983, 3, 20), new DateOnly(2014, 12, 5), "Daniel Garcia", 9, new DateOnly(2014, 12, 1), 7778889998L, "JKL Innovations" },
                    { 8, "O-", 720000.0, new DateOnly(2013, 3, 10), new DateOnly(1991, 9, 18), new DateOnly(2018, 8, 15), "Sarah Martinez", 5, new DateOnly(2018, 8, 10), 2223334447L, "MNO Enterprises" },
                    { 9, "B+", 900000.0, new DateOnly(2009, 8, 1), new DateOnly(1987, 6, 5), new DateOnly(2011, 5, 20), "Christopher Taylor", 10, new DateOnly(2011, 5, 15), 6667778889L, "STU Solutions" },
                    { 10, "A-", 620000.0, new DateOnly(2019, 7, 5), new DateOnly(1994, 11, 30), new DateOnly(2021, 2, 10), "Jessica Rodriguez", 2, new DateOnly(2021, 2, 5), 3334445556L, "VWX Technologies" },
                    { 11, "AB-", 780000.0, new DateOnly(2012, 11, 20), new DateOnly(1989, 4, 22), new DateOnly(2017, 9, 8), "Kevin Thomas", 6, new DateOnly(2017, 9, 3), 8889990001L, "YZA Corporation" },
                    { 12, "O+", 850000.0, new DateOnly(2006, 5, 10), new DateOnly(1984, 1, 17), new DateOnly(2013, 7, 22), "Amanda Clark", 8, new DateOnly(2013, 7, 15), 4445556667L, "BCD Solutions" },
                    { 13, "B-", 700000.0, new DateOnly(2010, 10, 5), new DateOnly(1990, 8, 8), new DateOnly(2016, 3, 15), "James Lewis", 7, new DateOnly(2016, 3, 10), 1112223334L, "EFG Inc" },
                    { 14, "AB+", 820000.0, new DateOnly(2009, 8, 20), new DateOnly(1986, 5, 25), new DateOnly(2015, 1, 28), "Melissa Walker", 9, new DateOnly(2015, 1, 25), 5556667778L, "HIJ Tech" },
                    { 15, "A+", 670000.0, new DateOnly(2016, 7, 15), new DateOnly(1993, 12, 3), new DateOnly(2020, 10, 5), "Matthew Hall", 4, new DateOnly(2020, 10, 1), 9998887776L, "KLM Enterprises" },
                    { 16, "O-", 920000.0, new DateOnly(2003, 9, 10), new DateOnly(1981, 6, 15), new DateOnly(2011, 11, 20), "Laura White", 11, new DateOnly(2011, 11, 15), 3334445556L, "NOP Corporation" },
                    { 17, "B+", 640000.0, new DateOnly(2019, 4, 5), new DateOnly(1996, 9, 28), new DateOnly(2021, 7, 15), "Ryan Perez", 3, new DateOnly(2021, 7, 10), 7778889992L, "QRS Solutions" },
                    { 18, "A-", 880000.0, new DateOnly(2008, 6, 25), new DateOnly(1982, 4, 10), new DateOnly(2014, 5, 2), "Taylor Scott", 10, new DateOnly(2014, 4, 25), 4445556667L, "TUV Inc" },
                    { 19, "AB-", 730000.0, new DateOnly(2012, 10, 15), new DateOnly(1988, 11, 20), new DateOnly(2018, 12, 12), "Rachel Turner", 7, new DateOnly(2018, 12, 8), 5556667778L, "WXY Corporation" },
                    { 20, "O+", 790000.0, new DateOnly(2014, 3, 10), new DateOnly(1992, 7, 2), new DateOnly(2019, 4, 18), "Brandon Baker", 5, new DateOnly(2019, 4, 15), 1112223334L, "ZAB Tech" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
