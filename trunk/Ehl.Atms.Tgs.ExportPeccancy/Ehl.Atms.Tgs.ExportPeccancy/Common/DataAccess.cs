using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Ehl.Atms.Tgs.ExportPeccancy
{
    public class DataAccess
    {
        DataService.DataService dataService = new DataService.DataService();

        /// <summary>
        /// 获取图片路径
        /// </summary>
        /// <param name="xh"></param>
        /// <returns></returns>
        public DataTable GetCapture(string xh)
        {
            string sql = "select t.zjwjlj from vt_tgs_capture t where xh='" + xh + "' order by zjwjsx asc ";
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// 获取违法类型
        /// </summary>
        /// <returns></returns>
        public DataTable GetPeccancy_Type()
        {
            string sql = "select wfxw,wfxwms from T_TMS_PECCNACY_TYPE order by wfxw asc ";
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }

        /// <summary>
        /// 获取违法数据
        /// </summary>
        /// <returns></returns>
        public DataTable GetPeccancy(string startTime, string endTime, string wfxws)
        {
            string sql = string.Format(@"select xh,hpzl,hphm,wfsj,wfdz,wfdd,fxbh,clsd,cdbh,sjly,sbbh,wfxw ,clxs,jtfs from vt_tms_peccancy_export t
                       where wfsj >=to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                        and wfsj <=to_date('{1}','yyyy-mm-dd hh24:mi:ss') and wfxw in ('{2}')", startTime, endTime, wfxws);
            Log.WriteLog("违法数据sql= " +sql);
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return null;
            }
        }
        //查询区间违法
        public DataTable GetPeccancy_aera(string startTime, string endTime, string wfxws)
        {
            string sql = string.Format(@"select * from vt_tgs_peccancy_area where wfkssj >= to_date('{0}','yyyy-mm-dd hh24:mi:ss')
                                        and wfkssj <= to_date('{1}','yyyy-mm-dd hh24:mi:ss') and shbj='1' and jcbj='1' and cfbj = 0", startTime, endTime);
            Log.WriteLog("区间违法 sql = " + sql);
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("区间违法导出异常 " + ex.ToString());
                return null;
            }
        }
        //查询卡口数量
        public UInt32 GetPasscarCcount(string startTime, string endTime)
        {

            string sql = string.Format(@"select count(xh) as passcar_count from vt_tgs_passcar
                                         where gwsj >= to_date('{0}','yyyy-mm-dd hh24:mi:ss') and gwsj <= to_date('{1}','yyyy-mm-dd hh24:mi:ss')
                                          ", startTime, endTime);
            Log.WriteLog("卡口导出 sql = " + sql);
            DataTable dt = null;
            try
            {
                dt = dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("卡口导出异常 " + ex.ToString());
                return 0;
           }
           if (dt==null)
           {
               return 0;
           }
            return UInt32.Parse(dt.Rows[0]["passcar_count"].ToString());
            
        }
        //查询卡口
        public DataTable GetPassCar(string startTime, string endTime)
        {
            string sql = string.Format(@"select xh, gwsj, kkmc, f_getimagepath(xh, '1') as zjwj from vt_tgs_passcar
                                        where gwsj >= to_date('{0}','yyyy/mm/dd hh24:mi:ss') and gwsj <= to_date('{1}','yyyy/mm/dd hh24:mi:ss')
                                           ", startTime, endTime);
/*
            string sql = string.Format(@"select ttt.* from(
                select tt.* ,rownum rn 
                    from(
                        select  xh, gwsj, kkmc, f_getimagepath(xh, '1') as zjwj
                            from vt_tgs_passcar
                                where gwsj >= to_date('{0}', 'yyyy-mm-dd hh24:mi:ss')
                        and gwsj <= to_date('{1}', 'yyyy-mm-dd hh24:mi:ss') 
                        order by xh asc
                )tt 
            )ttt where ttt.rn between {2} and {3}", startTime, endTime, start_index, limit);
*/
            Log.WriteLog("卡口导出 sql = " + sql);
            try
            {
                return dataService.Get_DataSet(sql).Tables[0];
            }
            catch (Exception ex)
            {
                Log.WriteLog("卡口导出异常 " + ex.ToString());
                return null;
            }
        }
        /// <summary>
        /// 更新违法数据状态
        /// </summary>
        /// <returns></returns>
        public int UpdatePeccancy(string xh)
        {
            string sql = string.Format(@"update t_tms_peccancy t set csbj='1' where xh='{0}' ", xh);
            try
            {
                return dataService.Execute_NonQuery(sql);
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog(ex.ToString());
                return -1;
            }
        }

        //更新区间违法数据状态
        public int UpdatePeccancy_aera(string xh)
        {
            string sql = string.Format(@"update t_tgs_peccancy_area set csbj='1' where xh='{0}'", xh);
            try
            {
                return dataService.Execute_NonQuery(sql);
            }
            catch (Exception ex)
            {
                Log.WriteLog("sql:" + sql);
                Log.WriteLog("更新区间违法异常，" + ex.ToString());
                return -1;
            }
        }
    }
}
