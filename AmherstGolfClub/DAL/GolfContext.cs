/*using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AmherstGolfClub.DAL
{
    public class GolfContext : DbContext
    {       
            public GolfContext() : base("DefaultConnection")
            {
            }

            public DbSet<Tournament> Tournaments { get; set; }
            public DbSet<Member> Members { get; set; }
            public DbSet<Instructor> Instructors { get; set; }
            public DbSet<Enrollment> Enrollments { get; set; }
            public DbSet<Course> Courses { get; set; }
            public DbSet<OfficeAssinment> OfficeAssignments { get; set; }
            public DbSet<Department> Departments { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                //base.OnModelCreating(modelBuilder);
                modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

                modelBuilder.Entity<Course>().HasMany(c => c.Instructors).WithMany(i => i.Courses).Map(t => t.MapLeftKey("CourseID").MapRightKey("InstructorID").ToTable("CourseInstructor"));
                //Above will create a junction (bridging) table called
                //CourseInstructor
                //with 2FK columns CourseID and InstructorID
                //and a composite PK on CourseID + InstructorID
            }

        }
    
}*/