using MouldSchedule.Share;

namespace MouldSchedule.OrSchedule.Entity
{
    /// <summary>
    /// 订单类
    /// </summary>
    public class OrMould
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public string? MouldId { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>           
        public DateTime? ScheduleStart { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>           
        public DateTime? ScheduleEnd { get; set; }

        /// <summary>
        /// 排产类型
        /// </summary>
        public EnumScheduleType? ScheduleType { get; set; }

        /// <summary>
        /// 订单中的部品
        /// </summary>
        public List<OrPart> OrPart { get; set; }
    }

}
