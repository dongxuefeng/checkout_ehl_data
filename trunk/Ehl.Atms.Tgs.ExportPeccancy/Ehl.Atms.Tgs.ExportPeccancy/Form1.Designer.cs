namespace Ehl.Atms.Tgs.ExportPeccancy
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Export = new System.Windows.Forms.Button();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.btn_Close = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_Brower = new System.Windows.Forms.Button();
            this.lbl_kk_rate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_kk = new System.Windows.Forms.ProgressBar();
            this.btn_Config = new System.Windows.Forms.Button();
            this.lbl_type = new System.Windows.Forms.Label();
            this.pb_aera = new System.Windows.Forms.ProgressBar();
            this.lbl_area_rate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.stat_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(411, 292);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(75, 23);
            this.btn_Export.TabIndex = 0;
            this.btn_Export.Text = "导出(&E)";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // dtp_Start
            // 
            this.dtp_Start.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Start.Location = new System.Drawing.Point(116, 45);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(157, 21);
            this.dtp_Start.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "结束时间：";
            // 
            // dtp_End
            // 
            this.dtp_End.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_End.Location = new System.Drawing.Point(116, 82);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(157, 21);
            this.dtp_End.TabIndex = 5;
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(513, 292);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 7;
            this.btn_Close.Text = "关闭(&C)";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "导出路径：";
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(116, 129);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(392, 21);
            this.txt_path.TabIndex = 9;
            // 
            // btn_Brower
            // 
            this.btn_Brower.Location = new System.Drawing.Point(513, 127);
            this.btn_Brower.Name = "btn_Brower";
            this.btn_Brower.Size = new System.Drawing.Size(75, 23);
            this.btn_Brower.TabIndex = 10;
            this.btn_Brower.Text = "浏览(&B)";
            this.btn_Brower.UseVisualStyleBackColor = true;
            this.btn_Brower.Click += new System.EventHandler(this.btn_Brower_Click);
            // 
            // lbl_kk_rate
            // 
            this.lbl_kk_rate.AutoSize = true;
            this.lbl_kk_rate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_kk_rate.Location = new System.Drawing.Point(454, 215);
            this.lbl_kk_rate.Name = "lbl_kk_rate";
            this.lbl_kk_rate.Size = new System.Drawing.Size(28, 14);
            this.lbl_kk_rate.TabIndex = 30;
            this.lbl_kk_rate.Text = "0/0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(33, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 29;
            this.label4.Text = "下 载 进 度：";
            // 
            // pb_kk
            // 
            this.pb_kk.Location = new System.Drawing.Point(137, 206);
            this.pb_kk.Name = "pb_kk";
            this.pb_kk.Size = new System.Drawing.Size(311, 23);
            this.pb_kk.TabIndex = 28;
            this.pb_kk.Click += new System.EventHandler(this.pb_kk_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.Location = new System.Drawing.Point(307, 292);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Size = new System.Drawing.Size(75, 23);
            this.btn_Config.TabIndex = 31;
            this.btn_Config.Text = "设置(&S)";
            this.btn_Config.UseVisualStyleBackColor = true;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Location = new System.Drawing.Point(500, 231);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(0, 12);
            this.lbl_type.TabIndex = 32;
            // 
            // pb_aera
            // 
            this.pb_aera.Location = new System.Drawing.Point(138, 236);
            this.pb_aera.Name = "pb_aera";
            this.pb_aera.Size = new System.Drawing.Size(310, 23);
            this.pb_aera.TabIndex = 33;
            // 
            // lbl_area_rate
            // 
            this.lbl_area_rate.AutoSize = true;
            this.lbl_area_rate.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_area_rate.Location = new System.Drawing.Point(454, 245);
            this.lbl_area_rate.Name = "lbl_area_rate";
            this.lbl_area_rate.Size = new System.Drawing.Size(28, 14);
            this.lbl_area_rate.TabIndex = 30;
            this.lbl_area_rate.Text = "0/0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "卡口导出";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.pb_kk_Click);
            // 
            // stat_label
            // 
            this.stat_label.BackColor = System.Drawing.SystemColors.ControlDark;
            this.stat_label.Location = new System.Drawing.Point(10, 337);
            this.stat_label.Name = "stat_label";
            this.stat_label.Size = new System.Drawing.Size(633, 55);
            this.stat_label.TabIndex = 35;
            this.stat_label.Text = "     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 401);
            this.Controls.Add(this.stat_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pb_aera);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.lbl_area_rate);
            this.Controls.Add(this.lbl_kk_rate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb_kk);
            this.Controls.Add(this.btn_Brower);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_End);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp_Start);
            this.Controls.Add(this.btn_Export);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出违法数据";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_Brower;
        private System.Windows.Forms.Label lbl_kk_rate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pb_kk;
        private System.Windows.Forms.Button btn_Config;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ProgressBar pb_aera;
        private System.Windows.Forms.Label lbl_area_rate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label stat_label;
    }
}

