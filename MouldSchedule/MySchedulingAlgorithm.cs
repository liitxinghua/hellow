using Google.OrTools.LinearSolver;
using MouldSchedule.Entity;
using static Google.OrTools.ConstraintSolver.RoutingModel.ResourceGroup;

namespace MouldSchedule
{
    public class MySchedulingAlgorithm
    {
        OrMould orMould;
        public MySchedulingAlgorithm(OrMould orMould)
        {
            this.orMould = orMould;
        }

        public List<ScheduleResult> Solve()
        {
            // 创建求解器
            Solver solver = Solver.CreateSolver("SCIP");

            // 决策变量
            Variable[,,] x = new Variable[orMould.OrPart.Count, orMould.OrPart.Max(s=>s.), _resources.Count];


            return null;
        }
    }
}
