using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Live : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int live_id { get; set; }
        public virtual string topic { get; set; }
        public virtual string live_cover { get; set; }
        public virtual int live_time { get; set; }
        public virtual string live_url { get; set; }
        public virtual int created { get; set; }
        public virtual int updated { get; set; }
        public virtual string nurse_id { get; set; }
    }
}