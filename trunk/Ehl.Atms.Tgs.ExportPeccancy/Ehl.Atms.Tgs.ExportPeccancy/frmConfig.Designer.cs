namespace Ehl.Atms.Tgs.ExportPeccancy
{
    partial class frmConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_wflx = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txt_Zqmj = new System.Windows.Forms.TextBox();
            this.btn_Close_Zqmj = new System.Windows.Forms.Button();
            this.btn_Save_Zqmj = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_flash = new System.Windows.Forms.Button();
            this.text_dlmc = new System.Windows.Forms.TextBox();
            this.text_ms = new System.Windows.Forms.TextBox();
            this.text_lddm = new System.Windows.Forms.TextBox();
            this.text_dldm = new System.Windows.Forms.TextBox();
            this.text_sbmc = new System.Windows.Forms.TextBox();
            this.text_sblx = new System.Windows.Forms.TextBox();
            this.text_sbid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_kkid = new System.Windows.Forms.TextBox();
            this.listkkinfo = new System.Windows.Forms.ListBox();
            this.listkkid = new System.Windows.Forms.ListBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 347);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_Close);
            this.tabPage2.Controls.Add(this.btn_Save);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbb_wflx);
            this.tabPage2.Controls.Add(this.checkedListBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 321);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "违法行为配置";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 177);
            this.label1.TabIndex = 52;
            this.label1.Text = "违法类型：";
            this.label1.Visible = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(352, 280);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 51;
            this.btn_Close.Text = "关闭(&C)";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(243, 280);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 23);
            this.btn_Save.TabIndex = 50;
            this.btn_Save.Text = "保存(&S)";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(15, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 49;
            this.label6.Text = "违法类型：";
            // 
            // cbb_wflx
            // 
            this.cbb_wflx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_wflx.Font = new System.Drawing.Font("宋体", 10.5F);
            this.cbb_wflx.FormattingEnabled = true;
            this.cbb_wflx.Items.AddRange(new object[] {
            "越黄线",
            "超速",
            "闯红灯",
            "牌照比对",
            "大货车禁行",
            "黄标车",
            "走专用道"});
            this.cbb_wflx.Location = new System.Drawing.Point(98, 18);
            this.cbb_wflx.Name = "cbb_wflx";
            this.cbb_wflx.Size = new System.Drawing.Size(126, 22);
            this.cbb_wflx.TabIndex = 48;
            this.cbb_wflx.SelectedIndexChanged += new System.EventHandler(this.cbb_wflx_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(243, 17);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(184, 244);
            this.checkedListBox1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_Zqmj);
            this.tabPage1.Controls.Add(this.btn_Close_Zqmj);
            this.tabPage1.Controls.Add(this.btn_Save_Zqmj);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(561, 321);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "执勤民警";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txt_Zqmj
            // 
            this.txt_Zqmj.Location = new System.Drawing.Point(102, 27);
            this.txt_Zqmj.Name = "txt_Zqmj";
            this.txt_Zqmj.Size = new System.Drawing.Size(100, 21);
            this.txt_Zqmj.TabIndex = 54;
            // 
            // btn_Close_Zqmj
            // 
            this.btn_Close_Zqmj.Location = new System.Drawing.Point(352, 280);
            this.btn_Close_Zqmj.Name = "btn_Close_Zqmj";
            this.btn_Close_Zqmj.Size = new System.Drawing.Size(75, 23);
            this.btn_Close_Zqmj.TabIndex = 53;
            this.btn_Close_Zqmj.Text = "关闭(&C)";
            this.btn_Close_Zqmj.UseVisualStyleBackColor = true;
            this.btn_Close_Zqmj.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Save_Zqmj
            // 
            this.btn_Save_Zqmj.Location = new System.Drawing.Point(243, 280);
            this.btn_Save_Zqmj.Name = "btn_Save_Zqmj";
            this.btn_Save_Zqmj.Size = new System.Drawing.Size(75, 23);
            this.btn_Save_Zqmj.TabIndex = 52;
            this.btn_Save_Zqmj.Text = "保存(&S)";
            this.btn_Save_Zqmj.UseVisualStyleBackColor = true;
            this.btn_Save_Zqmj.Click += new System.EventHandler(this.btn_Save_Zqmj_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 50;
            this.label2.Text = "执勤民警：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.btn_flash);
            this.tabPage3.Controls.Add(this.text_dlmc);
            this.tabPage3.Controls.Add(this.text_ms);
            this.tabPage3.Controls.Add(this.text_lddm);
            this.tabPage3.Controls.Add(this.text_dldm);
            this.tabPage3.Controls.Add(this.text_sbmc);
            this.tabPage3.Controls.Add(this.text_sblx);
            this.tabPage3.Controls.Add(this.text_sbid);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.text_kkid);
            this.tabPage3.Controls.Add(this.listkkinfo);
            this.tabPage3.Controls.Add(this.listkkid);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(561, 321);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "道路信息配置";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "设备类型";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "设备编号";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "增加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_flash
            // 
            this.btn_flash.Location = new System.Drawing.Point(28, 239);
            this.btn_flash.Name = "btn_flash";
            this.btn_flash.Size = new System.Drawing.Size(75, 23);
            this.btn_flash.TabIndex = 11;
            this.btn_flash.Text = "刷新";
            this.btn_flash.UseVisualStyleBackColor = true;
            this.btn_flash.Click += new System.EventHandler(this.btn_flash_Click);
            // 
            // text_dlmc
            // 
            this.text_dlmc.Location = new System.Drawing.Point(387, 199);
            this.text_dlmc.Name = "text_dlmc";
            this.text_dlmc.Size = new System.Drawing.Size(166, 21);
            this.text_dlmc.TabIndex = 10;
            // 
            // text_ms
            // 
            this.text_ms.Location = new System.Drawing.Point(387, 171);
            this.text_ms.Name = "text_ms";
            this.text_ms.Size = new System.Drawing.Size(166, 21);
            this.text_ms.TabIndex = 9;
            // 
            // text_lddm
            // 
            this.text_lddm.Location = new System.Drawing.Point(387, 143);
            this.text_lddm.Name = "text_lddm";
            this.text_lddm.Size = new System.Drawing.Size(166, 21);
            this.text_lddm.TabIndex = 8;
            // 
            // text_dldm
            // 
            this.text_dldm.Location = new System.Drawing.Point(387, 115);
            this.text_dldm.Name = "text_dldm";
            this.text_dldm.Size = new System.Drawing.Size(166, 21);
            this.text_dldm.TabIndex = 7;
            // 
            // text_sbmc
            // 
            this.text_sbmc.Location = new System.Drawing.Point(387, 87);
            this.text_sbmc.Name = "text_sbmc";
            this.text_sbmc.Size = new System.Drawing.Size(166, 21);
            this.text_sbmc.TabIndex = 6;
            // 
            // text_sblx
            // 
            this.text_sblx.Location = new System.Drawing.Point(387, 59);
            this.text_sblx.Name = "text_sblx";
            this.text_sblx.Size = new System.Drawing.Size(166, 21);
            this.text_sblx.TabIndex = 5;
            // 
            // text_sbid
            // 
            this.text_sbid.Location = new System.Drawing.Point(387, 31);
            this.text_sbid.Name = "text_sbid";
            this.text_sbid.Size = new System.Drawing.Size(166, 21);
            this.text_sbid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(299, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "卡口编号";
            // 
            // text_kkid
            // 
            this.text_kkid.Location = new System.Drawing.Point(387, 3);
            this.text_kkid.Name = "text_kkid";
            this.text_kkid.Size = new System.Drawing.Size(166, 21);
            this.text_kkid.TabIndex = 2;
            // 
            // listkkinfo
            // 
            this.listkkinfo.FormattingEnabled = true;
            this.listkkinfo.ItemHeight = 12;
            this.listkkinfo.Location = new System.Drawing.Point(155, 3);
            this.listkkinfo.Name = "listkkinfo";
            this.listkkinfo.Size = new System.Drawing.Size(120, 136);
            this.listkkinfo.TabIndex = 1;
            // 
            // listkkid
            // 
            this.listkkid.FormattingEnabled = true;
            this.listkkid.ItemHeight = 12;
            this.listkkid.Location = new System.Drawing.Point(3, 3);
            this.listkkid.Name = "listkkid";
            this.listkkid.Size = new System.Drawing.Size(146, 196);
            this.listkkid.TabIndex = 0;
            this.listkkid.SelectedIndexChanged += new System.EventHandler(this.listkkid_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "设备名称";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "道路代码";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "路段代码";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(299, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 18;
            this.label10.Text = "米数";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(299, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 19;
            this.label11.Text = "道路名称";
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbb_wflx;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txt_Zqmj;
        private System.Windows.Forms.Button btn_Close_Zqmj;
        private System.Windows.Forms.Button btn_Save_Zqmj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_flash;
        private System.Windows.Forms.TextBox text_dlmc;
        private System.Windows.Forms.TextBox text_ms;
        private System.Windows.Forms.TextBox text_lddm;
        private System.Windows.Forms.TextBox text_dldm;
        private System.Windows.Forms.TextBox text_sbmc;
        private System.Windows.Forms.TextBox text_sblx;
        private System.Windows.Forms.TextBox text_sbid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_kkid;
        private System.Windows.Forms.ListBox listkkinfo;
        private System.Windows.Forms.ListBox listkkid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}