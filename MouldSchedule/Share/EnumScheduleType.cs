using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MouldSchedule.Share
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

}
