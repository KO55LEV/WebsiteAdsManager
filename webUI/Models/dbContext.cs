using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace webUI.Models
{
    public class dbContext : DbContext
    {
        public IConfigurationRoot _config { get; set; }
        public dbContext(IConfigurationRoot config,DbContextOptions options) 
            : base(options)
        {
            _config = config;
        }
        
        public DbSet<ServiceAd> ServiceAds { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:dbConnection"]);
        }
    }
}
