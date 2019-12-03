using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Timesheets2.Models;

namespace Timesheets2.Data
{
    public class ApplicationDbContext : IdentityDbContext<CustomUser,CustomRole,string>
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Timesheet> Timesheets { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<DepartmentsProject>()
                .HasKey(dp => new { dp.ProjectId, dp.DepartmentId });

            builder.Entity<DepartmentsProject>()
                .HasOne(pt => pt.Project)
                .WithMany(p => p.RelatedDepartments)
                .HasForeignKey(pt => pt.ProjectId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<DepartmentsProject>()
                .HasOne(pt => pt.Department)
                .WithMany(d => d.Projects)
                .HasForeignKey(pt => pt.DepartmentId);



            base.OnModelCreating(builder);
            builder.Entity<UserRole>()
                .HasKey(dp => new { dp.UserId, dp.RoleId });

            builder.Entity<UserRole>()
                .HasOne(pt => pt.Role)
                .WithMany(p => p.Users)
                .HasForeignKey(pt => pt.RoleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<UserRole>()
                .HasOne(pt => pt.User)
                .WithMany(d => d.Roles)
                .HasForeignKey(pt => pt.UserId);


            //builder.Entity<TimesheetProject>()
            //    .HasKey(pt => new { pt.ProjectId, pt.TimesheetId });

            //builder.Entity<TimesheetProject>()
            //    .HasMany(cd => cd.Timesheet)
            //    .WithOne(p => p.Project).HasForeignKey()



            //builder.Entity<DepartmentOwnerProject>()
            //     .HasKey(dp => new { dp.ProjectId, dp.DepartmentId });

            //builder.Entity<DepartmentOwnerProject>()
            //    .HasOne(op=>op.Department)
            //    .WithMany(t=>t.)

            //builder.Entity<DepartmentsProject>()
            //    .HasOne(pt => pt.Project)
            //    .WithOne(d => d.ProjectOwner);

        }


    }
}
