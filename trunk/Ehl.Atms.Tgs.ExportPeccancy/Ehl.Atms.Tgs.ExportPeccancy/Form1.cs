using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ehl.Atms.Tgs.ExportPeccancy.VioDataInfos;
using System.IO;

namespace Ehl.Atms.Tgs.ExportPeccancy
{

    public partial class Form1 : Form
    {
        private class CarInfo
        {
            public string platenum;
            public string platetype;
            public string roadid;
        }
        List<CarInfo> carInfoList = new List<CarInfo>();
        GetConfig getConfig = new GetConfig();
        GetRoadInfo getRoadInfo = new GetRoadInfo();
        List<RoadInfo> roadlist;
            
        DataAccess dataAccess = new DataAccess();
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            Common.DeleteLogFile();
            dtp_Start.Text = DateTime.Now.ToString("yyyy-MM-dd 00:00:00");
            dtp_End.Text = DateTime.Now.ToString("yyyy-MM-dd 23:59:59");
            roadlist = getRoadInfo.LoadRoadInfo();
            //需要判断配置文件是否存在，如果不存在得创建空的配置文件
            Common.CreateConfigXML();
        }

        private void Export_eara()
        {
            List<Config> list = getConfig.Configs;
                DataTable dt = dataAccess.GetPeccancy_aera(dtp_Start.Text, dtp_End.Text, "");
                if (dt != null && dt.Rows.Count > 0)
                {
                    Invoke(new Action(delegate
                    {

                        pb_aera.Minimum = 0;
                        pb_aera.Maximum = dt.Rows.Count;
                        lbl_type.Text = "区间";
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            try
                            {
                                VioDataInfo viodata = new VioDataInfo();
                                viodata.xh = dt.Rows[i]["XH"].ToString();
                                viodata.hphm = dt.Rows[i]["HPHM"].ToString();
                                viodata.hpzl = dt.Rows[i]["HPZL"].ToString().PadRight(2);
                                viodata.length = dt.Rows[i]["QJJL"].ToString();
                                viodata.limitspeed = dt.Rows[i]["QJXS"].ToString();
                                viodata.usetime = dt.Rows[i]["QJYS"].ToString();
                                viodata.div = dt.Rows[i]["CSBL"].ToString();
                                viodata.avspeed = dt.Rows[i]["XSSD"].ToString();
                                viodata.areaNames = dt.Rows[i]["KSKKMC"].ToString();
                                viodata.areaNamee = dt.Rows[i]["JSKKMC"].ToString();
                                viodata.img1 = dt.Rows[i]["ZJWJ1"].ToString();
                                viodata.img2 = dt.Rows[i]["ZJWJ2"].ToString();
                                viodata.viodate = dt.Rows[i]["WFJSSJ"].ToString();
                                viodata.wfxw = dt.Rows[i]["WFXW"].ToString();
                                viodata.jtfs = dt.Rows[i]["JTFS"].ToString();
                                viodata.wfdd = dt.Rows[i]["WFDD"].ToString();
                                viodata.wfjssj = dt.Rows[i]["WFJSSJ"].ToString();
                                /*
                                int tag = 0;
                                foreach (CarInfo car in carInfoList)
                                { 
                                    if(car.platenum == viodata.hphm && car.platetype == viodata.hpzl)
                                        if (car.roadid == viodata.areaNames || car.roadid == viodata.areaNamee)
                                        {
                                            tag = 1;
                                            break;
                                        }
                                }
                                if(tag == 1)
                                    continue;
                                 * */
                                string wfdz = "";
                                string sbbm = "";
                                string nvrid = "";
                                string roadid = "";
                                string km = "";
                                string mters = "";
                                foreach (RoadInfo ri in roadlist)
                                {
                                    if (ri.kkid == viodata.wfdd && ri.sblx == "7")
                                    {
                                        wfdz = ri.dlmc;
                                        sbbm = ri.sbbh;
                                        roadid = ri.dldm;
                                        km = ri.lddm;
                                        mters = ri.ms;


                                        break;
                                    }
                                }
                                //string filepath = txt_path.Text + fileName;
                                //导出
                                DateTime wfsj = DateTime.Parse(viodata.viodate);
                                DateTime endtime = DateTime.Parse(viodata.wfjssj);
                                //4位时间,车号,号牌种类,行驶车道,地址,违法行为代码，实测值，标准值，车辆类型,设备编码,NVR设备号,图片顺序.jpg
                                string fileName = wfsj.ToString("yyyyMMddHHmmss") + "@@" + endtime.ToString("yyyyMMddHHmmss") + "," 
                                    + viodata.hphm + "," 
                                    + viodata.hpzl + ",1,"
                                    + wfdz + "@@" 
                                    + roadid
                                    + km
                                    + mters + ","
                                    + viodata.wfxw + "," 
                                    + viodata.avspeed + "," 
                                    + viodata.limitspeed + "," 
                                    + viodata.jtfs + "," 
                                    + sbbm + "," 
                                    + nvrid + ",1.jpg";
              
                    //            string fileName = wfsj.ToString("yyMMddHHmmss") + "_" + viodata.hphm + "_" + viodata.hpzl + ".jpg";
                                MergeImg mimg = new MergeImg();
                                if (!Directory.Exists(txt_path.Text + "/区间" + "/"))
                                    Directory.CreateDirectory(txt_path.Text + "/区间" + "/");
                                if (!Directory.Exists(txt_path.Text + "/区间/" + viodata.areaNamee + "/"))
                                    Directory.CreateDirectory(txt_path.Text + "/区间/" + viodata.areaNamee + "/");
                                mimg.mergelpic(viodata, txt_path.Text + "/区间/" + viodata.areaNamee + "/" + fileName);

                                dataAccess.UpdatePeccancy_aera(viodata.xh);
                                System.Windows.Forms.Application.DoEvents();
                                pb_aera.Value = i + 1;
                                lbl_area_rate.Text = Convert.ToString(i + 1) + "/" + dt.Rows.Count.ToString();

                                count++;
                            }
                            catch (Exception ex)
                            {

                            }
                        }
                       
                    }));
               
            }
                else
                {
                    pb_aera.Value = 100;
                    lbl_area_rate.Text = "0/0";
                }
        }
        private void Export_kk()
        {
            lbl_type.Text = "正在查询";
            UInt32 passcar_count = dataAccess.GetPasscarCcount(dtp_Start.Text, dtp_End.Text);
            count = 0;
            DateTime start_datetime = Convert.ToDateTime(dtp_Start.Text);
            DateTime end_datetime = Convert.ToDateTime(dtp_End.Text);

            for (DateTime loop_datetime = start_datetime; loop_datetime <= end_datetime.AddMinutes(1); loop_datetime = loop_datetime.AddMinutes(30))
            {
                DataTable dt = dataAccess.GetPassCar(loop_datetime.ToString(), loop_datetime.AddMinutes(30).ToString());

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        Invoke(new Action(delegate
                        {
                            pb_kk.Minimum = 0;
                            pb_kk.Maximum = (int)passcar_count;
                            lbl_type.Text = "卡口";
                            for (int i = 0; i < dt.Rows.Count; i++)
                            {
                                string xh = dt.Rows[i]["xh"].ToString();
                                DateTime dtime = DateTime.Parse(dt.Rows[i]["gwsj"].ToString());
                                string kkmc = dt.Rows[i]["kkmc"].ToString();
                                string zjwj = dt.Rows[i]["zjwj"].ToString();
                                string picName = dtime.ToString("yyMMddHHmmss") + xh + ".jpg";
                                string imgpath = txt_path.Text;
                                imgpath += "/卡口/";
                                if (!Directory.Exists(imgpath))
                                    Directory.CreateDirectory(imgpath);
                                imgpath = imgpath + "/" + kkmc + "/";
                                if (!Directory.Exists(imgpath))
                                    Directory.CreateDirectory(imgpath);
                                imgpath = imgpath + "/" + dtime.ToString("yyMMdd") + "/";
                                if (!Directory.Exists(imgpath))
                                    Directory.CreateDirectory(imgpath);
                                stat_label.Text = "正在下载：" + zjwj;
                                string stat_string = Common.SavePic(zjwj, imgpath + picName);
                                if (stat_string!="")
                                {
                                    stat_label.Text = "正在下载：" + zjwj + " 失败. error：" + stat_string;
                                    System.Threading.Thread.Sleep(500);
                                }
                                System.Windows.Forms.Application.DoEvents();
                                count++;
                                pb_kk.Value = count;
                                lbl_kk_rate.Text = Convert.ToString(count) + "/" + Convert.ToString(passcar_count);

                            }
                        }));
                    }


                }
            stat_label.Text = "导出卡口数据完毕";


            
        }
        private void Export()
        {
            List<Config> list = getConfig.Configs;
            foreach (Config item in list)
            {
                //每种违法类型导出一种格式
                DataTable dt = dataAccess.GetPeccancy(dtp_Start.Text, dtp_End.Text, item.Code.TrimEnd(',').Replace(",", "','"));
                if (dt != null && dt.Rows.Count > 0)
                {
                    Invoke(new Action(delegate
                    {
                       //xh,hpzl,hphm,wfsj,wfdz,wfdd,fxbh,clsd,cdbh,sjly,sbbh,wfxw,clxs,jtfs
                        pb_kk.Minimum = 0;
                        pb_kk.Maximum = dt.Rows.Count;
                        lbl_type.Text = item.Wfxwms;
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            string xh = dt.Rows[i][0].ToString();
                            string hpzl = dt.Rows[i][1].ToString().PadRight(2);
                            string hphm = dt.Rows[i][2].ToString();
                         //   string wfsj = dt.Rows[i][3].ToString();
                            string wfdz = dt.Rows[i][4].ToString();
                            string wfdd = dt.Rows[i][5].ToString();
                            string fxbh = dt.Rows[i][6].ToString();
                            string clsd = dt.Rows[i][7].ToString();
                            string cdbh = dt.Rows[i][8].ToString();
                            string sjly = dt.Rows[i][9].ToString();
                            string sbbh = dt.Rows[i][10].ToString();
                            string wfxw = dt.Rows[i][11].ToString();
                            string clxs = dt.Rows[i][12].ToString();//标准速度
                            string jtfs = dt.Rows[i][13].ToString();
                            CarInfo carinfo = new CarInfo();
                            carinfo.platenum = hphm;
                            carinfo.platetype = hpzl;
                            carinfo.roadid = wfdd;
//                             if (wfdz.Length > 21)
//                             {
//                                 wfdz = wfdz.Substring(0, 21);
//                             }
//                             else
//                             {
//                                 wfdz = wfdz.PadRight(21);
//                             }
                       //     string wfdd = dt.Rows[i][5].ToString().Substring(0, 9);
                       //     string xsfx = dt.Rows[i][6].ToString();
                            fxbh = fxbh.Substring(fxbh.Length - 1, 1).PadRight(9);

                            DateTime wfsj = DateTime.Parse(dt.Rows[i][3].ToString());
                            DataTable dtCapture = dataAccess.GetCapture(xh);
                            string picName1 = string.Empty;
                            string picName2 = string.Empty;
                            string picName3 = string.Empty;
                           /*
                            string clsd = "     ";//5
                            string xscd = "        ";//8
                            if (item.Wfxwms == "超速" || item.Wfxwms == "闯红灯")
                            {
                                clsd = dt.Rows[i][7].ToString().PadRight(5);
                                xscd = string.Format("第{0}车道", dt.Rows[i][8].ToString());
                                xscd = xscd.PadRight(8);
                            }
                            string cdbh = dt.Rows[i][8].ToString().PadRight(5);

                            if (item.Wfxwms == "越黄线" || item.Wfxwms == "违法停车" || item.Wfxwms == "走专用道")
                            {
                                cdbh = "     ";//5
                            }


                       //     string wflx = Common.GetWfType(item.Wfxwms);
                      //      string sblx = dt.Rows[i][9].ToString().PadRight(5);
                     //       string sbbh = dt.Rows[i][10].ToString().PadRight(20);
                     //       string zqmj = getConfig.Zqmj.PadRight(10);
                            
                            string content = hpzl + hphm.PadRight(10) + wfsj.ToString("yyyy-MM-dd").PadRight(11) + wfdz
                                             + wfdd + xsfx + "".PadRight(9) + wfsj.ToString("HH:mm:ss").PadRight(9) + "".PadRight(9)
                                             + picName1.PadRight(30) + clsd + xscd + cdbh + sblx + wflx + sbbh + zqmj
                                             + picName2.PadRight(30) + picName3.PadRight(30);
                            //string filepath = txt_path.Text + fileName;
                            //导出
                            string fileName = wfsj.ToString("yyMMddHHmmss") + "_" + hphm + "_" + hpzl + ".jddat";


                            Common.WritePeccancy(content, fileName, txt_path.Text + "/" + "单点" + "/" + wfdz);//gengming add wfdz
                            */

                            lbl_kk_rate.Text = Convert.ToString(i + 1) + "/" + dt.Rows.Count.ToString();
                            //20160913153803,京Q6J6L6,02,1,十天高速K79_300,13521,112,100,K31,,,1.jpg
                            if (list == null)
                                MessageBox.Show("参数异常");
                            wfdz = "";
                            string sbbm = "";
                            string nvrid = "";

                            foreach (RoadInfo ri in roadlist)
                            {
                                if (ri.kkid == wfdd && ri.sblx == "3")
                                {
                                    wfdz = ri.dlmc;
                                    sbbm = ri.sbbh;
                                    break;
                                }
                            }


                            for (int j = 1; j < dtCapture.Rows.Count + 1; j++)
                            {   //4位时间,车号,号牌种类,行驶车道,地址,违法行为代码，实测值，标准值，车辆类型,设备编码,NVR设备号,图片顺序.jpg
                                
                                if (j == 1)
                                {
                                    picName1 = wfsj.ToString("yyyyMMddHHmmss") + "," + hphm + "," + hpzl + "," + cdbh + "," + wfdz + "," + wfxw + "," + clsd +"," + clxs + "," + jtfs + "," + sbbm + "," + nvrid + "," + j.ToString() + ".jpg";
                                    stat_label.Text = string.Format("正在下载：{0}",dtCapture.Rows[j - 1][0].ToString());
                                   Common.SavePic(dtCapture.Rows[j - 1][0].ToString(), txt_path.Text + "/单点/" + wfdz + "/" + picName1);//gengming add wfdz
                                }
                                else if (j == 2)
                                {
                                    picName2 = wfsj.ToString("yyyyMMddHHmmss") + "," + hphm + "," + hpzl + "," + cdbh + "," + wfdz + "," + wfxw + "," + clsd + "," + clxs + "," + jtfs + "," + sbbm + "," + nvrid + "," + j.ToString() + ".jpg";
                                    stat_label.Text = string.Format("正在下载：{0}",dtCapture.Rows[j - 1][0].ToString());
                                    Common.SavePic(dtCapture.Rows[j - 1][0].ToString(), txt_path.Text + "/单点/" + wfdz + "/" + picName2);
                                }
                                else
                                {
                                    picName3 = wfsj.ToString("yyyyMMddHHmmss") + "," + hphm + "," + hpzl + "," + cdbh + "," + wfdz + "," + wfxw + "," + clsd + "," + clxs + "," + jtfs + "," + sbbm + "," + nvrid + "," + j.ToString() + ".jpg";
                                    stat_label.Text = string.Format("正在下载：{0}", dtCapture.Rows[j - 1][0].ToString()); 
                                    Common.SavePic(dtCapture.Rows[j - 1][0].ToString(), txt_path.Text + "/单点/" + wfdz + "/" + picName3);
                                }
                            }

                            dataAccess.UpdatePeccancy(xh);
                            System.Windows.Forms.Application.DoEvents();
                            pb_kk.Value = i + 1;
                            count++;
                        }
                    }));
                }
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            string[] arr = lbl_kk_rate.Text.Split('/');
            if (arr.Length == 2 && arr[1] == arr[0])
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("图片正在导出，请稍候关闭！");
                return;
            }
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            if (frmConfig.Instance == null || frmConfig.Instance.IsDisposed)
            {
                frmConfig frm = new frmConfig();
                frm.Show();
            }
            else
            {
                frmConfig.Instance.Activate();
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_path.Text))
            {
                MessageBox.Show("请选择要保存的文件夹！");
                return;
            }
            getConfig.GetConfigModel();
            List<Config> list = getConfig.Configs;
            if (list == null || list.Count == 0)
            {
                MessageBox.Show("请配置好违法信息或联系管理员！");
                return;
            }
            count = 0;
            Export_eara();
            Export();
            
            MessageBox.Show("共导出" + count.ToString() + "条违法信息！");
        }

        private void btn_Brower_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fiBrower = new FolderBrowserDialog();
            if (fiBrower.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = fiBrower.SelectedPath;
            }
        }

        private void pb_kk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_path.Text))
            {
                MessageBox.Show("请选择要保存的文件夹！");
                return;
            }
            Export_kk();
            MessageBox.Show("共导出" + count.ToString() + "条违法信息！");
        }
    }
}
