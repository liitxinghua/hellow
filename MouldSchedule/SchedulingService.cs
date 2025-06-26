namespace MouldSchedule
{
    public class SchedulingService
    {
        private readonly List<Order> _orders = new List<Order>();
        private readonly List<Resource> _resources = new List<Resource>();

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public void AddResource(Resource resource)
        {
            _resources.Add(resource);
        }

        public List<ScheduleResult> GenerateSchedule()
        {
            var algorithm = new SchedulingAlgorithm(_orders, _resources);
            return algorithm.Solve();
        }
    }
}
