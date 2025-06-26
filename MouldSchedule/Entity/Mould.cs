using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouldSchedule.Entity
{
    public enum EnumScheduleType
    {
        /*
         “前后向内设定计划” → “从前往后设定计划” → ”从后往前设定计划“
          关键要素 资料受领、组装工程、计划出货
         */
        前后向内设定计划 = 1,
        从前往后设定计划 = 2,
        从后往前设定计划 = 3,
    }

    public class OrMould
    {
        public string? OrMouldId { get; set; }

        /// <summary>
        /// 计划开始时间
        /// </summary>           
        public DateTime? PlanStart { get; set; }

        /// <summary>
        /// 计划结束时间
        /// </summary>           
        public DateTime? PlanEnd { get; set; }

        /// <summary>
        /// 排产类型
        /// </summary>
        public EnumScheduleType? ScheduleType { get; set; }

        public List<OrPart> OrPart { get; set; }
    }

    public class OrPart
    {
        public string? OrPartId { get; set; }

        public List<OrProcess> OrProcess { get; set; }
    }

    public class OrProcess
    {
        public string? OrProcessId { get; set; }

        public List<OrEng> OrEng { get; set; }
    }

    public class OrEng
    {
        public string? OrEngId { get; set; }
    }

}
