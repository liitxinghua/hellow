namespace MouldSchedule.Share
{
    /// <summary>
    /// 系统内制部门类型，标识系统内置部门
    /// </summary>
    public enum EnumOrgSysDefautType
    {
        /*
         * 设计（设计课）
         * 编程（生产准备课）
         * 制造（加工课_人、加工课_设备、检查课、组装课）
         */
        营业课 = 0,
        设计课 = 1,
        生产准备课 = 2,
        加工课_人 = 7,
        加工课_设备 = 3,
        检查课 = 4,
        组装课 = 5,
        加工课 = 8,
        品管课 = 9,
        采购课 = 10,
    }
}
