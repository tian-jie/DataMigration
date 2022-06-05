using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class BatchPatientCard : EntityBase<int>
    {
        public override int Id { get; set; }
        public string Cardid { get; set; }
        public string HcpID { get; set; }
        public string Birthday { get; set; } //ignore
        public string name { get; set; } //ignore
        public string Phone_Number { get; set; } //ignore
        public string Province { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Disease_Type { get; set; }
        public string Check_Date { get; set; }
        public string EnrollmentTime { get; set; }
        public string Recommend_Measuring_Frequency { get; set; }
        public string Recommend_Measuring_Period { get; set; }
    }
}