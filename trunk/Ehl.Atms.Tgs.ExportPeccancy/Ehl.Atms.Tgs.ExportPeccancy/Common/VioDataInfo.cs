using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ehl.Atms.Tgs.ExportPeccancy.VioDataInfos
{
    class VioDataInfo
    {
        public string areaNames;
        public string areaNamee;
        public string length;
        public string hphm;
        public string limitspeed;
        public string avspeed;
        public string div;
        public string usetime;
        public string hpzl;
        public string xh;
        public string img1;
        public string img2;
        public string viodate;
        public string wfxw;
        public string areadms;
        public string areadme;
        public string jtfs;
        public string wfdd;
        public string wfjssj;

        public string toString()
        {
            string cllx;
            if(hpzl.Equals("02"))
                cllx = "小型车辆";
            else
                cllx = "大型车辆";
            string res = "区间名称："
                       + areaNames
                       + " --> "
                       + areaNamee
                       + "    长度："
                       + length
                       + "    号牌号码："
                       + hphm
                       + "    号牌种类："
                       + cllx
                       + "    限速："
                       + limitspeed
                       + "    平均速度："
                       + avspeed
                       + "    超速比："
                       + div
                       + "    行驶时间："
                       + usetime;
            return res;
        }
    }
}
