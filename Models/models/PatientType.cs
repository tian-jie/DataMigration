using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InnoCellence.Lccp.Data.Models
{
    public enum PatientType
    {
        LccpCommon=0,//LCCP通用（非CDS非医共体非未成年患者）
        CDSNotLilly=2,//CDS非礼来
        CDS=3,//CDS
        HelpRegist=7,//代注册
        DYD=8,//度易达
        BYODNotLilly=9,//BYOD非礼来
        PEPLilly=11,//PEP-礼来
        PEPNotLilly = 12,//PEP-非礼来
        YGT=13,//医共体
        YGTNotLilly=14,//医共体非礼来
        UnderAge=15,//未成年患者



    }
}