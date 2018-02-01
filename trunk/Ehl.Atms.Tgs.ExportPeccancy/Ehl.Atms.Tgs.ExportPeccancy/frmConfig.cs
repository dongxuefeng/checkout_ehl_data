using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ehl.Atms.Tgs.ExportPeccancy
{
    public partial class frmConfig : Form
    {
        private static frmConfig instance = null;
        GetConfig getConfig = new GetConfig();
        List<Config> list = null;
        DataAccess dataAccess = new DataAccess();
        char charSplit = '-';

        public static frmConfig Instance
        {
            get { return instance; }
        }

        public frmConfig()
        {
            InitializeComponent();
            instance = this;
            getConfig.GetConfigModel();
            list = getConfig.Configs;
            txt_Zqmj.Text = getConfig.Zqmj;
            Bind();
            cbb_wflx.SelectedIndex = 0;
        }

        /// <summary>
        /// 绑定违法行为
        /// </summary>
        private void Bind()
        {
            DataTable dt = dataAccess.GetPeccancy_Type();
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    checkedListBox1.Items.Add(dt.Rows[i][0].ToString() + charSplit.ToString() + dt.Rows[i][1].ToString());
                }
            }
            //for (int i = 0; i < 10; i++)
            //{
            //    checkedListBox1.Items.Add(i.ToString() + charSplit.ToString() + "abcd"+i.ToString());
            //}
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                Config config = new Config();
                config.Wfxwms = cbb_wflx.SelectedItem.ToString();
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                {
                    if (checkedListBox1.GetItemChecked(i))
                    {
                        config.Code += checkedListBox1.Items[i].ToString().Split(charSplit)[0] + ",";
                    }
                }
                Common.SaveConfig(config);
                getConfig.GetConfigModel();
                list = getConfig.Configs;
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {

                MessageBox.Show("保存失败，请联系管理员！error:" + ex.ToString());
            }
        }

        private void cbb_wflx_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            foreach (Config item in list)
            {
                if (item.Wfxwms == cbb_wflx.SelectedItem.ToString())
                {
                    string[] arr = item.Code.Split(',');
                    foreach (string str in arr)
                    {
                        for (int i = 0; i < checkedListBox1.Items.Count; i++)
                        {
                            if (checkedListBox1.Items[i].ToString().IndexOf(str + charSplit.ToString()) == 0)
                            {
                                checkedListBox1.SetItemChecked(i, true);
                            }
                        }
                    }
                }
            }
        }

        private void btn_Save_Zqmj_Click(object sender, EventArgs e)
        {
            try
            {
                Common.SaveZqmj(txt_Zqmj.Text);
                MessageBox.Show("保存成功！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存失败，请联系管理员！");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoadInfo roadInfo = new RoadInfo();
            roadInfo.dldm = text_dldm.Text;
            roadInfo.dlmc = text_dlmc.Text;
            roadInfo.kkid = text_kkid.Text;
            roadInfo.lddm = text_lddm.Text;
            roadInfo.ms = text_ms.Text;
            roadInfo.sbbh = text_sbid.Text;
            roadInfo.sblx = text_sblx.Text;
            roadInfo.sbmc = text_sbmc.Text;
            GetRoadInfo getRoadInfo = new GetRoadInfo();
            getRoadInfo.WriteRoadInfo(roadInfo);
            text_dldm.Text = "";
            text_dlmc.Text = "";
            text_kkid.Text = "";
            text_lddm.Text = "";
            text_ms.Text = "";
            text_sbid.Text = "";
            text_sblx.Text = "";
            text_sbmc.Text = "";
        }

        private void btn_flash_Click(object sender, EventArgs e)
        {
            listkkid.Items.Clear();
            GetRoadInfo getRoadInfo = new GetRoadInfo();
            List<RoadInfo> list;
            list = getRoadInfo.LoadRoadInfo();
            if (list == null)
                MessageBox.Show("没有参数");
            foreach (RoadInfo ri in list)
            {
                listkkid.Items.Add(ri.kkid);
            }
        }

        private void listkkid_SelectedIndexChanged(object sender, EventArgs e)
        {
            listkkinfo.Items.Clear();
            GetRoadInfo getRoadInfo = new GetRoadInfo();
            List<RoadInfo> list;
            list = getRoadInfo.LoadRoadInfo();
            if (list == null)
                MessageBox.Show("没有参数");

            listkkinfo.Items.Add(list[listkkid.SelectedIndex].dldm);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].dlmc);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].lddm);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].ms);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].sbbh);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].sblx);
            listkkinfo.Items.Add(list[listkkid.SelectedIndex].sbmc);

        }


    }
}
