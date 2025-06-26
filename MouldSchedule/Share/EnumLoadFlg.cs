namespace MouldSchedule.Share
{
    /// <summary>
    /// 负荷标识
    /// </summary>
    public enum EnumLoadFlg
    {
        [LoadFlgAtt(EnumLoadFlgGroup.A设计_Design, EnumLoadFlgProductionScheduleGroup.A设计_Design, EnumOrgSysDefautType.设计课, EnumOrgType.用户, 1)]
        A1设计模具构想_DesignIdea = 48,
        [LoadFlgAtt(EnumLoadFlgGroup.A设计_Design, EnumLoadFlgProductionScheduleGroup.A设计_Design, EnumOrgSysDefautType.设计课, EnumOrgType.用户, 2)]
        A2设计方案解析_DesignAnalysis = 49,
        [LoadFlgAtt(EnumLoadFlgGroup.A设计_Design, EnumLoadFlgProductionScheduleGroup.A设计_Design, EnumOrgSysDefautType.设计课, EnumOrgType.用户, 3)]
        A3设计部品图_DesignDiagram = 50,

        [LoadFlgAtt(EnumLoadFlgGroup.B编程_Program, EnumLoadFlgProductionScheduleGroup.B编程_Program, EnumOrgSysDefautType.生产准备课, EnumOrgType.用户, 4)]
        B编程_Program = 6,
        [LoadFlgAtt(EnumLoadFlgGroup.C加工_人_WorkUser, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_人, EnumOrgType.用户, 5)]
        C加工_人_WorkUser = 7,
        [LoadFlgAtt(EnumLoadFlgGroup.D检查_Check, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.检查课, EnumOrgType.用户, 6)]
        D检查_Check = 18,
        [LoadFlgAtt(EnumLoadFlgGroup.E组装_Fabricate, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.组装课, EnumOrgType.用户, 7)]
        E组装_Fabricate = 20,

        [LoadFlgAtt(EnumLoadFlgGroup.F_电极加工_Pole, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.设备, 8)]
        F1电极_大_Pole = 42,
        [LoadFlgAtt(EnumLoadFlgGroup.F_电极加工_Pole, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.设备, 9)]
        F2电极_中_Pole = 15,
        [LoadFlgAtt(EnumLoadFlgGroup.F_电极加工_Pole, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.设备, 10)]
        F3电极_小_Pole = 43,

        [LoadFlgAtt(EnumLoadFlgGroup.G粗加工_BH, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.设备, 11)]
        G1粗加工_大_BH = 8,
        [LoadFlgAtt(EnumLoadFlgGroup.G粗加工_BH, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.设备, 12)]
        G2粗加工_中_BH = 9,
        [LoadFlgAtt(EnumLoadFlgGroup.G粗加工_BH, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.设备, 13)]
        G3粗加工_小_BH = 10,

        [LoadFlgAtt(EnumLoadFlgGroup.H_精加工_AH, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.设备, 14)]
        H1精加工_大_AH = 12,
        [LoadFlgAtt(EnumLoadFlgGroup.H_精加工_AH, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 15)]
        H2精加工_中_AH = 13,
        [LoadFlgAtt(EnumLoadFlgGroup.H_精加工_AH, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 16)]
        H3精加工_小_AH = 14,

        [LoadFlgAtt(EnumLoadFlgGroup.I_放电加工_EDM, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 17)]
        I1放电_大_EDM = 44,
        [LoadFlgAtt(EnumLoadFlgGroup.I_放电加工_EDM, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 18)]
        I2放电_中_EDM = 16,
        [LoadFlgAtt(EnumLoadFlgGroup.I_放电加工_EDM, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 19)]
        I3放电_小_EDM = 45,

        [LoadFlgAtt(EnumLoadFlgGroup.J_线割加工_WC, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 20)]
        J1线割_大_WC = 46,
        [LoadFlgAtt(EnumLoadFlgGroup.J_线割加工_WC, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 21)]
        J2线割_中_WC = 17,
        [LoadFlgAtt(EnumLoadFlgGroup.J_线割加工_WC, EnumLoadFlgProductionScheduleGroup.C制造_Production, EnumOrgSysDefautType.加工课_设备, EnumOrgType.用户, 22)]
        J3线割_小_WC = 47,
    }
}
