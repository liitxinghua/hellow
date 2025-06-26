using Google.OrTools.LinearSolver;

namespace MouldSchedule
{


    public class SchedulingAlgorithm
    {
        private readonly List<Order> _orders;
        private readonly List<Resource> _resources;

        public SchedulingAlgorithm(List<Order> orders, List<Resource> resources)
        {
            _orders = orders;
            _resources = resources;
        }

        public List<ScheduleResult> Solve()
        {
            // 创建求解器
            Solver solver = Solver.CreateSolver("SCIP");

            // 决策变量: x[i,j,k]表示订单i的工序j是否由资源k处理
            Variable[,,] x = new Variable[_orders.Count, GetMaxProcessSteps(), _resources.Count];

      
            

            // 开始时间: t[i,j]表示订单i的工序j的开始时间
            Variable[,] t = new Variable[_orders.Count, GetMaxProcessSteps()];

            // 最大完工时间
            Variable makespan = solver.MakeNumVar(0, double.PositiveInfinity, "makespan");

            // 初始化变量
            for (int i = 0; i < _orders.Count; i++)
            {
                for (int j = 0; j < _orders[i].ProcessSteps.Count; j++)
                {
                    t[i, j] = solver.MakeNumVar(0, double.PositiveInfinity, $"t_{i}_{j}");

                    for (int k = 0; k < _resources.Count; k++)
                    {
                        // 只有资源类型匹配的情况下才可能分配
                        bool resourceMatch = _resources[k].ResourceType == _orders[i].ProcessSteps[j].RequiredResourceType;
                        x[i, j, k] = solver.MakeBoolVar($"x_{i}_{j}_{k}");

                        if (!resourceMatch)
                        {
                            solver.Add(x[i, j, k] == 0);
                        }
                    }
                }
            }

            // 添加约束条件

            // 1. 每个工序必须由一个资源处理
            for (int i = 0; i < _orders.Count; i++)
            {
                for (int j = 0; j < _orders[i].ProcessSteps.Count; j++)
                {
                    //solver.Add(lpSum(Enumerable.Range(0, _resources.Count).Select(k => x[i, j, k])) == 1);
                }
            }

            // 2. 资源在同一时间只能处理一个工序
            for (int k = 0; k < _resources.Count; k++)
            {
                for (int i1 = 0; i1 < _orders.Count; i1++)
                {
                    for (int j1 = 0; j1 < _orders[i1].ProcessSteps.Count; j1++)
                    {
                        for (int i2 = 0; i2 < _orders.Count; i2++)
                        {
                            for (int j2 = 0; j2 < _orders[i2].ProcessSteps.Count; j2++)
                            {
                                if (i1 != i2 || j1 != j2)
                                {
                                    // 如果资源k同时处理工序j1和j2，则它们的时间不能重叠
                                    solver.Add(t[i1, j1] + _orders[i1].ProcessSteps[j1].ProcessingTime <=
                                              t[i2, j2] + (1 - x[i2, j2, k]) * 10000);
                                }
                            }
                        }
                    }
                }
            }

            // 3. 工序必须按顺序进行
            for (int i = 0; i < _orders.Count; i++)
            {
                for (int j = 0; j < _orders[i].ProcessSteps.Count; j++)
                {
                    if (_orders[i].ProcessSteps[j].PredecessorId.HasValue)
                    {
                        int predIndex = _orders[i].ProcessSteps.FindIndex(s => s.Id == _orders[i].ProcessSteps[j].PredecessorId.Value);
                        if (predIndex >= 0)
                        {
                            solver.Add(t[i, j] >= t[i, predIndex] + _orders[i].ProcessSteps[predIndex].ProcessingTime);
                        }
                    }
                }
            }

            // 4. 定义最大完工时间
            for (int i = 0; i < _orders.Count; i++)
            {
                for (int j = 0; j < _orders[i].ProcessSteps.Count; j++)
                {
                    solver.Add(makespan >= t[i, j] + _orders[i].ProcessSteps[j].ProcessingTime);
                }
            }

            // 设置目标：最小化最大完工时间
            Objective objective = solver.Objective();
            objective.SetCoefficient(makespan, 1);
            objective.SetMinimization();

            // 求解
            Solver.ResultStatus resultStatus = solver.Solve();

            // 收集结果
            var results = new List<ScheduleResult>();
            if (resultStatus == Solver.ResultStatus.OPTIMAL)
            {
                for (int i = 0; i < _orders.Count; i++)
                {
                    for (int j = 0; j < _orders[i].ProcessSteps.Count; j++)
                    {
                        for (int k = 0; k < _resources.Count; k++)
                        {
                            if (x[i, j, k].SolutionValue() > 0.5)
                            {
                                results.Add(new ScheduleResult
                                {
                                    OrderId = _orders[i].Id,
                                    ProcessStepId = _orders[i].ProcessSteps[j].Id,
                                    ResourceId = _resources[k].Id,
                                    StartTime = DateTime.Now.AddHours(t[i, j].SolutionValue()),
                                    EndTime = DateTime.Now.AddHours(t[i, j].SolutionValue() + _orders[i].ProcessSteps[j].ProcessingTime)
                                });
                            }
                        }
                    }
                }
            }

            return results;
        }

        private int GetMaxProcessSteps()
        {
            return _orders.Max(o => o.ProcessSteps.Count);
        }
    }
}
