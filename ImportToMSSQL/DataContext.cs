using Innocellence.DXYDataTransfer.Models;
using InnoCellence.Lccp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Import
{
    public class MsSqlContext : DbContext
    {
        public MsSqlContext()
        {

        }
        public MsSqlContext(DbContextOptions<MsSqlContext> options) : base(options)
        {

        }

        public DbSet<Lilly_DXY_Data_Cards> Lilly_DXY_Data_Cards { get; set; }
        public DbSet<PatientInfo> PatientInfo { get; set; }
        public DbSet<Log> Log { get; set; }
        public DbSet<ApiResult> ApiResult { get; set; }
        public DbSet<IdoctorDctr> IdoctorDctr { get; set; }
        public DbSet<Lilly_TC_Data_WechatPushImmediately> Lilly_TC_Data_WechatPushImmediately { get; set; }
        public DbSet<BGDataRaw> BGDataRaw { get; set; }
        public DbSet<BGDataRaw_Archive> BGDataRaw_Archive { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Lilly_DXY_Data_Cards>(entity =>
            //{
            //    entity.ToTable("Lilly_DXY_Data_Cards");
            //});

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(ConfigurationManager.ConnectionStrings[ConfigurationManager.AppSettings["dbName"]].ConnectionString);
        }

    }
}
