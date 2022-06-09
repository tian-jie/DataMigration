using Innocellence.DXYDataTransfer.Models;
using InnoCellence.Lccp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import
{
    public class PostgreSQLContext : DbContext
    {
        public PostgreSQLContext(DbContextOptions<PostgreSQLContext> options) : base(options)
        {

        }

        public DbSet<Lilly_DXY_Data_Cards> Lilly_DXY_Data_Cards { get; set; }
        public DbSet<PatientInfo> PatientInfo { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<ApiResult> ApiResult { get; set; }
        public DbSet<IdoctorDctr> IdoctorDctr { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.UseIdentityColumns();
            //modelBuilder.Entity<Lilly_DXY_Data_Cards>(entity =>
            //{
            //    entity.ToTable("Lilly_DXY_Data_Cards");
            //});

        }


    }
}
