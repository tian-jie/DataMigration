using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public class iDoctor_Data_SalesOrgChart : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual decimal? AREA_ID { get; set; }
        public virtual string AREA_NAME { get; set; }
        public virtual string AREA_CD { get; set; }
        public virtual string NSD_NAME { get; set; }
        public virtual string NSD_GLGL_EMPLY_ID { get; set; }
        public virtual string NSD_ACNT_NAME { get; set; }
        public virtual decimal? RGN_ID { get; set; }
        public virtual string RGN_NAME { get; set; }
        public virtual string RGN_CD { get; set; }
        public virtual string RSD_NAME { get; set; }
        public virtual string RSD_GLGL_EMPLY_ID { get; set; }
        public virtual string RSD_ACNT_NAME { get; set; }
        public virtual decimal? DSTRCT_ID { get; set; }
        public virtual string DSTRCT_NAME { get; set; }
        public virtual string DSTRCT_CD { get; set; }
        public virtual string DSM_NAME { get; set; }
        public virtual string DSM_GLGL_EMPLY_ID { get; set; }
        public virtual string DSM_ACNT_NAME { get; set; }
        public virtual decimal? TRTRY_ID { get; set; }
        public virtual string TRTRY_NAME { get; set; }
        public virtual string TRTRY_CD { get; set; }
        public virtual string REP_NAME { get; set; }
        public virtual string REP_GLGL_EMPLY_ID { get; set; }
        public virtual string REP_ACNT_NAME { get; set; }
        public virtual string CITY_NAME { get; set; }
        public virtual bool IsDeleted { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
        public virtual DateTime? ModifiedUtc { get; set; }
        public virtual string TA_RGN_NAME { get; set; }


        public virtual decimal? BU_ID { get; set; }
        public virtual string BU_NAME { get; set; }
        public virtual string BU_CD { get; set; }
        public virtual string BUHEAD_NAME { get; set; }
        public virtual string BUHEAD_GLGL_EMPLY_ID { get; set; }
        public virtual string BU_ACNT_NAME { get; set; }
    }
}





