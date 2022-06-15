namespace Infrastructure.Core
{
    public class ExportResult { 
        /// <summary>
        /// 表名字
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 上传后的分页数量
        /// </summary>
        public int Pages { get; set; }

        /// <summary>
        /// 上传结果状态
        /// </summary>
        public ExportStatus Status { get; set; }
    }

    public enum ExportStatus
    {
        NotStarted = 1,
        Success = 1,
        Failed = 2,
    }
}
