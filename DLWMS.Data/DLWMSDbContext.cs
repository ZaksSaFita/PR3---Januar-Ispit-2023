﻿using DLWMS.Data.ispitIB220116;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLWMS.Data
{
    public class DLWMSDbContext : DbContext
    {
        private string dbPutanja;

	   public DLWMSDbContext()
	   {
            dbPutanja = ConfigurationManager.
                ConnectionStrings["DLWMSPutanja"].ConnectionString;
	   }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(dbPutanja);
        }
       
        public DbSet<Student> Studenti { get; set; }
        public DbSet<Spol> Spolovi { get; set; }

        public DbSet<PredmetIB220116> Predmeti { get; set; }
        public DbSet<StudentiPredmetiIB220116> StudentiPredmeti { get; set; }

        public DbSet<StudentiUvjerenjaIB220116> StudentiUvjerenjaIB220116 { get; set; }

        
    }
}
