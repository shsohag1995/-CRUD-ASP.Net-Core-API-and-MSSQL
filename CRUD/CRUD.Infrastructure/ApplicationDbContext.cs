using CRUD.DomainModel.GeneralEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<UserInformation>().HasIndex(x => x.MobileNo).IsUnique();

        }

        public DbSet<User> Users { get; set; }
        
    }
}
