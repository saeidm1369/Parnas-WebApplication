using Microsoft.EntityFrameworkCore;
using Parnas.Base;
using Parnas.Domain.Entities;
using Parnas.Infrastructure.Config;
using System;
using System.Collections.Generic;
using System.Text;
using static Parnas.Domain.Entities.Case;
using static Parnas.Domain.Entities.ComputerMonitor;
using static Parnas.Domain.Entities.Cooling;
using static Parnas.Domain.Entities.CPU;
using static Parnas.Domain.Entities.FanCase;
using static Parnas.Domain.Entities.Gaming;
using static Parnas.Domain.Entities.GraphicCard;
using static Parnas.Domain.Entities.HDD;
using static Parnas.Domain.Entities.MotherBoard;
using static Parnas.Domain.Entities.Power;
using static Parnas.Domain.Entities.Ram;
using static Parnas.Domain.Entities.SSD;

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
            modelBuilder.ApplyConfiguration(new AccessoryConfig());
            modelBuilder.ApplyConfiguration(new AccessoryImageConfig());
            modelBuilder.ApplyConfiguration(new CaseConfig());
            modelBuilder.ApplyConfiguration(new CaseImageConfig());
            modelBuilder.ApplyConfiguration(new ComputerMonitorConfig());
            modelBuilder.ApplyConfiguration(new ComputerMonitorImageConfigure());
            modelBuilder.ApplyConfiguration(new CoolingConfig());
            modelBuilder.ApplyConfiguration(new CoolingImageConfigure());
            modelBuilder.ApplyConfiguration(new CPUConfig());
            modelBuilder.ApplyConfiguration(new CPUImageConfig());
            modelBuilder.ApplyConfiguration(new FanCaseConfig());
            modelBuilder.ApplyConfiguration(new FanCaseImageConfig());
            modelBuilder.ApplyConfiguration(new GamingConfig());
            modelBuilder.ApplyConfiguration(new GamingImageConfig());
            modelBuilder.ApplyConfiguration(new GraphicCardConfig());
            modelBuilder.ApplyConfiguration(new GraphicCardImageConfig());
            modelBuilder.ApplyConfiguration(new HDDConfig());
            modelBuilder.ApplyConfiguration(new HDDImageConfig());
            modelBuilder.ApplyConfiguration(new MotherBoardConfig());
            modelBuilder.ApplyConfiguration(new MotherBoardImageConfig());
            modelBuilder.ApplyConfiguration(new PowerConfig());
            modelBuilder.ApplyConfiguration(new PowerImageConfig());
            modelBuilder.ApplyConfiguration(new RamConfig());
            modelBuilder.ApplyConfiguration(new RamImageConfig());
            modelBuilder.ApplyConfiguration(new SSDConfig());
            modelBuilder.ApplyConfiguration(new SSDImageConfig());
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
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<GraphicCardImagr> AccessoryImages { get; set; }
        public DbSet<CaseImage> CaseImages { get; set; }
        public DbSet<ComputerMonitorImage> ComputerMonitorImages { get; set; }
        public DbSet<CoolingImage> CoolingImages { get; set; }
        public DbSet<CPUImage> CPUImages { get; set; }
        public DbSet<FanCaseImage> FanCaseImages { get; set; }
        public DbSet<GamingImage> GamingImages { get; set; }
        public DbSet<GraphicCardImage> GraphicCardImages { get; set; }
        public DbSet<HDDImage> HDDImages { get; set; }
        public DbSet<MotherBoardImage> MotherBoardImages { get; set; }
        public DbSet<PowerImage> PowerImages { get; set; }
        public DbSet<RamImage> RamImages { get; set; }
        public DbSet<SSDImage> SSDImages { get; set; }











    }
}
