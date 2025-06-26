namespace MouldSchedule.Share
{
    public enum EnumLoadFlgGroup
    {
        [LoadFlgGroupAtt(EnumOrgType.用户, 1)]
        A设计_Design = 5,
        [LoadFlgGroupAtt(EnumOrgType.用户, 2)]
        B编程_Program = 6,
        [LoadFlgGroupAtt(EnumOrgType.用户, 3)]
        C加工_人_WorkUser = 7,

        [LoadFlgGroupAtt(EnumOrgType.设备, 4)]
        F_电极加工_Pole = 48,
        [LoadFlgGroupAtt(EnumOrgType.设备, 5)]
        G粗加工_BH = 37,
        [LoadFlgGroupAtt(EnumOrgType.设备, 6)]
        H_精加工_AH = 36,
        [LoadFlgGroupAtt(EnumOrgType.设备, 7)]
        I_放电加工_EDM = 49,
        [LoadFlgGroupAtt(EnumOrgType.设备, 8)]
        J_线割加工_WC = 50,

        [LoadFlgGroupAtt(EnumOrgType.用户, 9)]
        D检查_Check = 18,
        [LoadFlgGroupAtt(EnumOrgType.用户, 10)]
        E组装_Fabricate = 20,
    }
}
