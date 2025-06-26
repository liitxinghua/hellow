namespace MouldSchedule.OrSchedule.Entity
{
    /// <summary>
    /// 部品工艺
    /// </summary>
    public class OrProcess
    {
        /// <summary>
        /// 工艺Id
        /// </summary>
        public string? OrProcessId { get; set; }

        /// <summary>
        /// 工艺下的工程
        /// </summary>
        public List<OrEng> OrEng { get; set; }
    }

}
