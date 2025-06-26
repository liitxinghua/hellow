namespace MouldSchedule.Share
{
    public class LoadFlgGroupAtt : Attribute
    {
        public EnumOrgType OrgType { get; set; }
        public int Sort { get; set; }
        public LoadFlgGroupAtt(EnumOrgType orgType, int sort)
        {
            this.OrgType = orgType;
            this.Sort = sort;
        }
    }
}
