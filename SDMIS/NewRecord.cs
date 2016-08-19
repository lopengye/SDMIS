using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SDMIS
{
    public partial class NewRecord : Form
    {
        private static float f_WaterPrice = 0;
        private static float f_PowerPrice = 0;
        private static DateTime dt_LastTime;

        public NewRecord()
        {
            InitializeComponent();
        }

        private void NewRecord_Load(object sender, EventArgs e)
        {
            BindLastTime();
            BindPrice();
        }

        //
        private void BindData()
        {
            string sql_bind = "select tb_data.*,tb_house.h_Name,tb_house.h_Remark from tb_data left join tb_house on tb_house.h_ID=tb_data.d_h_ID where tb_data.d_LastTime=#" + dt_LastTime.ToShortDateString() + "# and tb_data.d_ThisTime=#" + dtpThis.Value.ToShortDateString() + "#";
            dgvNewRecord.DataSource = OleDbHelp.GetDataTable(sql_bind);
        }

        //获取水电价格
        private void BindPrice()
        {
            f_WaterPrice = float.Parse(OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='WaterPrice'").ToString());
            f_PowerPrice = float.Parse(OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='PowerPrice'").ToString());
            lbWaterPrice.Text = f_WaterPrice.ToString();
            lbPowerPrice.Text = f_PowerPrice.ToString();
        }

        //获取上次抄表时间
        private void BindLastTime()
        {
            dt_LastTime= dtpLast.Value = DateTime.Parse(OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='LastTime'").ToString());
        }

        private void NewRecord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                this.Close();
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            BaseData baseData = new BaseData();
            baseData.ShowDialog();
            BindPrice();
            BindLastTime();
        }

        //添加数据按钮，先把数据添加到数据中，然后读出来
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int days = Convert.ToInt32((dtpThis.Value - dtpLast.Value).Days);
            if (days>=0)
            {
                if (days < 30)
                {
                    if (DialogResult.No == MessageBox.Show(this, "距离上次添加抄表记录只有" + days + "天\n距离上次添加抄表记录还不到30天的时间，确定要添加吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("抄表时间设置错误，请检查！","提示");
                return;
            }
            

            int hid = 0;
            string pname = "";
            string pcard = "";
            string pdepartment = "";
            float lastwater = 0;
            float lastpower = 0;
            int flag = 0;//标记总共新建多少条数据
            string sql_house = "select tb_house.*,tb_people.p_Name,tb_people.p_Card,tb_people.p_Department from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
            string sql_lastwater = "";
            string sql_lastpower = "";
            string sql_check = "";
            DataTable dt_house = OleDbHelp.GetDataTable(sql_house);
            int len = dt_house.Rows.Count;//行数
            if (len>0)
            {
                for (int i = 0; i < len; i++)
                {
                    hid = Convert.ToInt32(dt_house.Rows[i]["h_ID"].ToString());
                    sql_check = "select d_ID from tb_data where d_h_ID="+hid+" and d_LastTime=#"+dt_LastTime.ToShortDateString()+"#";
                    if (null!=OleDbHelp.selectExecute(sql_check))
                    {
                        continue;
                    }
                    if (dt_house.Rows[i]["p_Name"].ToString() == "")
                    {
                        pname = "";
                    }
                    else
                    {
                        pname =dt_house.Rows[i]["p_Name"].ToString();
                    }
                    pcard = dt_house.Rows[i]["p_Card"].ToString();
                    pdepartment = dt_house.Rows[i]["p_Department"].ToString();
                    #region 获取上次记录的水电读数
                    sql_lastwater = "select d_ThisWater from tb_data where d_h_ID=" + hid + " and d_ThisTime=#" + dt_LastTime.ToShortDateString() + "#";
                    if (null != OleDbHelp.selectExecute(sql_lastwater))
                    {
                        lastwater = float.Parse(OleDbHelp.selectExecute(sql_lastwater).ToString());
                    }
                    else
                    {
                        lastwater = 0;
                    }
                    sql_lastpower = "select d_ThisPower from tb_data where d_h_ID=" + hid + " and d_ThisTime=#" + dt_LastTime.Date.ToShortDateString() + "#";
                    if (null != OleDbHelp.selectExecute(sql_lastpower))
                    {
                        lastpower = float.Parse(OleDbHelp.selectExecute(sql_lastpower).ToString());
                    }
                    else
                    {
                        lastpower = 0;
                    }
                    #endregion
                    string sql_insert = "insert into tb_data(d_h_ID,d_p_Name,d_p_Card,d_p_Department,d_LastWater,d_LastPower,d_LastTime,d_ThisTime) values(@dhid,@dpname,@dpcard,@dpdepartment,@dlastwater,@dlastpower,@dlasttime,@dthistime)";
                    OleDbParameter[] para_insert = { 
                                                   new OleDbParameter("@dhid",hid),
                                                   new OleDbParameter("@dpname",pname),
                                                   new OleDbParameter("@dpcard",pcard),
                                                   new OleDbParameter("@dpdepartment",pdepartment),
                                                   new OleDbParameter("@dlastwater",lastwater),
                                                   new OleDbParameter("@dlastpower",lastpower),
                                                   new OleDbParameter("@dlasttime",dt_LastTime.ToShortDateString()),
                                                   new OleDbParameter("@dthistime",dtpThis.Value.ToShortDateString())
                                                   };
                    flag += OleDbHelp.Execute(sql_insert, para_insert);
                }
                if (flag>0)
                {
                    string sql_lasttime = "update tb_base set b_Value=@thistime where b_Type='LastTime'";
                    OleDbParameter[] para_lasttime = { 
                                             new OleDbParameter("@thistime",dtpThis.Value.ToShortDateString())
                                             };
                    int flag_lasttime = OleDbHelp.Execute(sql_lasttime, para_lasttime);
                    if (flag_lasttime>0)
                    {
                        BindData();
                        this.btnAdd.Enabled = false;
                        this.btnSave.Enabled = true;
                        this.dtpLast.Enabled = false;
                        this.dtpThis.Enabled = false;
                        btnOut.Enabled = true;
                        btnExport.Enabled = true;
                        btnExportByCard.Enabled = true;
                        MessageBox.Show("共生成" + flag + "条数据", "提示");
                        return;
                    }
                    else
                    {
                        BindData();
                        this.btnAdd.Enabled = false;
                        this.btnSave.Enabled = true;
                        this.dtpLast.Enabled = false;
                        this.dtpThis.Enabled = false;
                        btnOut.Enabled = true;
                        btnExport.Enabled = true;
                        btnExportByCard.Enabled = true;
                        MessageBox.Show("共生成"+flag+"条数据，但更新时间失败\n请到基本数据管理界面手动更新！", "提示");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("生成失败，请重试！", "提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("暂无住房数据，请在住房管理界面添加数据！", "提示");
                return;
            }
        }

        //保存表中数据到数据库--更新
        private void btnSave_Click(object sender, EventArgs e)
        {
            int len = dgvNewRecord.Rows.Count;
            if (len<=0)
            {
                MessageBox.Show("表中没有数据，请先添加！","提示");
                return;
            }

            int did = 0;
            string pcard = "";
            string pdepartment = "";
            string lasttime = "";
            string thistime = "";
            float lastwater = 0;
            float thiswater = 0;
            float lastpower = 0;
            float thispower = 0;
            float watercount = 0;
            float powercount = 0;
            float watermoney = 0;
            float powermoney = 0;
            float allmoney = 0;

            string sql_update = "";
            int flag_update = 0;

            for (int i = 0; i < len; i++)
            {
                did = Convert.ToInt32(dgvNewRecord.Rows[i].Cells["d_ID"].Value);
                pcard = dgvNewRecord.Rows[i].Cells["d_p_Card"].Value.ToString();
                pdepartment = dgvNewRecord.Rows[i].Cells["d_p_Department"].Value.ToString();
                try
                {
                    lasttime = Convert.ToDateTime(dgvNewRecord.Rows[i].Cells["d_LastTime"].Value.ToString()).ToShortDateString();
                    thistime = Convert.ToDateTime(dgvNewRecord.Rows[i].Cells["d_ThisTime"].Value.ToString()).ToShortDateString();
                }
                catch (Exception)
                {
                    throw;
                }

                #region 获取各种数据，有验证
                //水
                if (dgvNewRecord.Rows[i].Cells["d_LastWater"].Value.ToString() == "")
                {
                    lastwater = 0;
                }
                else
                {
                    lastwater = float.Parse(dgvNewRecord.Rows[i].Cells["d_LastWater"].Value.ToString());
                }
                if (dgvNewRecord.Rows[i].Cells["d_ThisWater"].Value.ToString()=="")
                {
                    thiswater = 0;
                }
                else
                {
                    thiswater = float.Parse(dgvNewRecord.Rows[i].Cells["d_ThisWater"].Value.ToString());
                }
                //电
                if (dgvNewRecord.Rows[i].Cells["d_LastPower"].Value.ToString()=="")
                {
                    lastpower = 0;
                }
                else
                {
                    lastpower = float.Parse(dgvNewRecord.Rows[i].Cells["d_LastPower"].Value.ToString());
                }
                if (dgvNewRecord.Rows[i].Cells["d_ThisPower"].Value.ToString()=="")
                {
                    thispower = 0;
                }
                else
                {
                    thispower = float.Parse(dgvNewRecord.Rows[i].Cells["d_ThisPower"].Value.ToString());
                }
                #region 暂存
                //if (dgvNewRecord.Rows[i].Cells["d_WaterCount"].Value.ToString() == "")
                //{
                //    watercount = 0;
                //}
                //else
                //{
                //    watercount = float.Parse(dgvNewRecord.Rows[i].Cells["d_WaterCount"].Value.ToString());
                //}
                //if (dgvNewRecord.Rows[i].Cells["d_PowerCount"].Value.ToString() == "")
                //{
                //    powercount = 0;
                //}
                //else
                //{
                //    powercount = float.Parse(dgvNewRecord.Rows[i].Cells["d_PowerCount"].Value.ToString());
                //}
                //if (dgvNewRecord.Rows[i].Cells["d_WaterMoney"].Value.ToString() == "")
                //{
                //    watermoney = 0;
                //}
                //else
                //{
                //    watermoney = float.Parse(dgvNewRecord.Rows[i].Cells["d_WaterMoney"].Value.ToString());
                //}
                //if (dgvNewRecord.Rows[i].Cells["d_PowerMoney"].Value.ToString() == "")
                //{
                //    powermoney = 0;
                //}
                //else
                //{
                //    powermoney = float.Parse(dgvNewRecord.Rows[i].Cells["d_PowerMoney"].Value.ToString());
                //}
                //if (dgvNewRecord.Rows[i].Cells["d_AllMoney"].Value.ToString() == "")
                //{
                //    allmoney = 0;
                //}
                //else
                //{
                //    allmoney = float.Parse(dgvNewRecord.Rows[i].Cells["d_AllMoney"].Value.ToString());
                //}
                #endregion
                #endregion

                watercount = thiswater - lastwater;
                powercount = thispower - lastpower;
                if (watercount < 0)
                {
                    if (DialogResult.No == MessageBox.Show(this, "在第" + (i + 1) + "行出现本月水表读数小于上月水表读数的现象\n点击取消返回修改数据\n点击确定用水量按0计算\n以后可在数据管理界面手动修改。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        return;
                    }
                    watercount = 0;
                }
                if (powercount < 0)
                {
                    if (DialogResult.No == MessageBox.Show(this, "在第" + (i + 1) + "行出现本月电表读数小于上月电表读数的现象\n点击取消返回修改数据\n点击确定用电量按0计算\n以后可在数据管理界面手动修改。", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                    {
                        return;
                    }
                    powercount = 0;
                }
                watermoney = watercount * f_WaterPrice;
                powermoney = powercount * f_PowerPrice;
                allmoney = watermoney + powermoney;


                //更新操作
                sql_update = "update tb_data set d_p_Card=@dpcard,d_p_Department=@dpdepartment,d_LastTime=@dlasttime,d_ThisTime=@dthistime,d_LastWater=@dlastwater,d_ThisWater=@dthiswater,d_LastPower=@d_lastpower,d_ThisPower=@dthispower,d_WaterCount=@dwatercount,d_PowerCount=@dpowercount,d_WaterMoney=@dwatermoney,d_PowerMoney=@dpowermoney,d_AllMoney=@dallmoney where d_ID=@did";
                OleDbParameter[] para_update = { 
                                               new OleDbParameter("@dpcard",pcard),
                                               new OleDbParameter("@dpdepartment",pdepartment),
                                               new OleDbParameter("@dlasttime",lasttime),
                                               new OleDbParameter("@dthistime",thistime),
                                               new OleDbParameter("@dlastwater",lastwater),
                                               new OleDbParameter("@dthiswater",thiswater),
                                               new OleDbParameter("@dlastpower",lastpower),
                                               new OleDbParameter("@dthispower",thispower),
                                               new OleDbParameter("@dwatercount",watercount),
                                               new OleDbParameter("@dpowercount",powercount),
                                               new OleDbParameter("@dwatermoney",watermoney),
                                               new OleDbParameter("@dpowermoney",powermoney),
                                               new OleDbParameter("@dallmoney",allmoney),
                                               new OleDbParameter("@did",did)
                                               };
                flag_update += OleDbHelp.Execute(sql_update,para_update);
            }
            if (flag_update>0)
            {
                BindData();
                MessageBox.Show("保存成功！","提示");
                return;
            }
            else
            {
                MessageBox.Show("保存失败，请重试！", "提示");
                return;
            }
        }

        //导出数据
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExport_Click(object sender, EventArgs e)
        {
            OleDbConnection connExcel = OleDbHelp.conn;
            try
            {
                SaveFileDialog sfdExcel = new SaveFileDialog();
                sfdExcel.Filter=("Excel 文件(*.xls)|*.xls");
                if (sfdExcel.ShowDialog()==DialogResult.OK)
                {
                    string fileName = sfdExcel.FileName;
                    if (System.IO.File.Exists(fileName))
                    {
                        System.IO.File.Delete(fileName);
                    }
                    int index = fileName.LastIndexOf("//");//获取最后一个/的索引
                    fileName = fileName.Substring(index+1);//获取excel名称
                    string sqlExcel = "select top 65535 tb_house.h_Name as 住房名称,tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 银行卡账号,tb_data.d_p_Department as 部门编号,tb_house.h_Remark as 房屋备注,Format(tb_data.d_LastTime)+'至'+Format(tb_data.d_ThisTime) as 抄表时间段,tb_data.d_LastWater as 上次水表读数,tb_data.d_ThisWater as 本次水表读数,tb_data.d_LastPower as 上次电表读数,tb_data.d_ThisPower as 本次电表读数,tb_data.d_WaterCount as 用水量,tb_data.d_PowerCount as 用电量,tb_data.d_WaterMoney as 水费,tb_data.d_PowerMoney as 电费,tb_data.d_AllMoney as 合计费用 into [Excel 8.0;database=" + fileName + "].[sheet1] from tb_data left join (tb_house left join tb_people on tb_house.h_p_ID=tb_people.p_ID) on tb_house.h_ID=tb_data.d_h_ID where tb_data.d_LastTime=#" + dt_LastTime.ToShortDateString() + "# and tb_data.d_ThisTime=#" + dtpThis.Value.ToShortDateString() + "#";
                    OleDbCommand commExcel = new OleDbCommand(sqlExcel,connExcel);
                    connExcel.Open();
                    commExcel.ExecuteNonQuery();
                    connExcel.Close();
                    MessageBox.Show(this,"导出数据成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("导出数据失败，请重试！","提示");
                return;
            }
        }

        private void dgvNewRecord_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(this, "输入数据有格式错误，请检查以后再保存！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        //按账号导出，包括：人员姓名，账号，
        private void btnExportByCard_Click(object sender, EventArgs e)
        {
            OleDbConnection connExcel = OleDbHelp.conn;
            try
            {
                SaveFileDialog sfdExcel = new SaveFileDialog();
                sfdExcel.Filter = ("Excel 文件(*.xls)|*.xls");
                sfdExcel.FileName = "按人员姓名导出";
                if (sfdExcel.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfdExcel.FileName;
                    if (System.IO.File.Exists(fileName))
                    {
                        System.IO.File.Delete(fileName);
                    }
                    int index = fileName.LastIndexOf("//");//获取最后一个/的索引
                    fileName = fileName.Substring(index + 1);//获取excel名称
                    //string sqlExcel = "select top 65535 tb_house.h_Name as 住房名称,tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 银行卡账号,tb_data.d_p_Department as 部门编号,tb_house.h_Remark as 房屋备注,Format(tb_data.d_LastTime)+'至'+Format(tb_data.d_ThisTime) as 抄表时间段,tb_data.d_LastWater as 上次水表读数,tb_data.d_ThisWater as 本次水表读数,tb_data.d_LastPower as 上次电表读数,tb_data.d_ThisPower as 本次电表读数,tb_data.d_WaterCount as 用水量,tb_data.d_PowerCount as 用电量,tb_data.d_WaterMoney as 水费,tb_data.d_PowerMoney as 电费,tb_data.d_AllMoney as 合计费用 into [Excel 8.0;database=" + fileName + "].[sheet1] from tb_data left join (tb_house left join tb_people on tb_house.h_p_ID=tb_people.p_ID) on tb_house.h_ID=tb_data.d_h_ID where tb_data.d_LastTime=#" + dt_LastTime.ToShortDateString() + "# and tb_data.d_ThisTime=#" + dtpThis.Value.ToShortDateString() + "#";
                    string sqlExcel = "select top 65535 tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 账号, sum(tb_data.d_WaterMoney) as 水费,sum(tb_data.d_PowerMoney) as 电费, sum(tb_data.d_AllMoney) as 合计费用 into [Excel 8.0;database=" + fileName + "].[sheet1] from tb_data where tb_data.d_LastTime=#" + dt_LastTime.ToShortDateString() + "# and tb_data.d_ThisTime=#" + dtpThis.Value.ToShortDateString() + "# group by tb_data.d_p_Name,tb_data.d_p_Card order by tb_data.d_p_Name";
                    OleDbCommand commExcel = new OleDbCommand(sqlExcel, connExcel);
                    connExcel.Open();
                    commExcel.ExecuteNonQuery();
                    connExcel.Close();
                    MessageBox.Show(this, "导出数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("导出数据失败，请重试！", "提示");
                return;
            }
        }

        //批量处理——导出
        private void btnOut_Click(object sender, EventArgs e)
        {
            OleDbConnection connExcel = OleDbHelp.conn;
            try
            {
                SaveFileDialog sfdExcel = new SaveFileDialog();
                sfdExcel.Filter=("Excel文件(*.xls)|*.xls");
                sfdExcel.FileName = "本月水电数据导出文件";
                if (sfdExcel.ShowDialog()==DialogResult.OK)
                {
                    string fileName = sfdExcel.FileName;
                    if (System.IO.File.Exists(fileName))
                    {
                        System.IO.File.Delete(fileName);
                    }
                    int index = fileName.LastIndexOf("//");
                    fileName = fileName.Substring(index+1);
                    string sqlExcel = "select top 65535 tb_data.d_ID as 自动编号,tb_house.h_Name as 住房名称,tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 银行卡账号,tb_data.d_p_Department as 部门编号,tb_house.h_Remark as 房屋备注,Format(tb_data.d_LastTime) as 上次抄表时间,Format(tb_data.d_ThisTime) as 本次抄表时间,tb_data.d_LastWater as 上次水表读数,tb_data.d_ThisWater as 本次水表读数,tb_data.d_LastPower as 上次电表读数,tb_data.d_ThisPower as 本次电表读数 into [Excel 8.0;database=" + fileName + "].[sheet1] from tb_data left join (tb_house left join tb_people on tb_house.h_p_ID=tb_people.p_ID) on tb_house.h_ID=tb_data.d_h_ID where tb_data.d_LastTime=#" + dt_LastTime.ToShortDateString() + "# and tb_data.d_ThisTime=#" + dtpThis.Value.ToShortDateString() + "#";
                    OleDbCommand commExcel = new OleDbCommand(sqlExcel,connExcel);
                    connExcel.Open();
                    commExcel.ExecuteNonQuery();
                    connExcel.Close();
                    btnIn.Enabled = true;
                    MessageBox.Show(this, "导出数据成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("导出数据失败，请重试！", "提示");
                throw;
            }
        }

        //批量处理——导入
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                ofdExcel.Filter = ("Excel文件(*.xls)|*.xls");
                if (ofdExcel.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofdExcel.FileName;
                    //int s = fileName.LastIndexOf(".");
                    //string f = fileName.Substring(s+1);
                    if (fileName == "")
                    {
                        MessageBox.Show("未选择任何文件！", "提示");
                        return;
                    }
                    if (fileName.Substring(fileName.LastIndexOf(".") + 1) != "xls")
                    {
                        MessageBox.Show("请选择Excel(*.xls)文件！", "提示");
                        return;
                    }

                    #region 变量定义
                    bool smaller = false;

                    int did = 0;
                    //string hname = "";
                    //string pname = "";
                    //string pcard = "";
                    //string lasttime = "";
                    //string thistime = "";
                    float lastwater = 0;
                    float thiswater = 0;
                    float lastpower = 0;
                    float thispower = 0;
                    float watercount = 0;
                    float powercount = 0;
                    float watermoney = 0;
                    float powermoney = 0;
                    float allmoney = 0;

                    string sql_update = "";
                    int flag_update = 0;
                    #endregion

                    OleDbConnection connExcel = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=;Extended properties=Excel 5.0;Data Source=" + fileName);
                    connExcel.Open();
                    string get_data = "SELECT * FROM [Sheet1$]";
                    OleDbCommand commExcel = new OleDbCommand(get_data, connExcel);
                    OleDbDataReader dr = commExcel.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            did = Convert.ToInt32(dr.GetValue(0));
                            //hname = dr.GetValue(1).ToString();
                            //pname = dr.GetValue(2).ToString();
                            //pcard = dr.GetValue(3).ToString();
                            //lasttime = dr.GetValue(6).ToString();
                            //thistime = dr.GetValue(7).ToString();
                            //lastwater=
                            #region 获取数据并验证
                            //水
                            if (dr.GetValue(8).ToString() == "")
                            {
                                lastwater = 0;
                            }
                            else
                            {
                                lastwater = float.Parse(dr.GetValue(8).ToString());
                            }
                            if (dr.GetValue(9).ToString() == "")
                            {
                                thiswater = 0;
                            }
                            else
                            {
                                thiswater = float.Parse(dr.GetValue(9).ToString());
                            }
                            //电
                            if (dr.GetValue(10).ToString() == "")
                            {
                                lastpower = 0;
                            }
                            else
                            {
                                lastpower = float.Parse(dr.GetValue(10).ToString());
                            }
                            if (dr.GetValue(11).ToString() == "")
                            {
                                thispower = 0;
                            }
                            else
                            {
                                thispower = float.Parse(dr.GetValue(11).ToString());
                            }

                            watercount = thiswater - lastwater;
                            powercount = thispower - lastpower;
                            if (watercount < 0)
                            {
                                smaller = true;
                                watercount = 0;
                            }
                            if (powercount < 0)
                            {
                                smaller = true;
                                powercount = 0;
                            }
                            watermoney = watercount * f_WaterPrice;
                            powermoney = powercount * f_PowerPrice;
                            allmoney = watermoney + powermoney;
                            #endregion
                            #region 更新操作
                            //sql_update = "update tb_data set d_p_Card=@dpcard,d_LastTime=@dlasttime,d_ThisTime=@dthistime,d_LastWater=@dlastwater,d_ThisWater=@dthiswater,d_LastPower=@d_lastpower,d_ThisPower=@dthispower,d_WaterCount=@dwatercount,d_PowerCount=@dpowercount,d_WaterMoney=@dwatermoney,d_PowerMoney=@dpowermoney,d_AllMoney=@dallmoney where d_ID=@did";
                            sql_update = "update tb_data set d_LastWater=@dlastwater,d_ThisWater=@dthiswater,d_LastPower=@dlastpower,d_ThisPower=@dthispower,d_WaterCount=@dwatercount,d_PowerCount=@dpowercount,d_WaterMoney=@dwatermoney,d_PowerMoney=@dpowermoney,d_AllMoney=@dallmoney where d_ID=@did";
                            OleDbParameter[] para_update = { 
                                               new OleDbParameter("@dlastwater",lastwater),
                                               new OleDbParameter("@dthiswater",thiswater),
                                               new OleDbParameter("@dlastpower",lastpower),
                                               new OleDbParameter("@dthispower",thispower),
                                               new OleDbParameter("@dwatercount",watercount),
                                               new OleDbParameter("@dpowercount",powercount),
                                               new OleDbParameter("@dwatermoney",watermoney),
                                               new OleDbParameter("@dpowermoney",powermoney),
                                               new OleDbParameter("@dallmoney",allmoney),
                                               new OleDbParameter("@did",did)
                                               };
                            flag_update += OleDbHelp.Execute(sql_update, para_update);
                            #endregion
                        }
                        dr.Close();
                        connExcel.Close();
                        if (flag_update > 0)
                        {
                            BindData();
                            if (smaller)
                            {
                                MessageBox.Show("导入成功，但是出现本次抄表记录小于上次抄表记录的现象\n该现象将导致用户数据为负值，现已按0处理\n请仔细检查文件中数据，并重新导入\n也可在数据管理界面进行修改！", "提示");
                                return;
                            }
                            else
                            {
                                MessageBox.Show("导入成功！", "提示");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("导入失败，请重试！", "提示");
                            return;
                        }
                    }
                    else
                    {
                        dr.Close();
                        connExcel.Close();
                        MessageBox.Show("该文件中没有数据！", "提示");
                        return;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("导入失败，请重试！", "提示");
                return;
            }
        }
    }
}
