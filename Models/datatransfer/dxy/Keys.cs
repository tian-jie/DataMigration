using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Keys : EntityBase<int>
    {
        public override int Id { get; set; }
        public virtual string PublicKey { get; set; }
        public virtual string PrivateKey { get; set; }
        public virtual string Guid { get; set; }
        public virtual DateTime? CreatedUtc { get; set; }
    }
}