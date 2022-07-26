﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoomReservation.DataAccess.Configurations;
using RoomReservation.Entities;
using RoomReservation.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.DataAccess.Concrete.EfCore
{
    public class RoomDbContext:IdentityDbContext<AppUser>
    {
        public RoomDbContext(DbContextOptions<RoomDbContext> options):base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=GOKTUG\MSSQLSERVER01;Database=RoomReservationDb;Trusted_Connection=True;MultipleActiveResultSets=true;");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<RoomBooking> RoomBookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RoomBookingConfigurations());
            base.OnModelCreating(modelBuilder);
        }
    }
}

