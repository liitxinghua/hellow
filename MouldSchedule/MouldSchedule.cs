using Google.OrTools.LinearSolver;
using MouldSchedule.OrSchedule.Entity;
using static Google.OrTools.ConstraintSolver.RoutingModel.ResourceGroup;

namespace MouldSchedule
{
    public class MouldSchedule
    {
        OrMould orMould;
        public MouldSchedule(OrMould orMould)
        {
            this.orMould = orMould;
        }

        public void Solve()
        {
            /*
             技术要求：c# ，组件要求：OR-TOOL，设计一套APS排程系统。
             一个模具订单有多个部品，部品类型分为：设计类部品（整体的设计工作）、编程类部品、组装类部品（整体的组装工作）；每个部品中有多个制造工艺，每个工艺下有多个工程。
             整体生产工艺流程为：设计、部品、组装
             部品的生产工艺流程为：设计、编程、制造、组装
             制造细分流程：加工人、加工设备、检查
             加工设备分：电极加工、粗加工、精加工、线割加工、放电加工
             现在需要利用c#设计一套排产系统，支持各个工程项目从前往后排，从后往前排。该如何实现这套逻辑
             */



        }
    }
}
