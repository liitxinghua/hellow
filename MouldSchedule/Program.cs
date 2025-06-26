using System.Security.AccessControl;

namespace MouldSchedule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,,] a = new int[1, 2, 3];

            MySolveTest.Test();

            SchedulingService _schedulingService = new SchedulingService();
            // 添加资源
            _schedulingService.AddResource(new Resource { Id = 1, Name = "CNC-1", ResourceType = "CNC" });
            _schedulingService.AddResource(new Resource { Id = 2, Name = "EDM-1", ResourceType = "EDM" });
            _schedulingService.AddResource(new Resource { Id = 3, Name = "研磨机-1", ResourceType = "研磨" });

            // 添加订单
            var order1 = new Order
            {
                Id = 1,
                Name = "模具A",
                DueDate = DateTime.Now.AddDays(5),
                ProcessSteps = new List<ProcessStep>
                {
                    new ProcessStep { Id = 101, Name = "CNC加工", RequiredResourceType = "CNC", ProcessingTime = 8 },
                    new ProcessStep { Id = 102, Name = "EDM加工", RequiredResourceType = "EDM", ProcessingTime = 12, PredecessorId = 101 },
                    new ProcessStep { Id = 103, Name = "研磨", RequiredResourceType = "研磨", ProcessingTime = 6, PredecessorId = 102 }
                }
            };

            var order2 = new Order
            {
                Id = 2,
                Name = "模具B",
                DueDate = DateTime.Now.AddDays(3),
                ProcessSteps = new List<ProcessStep>
                {
                    new ProcessStep { Id = 201, Name = "CNC加工", RequiredResourceType = "CNC", ProcessingTime = 6 },
                    new ProcessStep { Id = 202, Name = "EDM加工", RequiredResourceType = "EDM", ProcessingTime = 9, PredecessorId = 201 },
                    new ProcessStep { Id = 203, Name = "研磨", RequiredResourceType = "研磨", ProcessingTime = 4, PredecessorId = 202 }
                }
            };

            _schedulingService.AddOrder(order1);
            _schedulingService.AddOrder(order2);

            // 生成排产计划
            var results = _schedulingService.GenerateSchedule();
        }
    }

    // Models/Order.cs
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public List<ProcessStep> ProcessSteps { get; set; } = new List<ProcessStep>();
        public int Priority { get; set; } = 1;
    }

    // Models/ProcessStep.cs
    public class ProcessStep
    {
        public int Id { get; set; }
        public string Name { get; set; } // 例如：CNC加工、EDM加工
        public string RequiredResourceType { get; set; } // 所需资源类型
        public double ProcessingTime { get; set; } // 处理时间（小时）
        public int OrderId { get; set; }
        public int? PredecessorId { get; set; } // 前序工序ID
    }

    // Models/Resource.cs
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ResourceType { get; set; } // 例如：CNC、EDM、研磨机
        public bool IsAvailable { get; set; } = true;
        public List<DateTime> UnavailablePeriods { get; set; } = new List<DateTime>();
    }

    // Models/ScheduleResult.cs
    public class ScheduleResult
    {
        public int OrderId { get; set; }
        public int ProcessStepId { get; set; }
        public int ResourceId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
