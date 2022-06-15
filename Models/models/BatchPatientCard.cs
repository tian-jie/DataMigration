using Infrastructure.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace InnoCellence.Lccp.Data.Models
{
    [Table("batchpatientcard")]
    public class BatchPatientCard : EntityBase<int>
    {
        [Column("id")]
        public override int Id { get; set; }
        [Column("cardid")]
        public string Cardid { get; set; }
        [Column("hcpid")]
        public string HcpID { get; set; }
        [Column("birthday")]
        public string Birthday { get; set; } //ignore
        [Column("name")]
        public string name { get; set; } //ignore
        [Column("phone_number")]
        public string Phone_Number { get; set; } //ignore
        [Column("province")]
        public string Province { get; set; }
        [Column("city")]
        public string City { get; set; }
        [Column("county")]
        public string County { get; set; }
        [Column("disease_type")]
        public string Disease_Type { get; set; }
        [Column("check_date")]
        public string Check_Date { get; set; }
        [Column("enrollmenttime")]
        public string EnrollmentTime { get; set; }
        [Column("recommend_measuring_frequency")]
        public string Recommend_Measuring_Frequency { get; set; }
        [Column("recommend_measuring_period")]
        public string Recommend_Measuring_Period { get; set; }
    }
}