using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_QuesRule_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Qid { get; set; }
        public virtual Int64 Tid { get; set; }
        public virtual string Con { get; set; }
        public virtual string Rule { get; set; }
        public virtual string Con_html { get; set; }
        public virtual string Out_code { get; set; }
        public virtual Int64 Out_qid { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}