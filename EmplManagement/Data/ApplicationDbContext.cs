using EmplManagement.Model;
using Microsoft.EntityFrameworkCore;

namespace EmplManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmplID = 1,
                    EmplName = "John Doe",
                    DOB = DateOnly.Parse("1990-05-15"),
                    DOJ = DateOnly.Parse("2015-08-20"),
                    BloodGroup = "A+",
                    Phone = 1234567890,
                    ExperienceYears = 6,
                    CareerStartDate = DateOnly.Parse("2010-07-01"),
                    InterviewedDate = DateOnly.Parse("2015-08-10"),
                    PreviousCompany = "ABC Corp",
                    CTC = 750000.00
                },
                new Employee
                {
                    EmplID = 2,
                    EmplName = "Jane Smith",
                    DOB = DateOnly.Parse("1985-12-10"),
                    DOJ = DateOnly.Parse("2017-03-25"),
                    BloodGroup = "B-",
                    Phone = 9876543210,
                    ExperienceYears = 8,
                    CareerStartDate = DateOnly.Parse("2008-09-15"),
                    InterviewedDate = DateOnly.Parse("2017-03-20"),
                    PreviousCompany = "XYZ Inc",
                    CTC = 850000.00
                },
                new Employee
                {
                    EmplID = 3,
                    EmplName = "Michael Johnson",
                    DOB = DateOnly.Parse("1988-08-25"),
                    DOJ = DateOnly.Parse("2016-06-12"),
                    BloodGroup = "O+",
                    Phone = 5551234567,
                    ExperienceYears = 7,
                    CareerStartDate = DateOnly.Parse("2010-05-20"),
                    InterviewedDate = DateOnly.Parse("2016-06-05"),
                    PreviousCompany = "LMN Ltd",
                    CTC = 700000.00
                },
                new Employee
                {
                    EmplID = 4,
                    EmplName = "Emily Brown",
                    DOB = DateOnly.Parse("1992-02-28"),
                    DOJ = DateOnly.Parse("2019-11-03"),
                    BloodGroup = "AB-",
                    Phone = 9998887776,
                    ExperienceYears = 4,
                    CareerStartDate = DateOnly.Parse("2015-08-10"),
                    InterviewedDate = DateOnly.Parse("2019-10-25"),
                    PreviousCompany = "PQR Solutions",
                    CTC = 650000.00
                },
                new Employee
                {
                    EmplID = 5,
                    EmplName = "David Wilson",
                    DOB = DateOnly.Parse("1980-07-07"),
                    DOJ = DateOnly.Parse("2010-10-18"),
                    BloodGroup = "A-",
                    Phone = 1112223334,
                    ExperienceYears = 12,
                    CareerStartDate = DateOnly.Parse("2002-12-01"),
                    InterviewedDate = DateOnly.Parse("2010-10-10"),
                    PreviousCompany = "DEF Corporation",
                    CTC = 950000.00
                },
                new Employee
                {
                    EmplID = 6,
                    EmplName = "Jennifer Lee",
                    DOB = DateOnly.Parse("1995-10-12"),
                    DOJ = DateOnly.Parse("2020-04-30"),
                    BloodGroup = "B+",
                    Phone = 4445556665,
                    ExperienceYears = 3,
                    CareerStartDate = DateOnly.Parse("2018-01-20"),
                    InterviewedDate = DateOnly.Parse("2020-04-25"),
                    PreviousCompany = "GHI Tech",
                    CTC = 600000.00
                },
                new Employee
                {
                    EmplID = 7,
                    EmplName = "Daniel Garcia",
                    DOB = DateOnly.Parse("1983-03-20"),
                    DOJ = DateOnly.Parse("2014-12-05"),
                    BloodGroup = "AB+",
                    Phone = 7778889998,
                    ExperienceYears = 9,
                    CareerStartDate = DateOnly.Parse("2007-06-15"),
                    InterviewedDate = DateOnly.Parse("2014-12-01"),
                    PreviousCompany = "JKL Innovations",
                    CTC = 800000.00
                },
                new Employee
                {
                    EmplID = 8,
                    EmplName = "Sarah Martinez",
                    DOB = DateOnly.Parse("1991-09-18"),
                    DOJ = DateOnly.Parse("2018-08-15"),
                    BloodGroup = "O-",
                    Phone = 2223334447,
                    ExperienceYears = 5,
                    CareerStartDate = DateOnly.Parse("2013-03-10"),
                    InterviewedDate = DateOnly.Parse("2018-08-10"),
                    PreviousCompany = "MNO Enterprises",
                    CTC = 720000.00
                },
                new Employee
                {
                    EmplID = 9,
                    EmplName = "Christopher Taylor",
                    DOB = DateOnly.Parse("1987-06-05"),
                    DOJ = DateOnly.Parse("2011-05-20"),
                    BloodGroup = "B+",
                    Phone = 6667778889,
                    ExperienceYears = 10,
                    CareerStartDate = DateOnly.Parse("2009-08-01"),
                    InterviewedDate = DateOnly.Parse("2011-05-15"),
                    PreviousCompany = "STU Solutions",
                    CTC = 900000.00
                },
                new Employee
                {
                    EmplID = 10,
                    EmplName = "Jessica Rodriguez",
                    DOB = DateOnly.Parse("1994-11-30"),
                    DOJ = DateOnly.Parse("2021-02-10"),
                    BloodGroup = "A-",
                    Phone = 3334445556,
                    ExperienceYears = 2,
                    CareerStartDate = DateOnly.Parse("2019-07-05"),
                    InterviewedDate = DateOnly.Parse("2021-02-05"),
                    PreviousCompany = "VWX Technologies",
                    CTC = 620000.00
                },
                new Employee
                {
                    EmplID = 11,
                    EmplName = "Kevin Thomas",
                    DOB = DateOnly.Parse("1989-04-22"),
                    DOJ = DateOnly.Parse("2017-09-08"),
                    BloodGroup = "AB-",
                    Phone = 8889990001,
                    ExperienceYears = 6,
                    CareerStartDate = DateOnly.Parse("2012-11-20"),
                    InterviewedDate = DateOnly.Parse("2017-09-03"),
                    PreviousCompany = "YZA Corporation",
                    CTC = 780000.00
                },
                new Employee
                {
                    EmplID = 12,
                    EmplName = "Amanda Clark",
                    DOB = DateOnly.Parse("1984-01-17"),
                    DOJ = DateOnly.Parse("2013-07-22"),
                    BloodGroup = "O+",
                    Phone = 4445556667,
                    ExperienceYears = 8,
                    CareerStartDate = DateOnly.Parse("2006-05-10"),
                    InterviewedDate = DateOnly.Parse("2013-07-15"),
                    PreviousCompany = "BCD Solutions",
                    CTC = 850000.00
                },
                new Employee
                {
                    EmplID = 13,
                    EmplName = "James Lewis",
                    DOB = DateOnly.Parse("1990-08-08"),
                    DOJ = DateOnly.Parse("2016-03-15"),
                    BloodGroup = "B-",
                    Phone = 1112223334,
                    ExperienceYears = 7,
                    CareerStartDate = DateOnly.Parse("2010-10-05"),
                    InterviewedDate = DateOnly.Parse("2016-03-10"),
                    PreviousCompany = "EFG Inc",
                    CTC = 700000.00
                },
                new Employee
                {
                    EmplID = 14,
                    EmplName = "Melissa Walker",
                    DOB = DateOnly.Parse("1986-05-25"),
                    DOJ = DateOnly.Parse("2015-01-28"),
                    BloodGroup = "AB+",
                    Phone = 5556667778,
                    ExperienceYears = 9,
                    CareerStartDate = DateOnly.Parse("2009-08-20"),
                    InterviewedDate = DateOnly.Parse("2015-01-25"),
                    PreviousCompany = "HIJ Tech",
                    CTC = 820000.00
                },
                new Employee
                {
                    EmplID = 15,
                    EmplName = "Matthew Hall",
                    DOB = DateOnly.Parse("1993-12-03"),
                    DOJ = DateOnly.Parse("2020-10-05"),
                    BloodGroup = "A+",
                    Phone = 9998887776,
                    ExperienceYears = 4,
                    CareerStartDate = DateOnly.Parse("2016-07-15"),
                    InterviewedDate = DateOnly.Parse("2020-10-01"),
                    PreviousCompany = "KLM Enterprises",
                    CTC = 670000.00
                },
                new Employee
                {
                    EmplID = 16,
                    EmplName = "Laura White",
                    DOB = DateOnly.Parse("1981-06-15"),
                    DOJ = DateOnly.Parse("2011-11-20"),
                    BloodGroup = "O-",
                    Phone = 3334445556,
                    ExperienceYears = 11,
                    CareerStartDate = DateOnly.Parse("2003-09-10"),
                    InterviewedDate = DateOnly.Parse("2011-11-15"),
                    PreviousCompany = "NOP Corporation",
                    CTC = 920000.00
                },
                new Employee
                {
                    EmplID = 17,
                    EmplName = "Ryan Perez",
                    DOB = DateOnly.Parse("1996-09-28"),
                    DOJ = DateOnly.Parse("2021-07-15"),
                    BloodGroup = "B+",
                    Phone = 7778889992,
                    ExperienceYears = 3,
                    CareerStartDate = DateOnly.Parse("2019-04-05"),
                    InterviewedDate = DateOnly.Parse("2021-07-10"),
                    PreviousCompany = "QRS Solutions",
                    CTC = 640000.00
                },
                new Employee
                {
                    EmplID = 18,
                    EmplName = "Taylor Scott",
                    DOB = DateOnly.Parse("1982-04-10"),
                    DOJ = DateOnly.Parse("2014-05-02"),
                    BloodGroup = "A-",
                    Phone = 4445556667,
                    ExperienceYears = 10,
                    CareerStartDate = DateOnly.Parse("2008-06-25"),
                    InterviewedDate = DateOnly.Parse("2014-04-25"),
                    PreviousCompany = "TUV Inc",
                    CTC = 880000.00
                },
                new Employee
                {
                    EmplID = 19,
                    EmplName = "Rachel Turner",
                    DOB = DateOnly.Parse("1988-11-20"),
                    DOJ = DateOnly.Parse("2018-12-12"),
                    BloodGroup = "AB-",
                    Phone = 5556667778,
                    ExperienceYears = 7,
                    CareerStartDate = DateOnly.Parse("2012-10-15"),
                    InterviewedDate = DateOnly.Parse("2018-12-08"),
                    PreviousCompany = "WXY Corporation",
                    CTC = 730000.00
                },
                new Employee
                {
                    EmplID = 20,
                    EmplName = "Brandon Baker",
                    DOB = DateOnly.Parse("1992-07-02"),
                    DOJ = DateOnly.Parse("2019-04-18"),
                    BloodGroup = "O+",
                    Phone = 1112223334,
                    ExperienceYears = 5,
                    CareerStartDate = DateOnly.Parse("2014-03-10"),
                    InterviewedDate = DateOnly.Parse("2019-04-15"),
                    PreviousCompany = "ZAB Tech",
                    CTC = 790000.00
                }

                );
        }
    }
}
