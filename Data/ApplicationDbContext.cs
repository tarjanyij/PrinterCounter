using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Printercounter.Models;

namespace Printercounter.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Printercounter.Models.Printer> Printers { get; set; }
        public DbSet<Printercounter.Models.Counter> PrinterCounter { get; set; }
        public DbSet<Printercounter.Models.RepairReportList> RepairReportList { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<PrinterCounter>()
             //   .HasOne<Printers>()
              //  .WithMany()
               // .HasForeignKey(p => p.ID_Printer);
        }
    }
}
