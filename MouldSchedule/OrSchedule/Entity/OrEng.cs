using MouldSchedule.Share;

namespace MouldSchedule.OrSchedule.Entity
{
    /// <summary>
    /// 工程
    /// </summary>
    public class OrEng
    {
        /// <summary>
        /// 工程Id
        /// </summary>
        public string? OrEngId { get; set; }

        /// <summary>
        /// 任务标识
        /// </summary>
        public EnumLoadFlg? LoadFlg { get; set; }

        /// <summary>
        /// 生产预计时间 小时
        /// </summary>           
        public decimal? EstimatedProductionTime { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>           
        public DateTime? PlanStart { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>           
        public DateTime? PlanEnd { get; set; }

        /// <summary>
        /// 是否冲突
        /// </summary>
        public bool? Conflict { get; set; }
    }

}
