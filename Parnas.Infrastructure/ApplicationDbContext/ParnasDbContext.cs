using Microsoft.EntityFrameworkCore;
using Parnas.Base;
using Parnas.Domain.Entities;
using Parnas.Infrastructure.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parnas.Infrastructure.ApplicationDbContext
{
    public class ParnasDbContext : DbContext
    {
        public ParnasDbContext(DbContextOptions<ParnasDbContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfig());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Accessories> Accessories { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<Cooling> Coolings { get; set; }
        public DbSet<CPU> CPUs { get; set; }
        public DbSet<FanCase> FanCases { get; set; }
        public DbSet<Gaming> Gamings { get; set; }
        public DbSet<GraphicCard> GraphicCards { get; set; }
        public DbSet<HDD> HDDs { get; set; }
        public DbSet<ComputerMonitor> Monitors { get; set; }
        public DbSet<MotherBoard> MotherBoards { get; set; }
        public DbSet<Power> Powers { get; set; }
        public DbSet<Ram> Rams { get; set; }
        public DbSet<SSD> SSDs { get; set; }
    }
}
