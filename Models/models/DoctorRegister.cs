
using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class DoctorRegister : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string FAMILY_NAME { get; set; }
        public virtual string GIVEN_NAME { get; set; }
        public virtual string NAME { get; set; }
        public virtual string PHONE { get; set; }
        public virtual string EMAIL { get; set; }
        public virtual decimal? PROVINCE_ID { get; set; }
        public virtual string PROVINCE_NAME { get; set; }
        public virtual decimal? CITY_ID { get; set; }
        public virtual string CITY_NAME { get; set; }
        public virtual string CSTMR_NAME { get; set; }
        public virtual string DEPT_NAME { get; set; }
        public virtual string FIELD { get; set; }
        public virtual string TITTLE { get; set; }
        public virtual string WAY { get; set; }
        public virtual string COMMENT { get; set; }
        public virtual string COMMENT2 { get; set; }
        public virtual DateTime? REGISTERTIME { get; set; }
        public virtual bool IsDeleted { get; set; }
    }
}