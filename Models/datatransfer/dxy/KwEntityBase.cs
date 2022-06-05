using System;

namespace Infrastructure.Core
{
    public abstract class KwEntityBase<TKey> : EntityBase<TKey>
    {
        protected KwEntityBase() { }

        /// <summary>
        /// DXY系统中的ID，对应到我们系统中，显示为RID
        /// </summary>
        public virtual Int64 Rid { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreatedUtc { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public virtual DateTime UpdatedUtc { get; set; }
    }
}