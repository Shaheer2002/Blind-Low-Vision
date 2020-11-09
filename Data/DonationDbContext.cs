using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AuthSystem.Models;

namespace AuthSystem.Data
{
    public class DonationDbContext : DbContext
    {
        public DonationDbContext(DbContextOptions<DonationDbContext> options)
                : base(options)
        {
        }
        public virtual DbSet<Challenge> Challenges { get; set; }
        public virtual DbSet<Donation> Donations { get; set; }
    }
}
