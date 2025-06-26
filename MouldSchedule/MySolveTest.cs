using Google.OrTools.LinearSolver;

namespace MouldSchedule
{
    public static class MySolveTest
    {
        public static void Test()
        {
            /*
             * 尽可能增加 3x + y，但需遵循以下限制条件：
             * 0 ≤ x ≤ 1
             * 0 ≤ y ≤ 2
             * x + y ≤ 2
             */

            //声明求解器
            Solver solver = Solver.CreateSolver("GLOP");
            //创建变量
            Variable x = solver.MakeNumVar(0.0, 1.0, "x");
            Variable y = solver.MakeNumVar(0.0, 2.0, "y");
            //定义约束条件
            Constraint constraint = solver.MakeConstraint(double.NegativeInfinity, 2.0, "constraint");
            constraint.SetCoefficient(x, 1);
            constraint.SetCoefficient(y, 1);
            //定义目标函数
            Objective objective = solver.Objective();
            objective.SetCoefficient(x, 3);
            objective.SetCoefficient(y, 1);
            objective.SetMaximization();

            //求解
            Solver.ResultStatus resultStatus = solver.Solve();
            if (resultStatus == Solver.ResultStatus.OPTIMAL)
            {
                //最优解
                var value = solver.Objective().Value();
                var xValue = x.SolutionValue();
                var yValue = y.SolutionValue();
            }

        }

    }
}
