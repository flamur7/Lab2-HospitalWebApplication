﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Final___Lab2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Receptionist> Receptionists { get; set; }
        public DbSet<Technical> Technicals { get; set; }

        public virtual DbSet<Pacient> Pacients { get; set; }
        public virtual DbSet<Terapi>Terapis { get; set; }
        public virtual DbSet<Faktura> Fakturas { get; set; }
        public virtual DbSet<Faturimi> Faturimis { get; set; }
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Orari> Oraris { get; set; }
    }
}
