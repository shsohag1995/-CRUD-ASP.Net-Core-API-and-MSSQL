﻿using CRUD.Data.SeedData;
using CRUD.DomainModel.GeneralEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            string c = Directory.GetCurrentDirectory();
            IConfigurationRoot configuration =
            new ConfigurationBuilder().SetBasePath(c).AddJsonFile("appsettings.json").Build();
            string connectionStringIs = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionStringIs);

        }
        
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    //modelBuilder.Entity<UserInformation>().HasIndex(x => x.MobileNo).IsUnique();

        //}
        #region SeedData
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data
            AppDbInitializer appDbInitializer = new AppDbInitializer();
             appDbInitializer.SeedingData(modelBuilder);

        }
        #endregion

        /* GeneralEntity Group*/
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<GeneralType> GeneralTypes { get; set; }
        public DbSet<UserAddressType> UserAddressTypes { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }
        public DbSet<UserEmail> UserEmails { get; set; }
        public DbSet<UserPhone> UserPhones { get; set; }

        /* GeneralEntity Group End*/
    }
}
