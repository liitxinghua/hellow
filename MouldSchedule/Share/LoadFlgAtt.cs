namespace MouldSchedule.Share
{
    public class LoadFlgAtt : Attribute
    {
        public EnumLoadFlgGroup LoadFlgGroup { get; set; }
        public EnumOrgType OrgType { get; set; }
        public EnumOrgSysDefautType OrgSysDefautType { get; set; }
        public int Sort { get; set; }
        public EnumLoadFlgProductionScheduleGroup LoadFlgProductionScheduleGroup { get; set; }
        public LoadFlgAtt(EnumLoadFlgGroup group, EnumLoadFlgProductionScheduleGroup loadFlgProductionScheduleGroup, EnumOrgSysDefautType orgSysDefautType, EnumOrgType orgType, int sort)
        {
            this.LoadFlgGroup = group;
            this.LoadFlgProductionScheduleGroup = loadFlgProductionScheduleGroup;
            this.OrgSysDefautType = orgSysDefautType;
            this.OrgType = orgType;
            this.Sort = sort;
        }
    }
}
