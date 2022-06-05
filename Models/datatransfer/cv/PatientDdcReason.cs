using Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_Patient_ddc_reason_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Sid { get; set; }
        public virtual Int64 Intervene_id { get; set; }
        public virtual int Type { get; set; }
        public virtual int Pid { get; set; }
        public virtual string Reason { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual string Imei { get; set; }
        public virtual string Record_id { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}