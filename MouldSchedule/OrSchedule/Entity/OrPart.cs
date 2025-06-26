using MouldSchedule.Share;

namespace MouldSchedule.OrSchedule.Entity
{        /// <summary>
         /// 订单部品
         /// </summary>
    public class OrPart
    {
        /// <summary>
        /// 部品Id
        /// </summary>
        public string? PartsId { get; set; }

        /// <summary>
        /// 部品类型 
        /// </summary>           
        public EnumPartType PartType { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }

        /// <summary>
        /// 部品下的工艺
        /// </summary>
        public List<OrProcess> OrProcess { get; set; }
    }

}
