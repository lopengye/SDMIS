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
    public partial class DataManage : Form
    {
        private static string sql_bind = "select tb_data.*,tb_house.h_Name,tb_house.h_Remark from tb_data left join tb_house on tb_house.h_ID=tb_data.d_h_ID";
        private static string sql_end = " order by tb_data.d_ID";

        private static float f_WaterPrice = 0;
        private static float f_PowerPrice = 0;
        public DataManage()
        {
            InitializeComponent();
        }

        private void DataManage_Load(object sender, EventArgs e)
        {
            BindPrice();
            if (Convert.ToInt32 (OleDbHelp.selectExecute("select count(*) from tb_data"))>100000)
            {
                MessageBox.Show("系统中存在的数据已经超过100000条，过多的数据会影响系统响应速度\n请及时清除无用数据！","提示");
            }
        }

        //数据绑定
        private void BindData()
        {
            dgvDataManage.DataSource = OleDbHelp.GetDataTable(sql_bind+sql_end);
        }

        //获取水电价格
        private void BindPrice()
        {
            f_WaterPrice = float.Parse(OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='WaterPrice'").ToString());
            f_PowerPrice = float.Parse(OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='PowerPrice'").ToString());
            lbWaterPrice.Text = f_WaterPrice.ToString();
            lbPowerPrice.Text = f_PowerPrice.ToString();
        }

        private void DataManage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                this.Close();
            }
        }

        //单元格单击事件
        private void dgvDataManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvDataManage.Rows.Count<=0)
            {
                return;
            }
            if (this.dgvDataManage.CurrentRow.Cells["select"].Selected)
            {
                if (this.dgvDataManage.CurrentRow.Cells["select"].FormattedValue.ToString() == "False")
                {
                    this.dgvDataManage.CurrentRow.Cells["select"].Value = true;
                }
                else
                {
                    this.dgvDataManage.CurrentRow.Cells["select"].Value = false;
                }
            }
        }

        private void dgvDataManage_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(this, "输入数据有格式错误，请检查！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        //保存按钮
        private void btnSave_Click(object sender, EventArgs e)
        {
            int len = dgvDataManage.Rows.Count;
            if (len<=0)
            {
                MessageBox.Show("暂无数据！","提示");
                return;
            }

            #region 变量定义
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
            #endregion

            for (int i = 0; i < len; i++)
            {
                did = Convert.ToInt32(dgvDataManage.Rows[i].Cells["d_ID"].Value);
                pcard = dgvDataManage.Rows[i].Cells["d_p_Card"].Value.ToString();
                pdepartment = dgvDataManage.Rows[i].Cells["d_p_Department"].Value.ToString();
                try
                {
                    lasttime = Convert.ToDateTime(dgvDataManage.Rows[i].Cells["d_LastTime"].Value.ToString()).ToShortDateString();
                    thistime = Convert.ToDateTime(dgvDataManage.Rows[i].Cells["d_ThisTime"].Value.ToString()).ToShortDateString();
                }
                catch (Exception)
                {
                    throw;
                }
                #region 获取各种数据，有验证
                //水读数
                if (dgvDataManage.Rows[i].Cells["d_LastWater"].Value.ToString() == "")
                {
                    lastwater = 0;
                }
                else
                {
                    lastwater = float.Parse(dgvDataManage.Rows[i].Cells["d_LastWater"].Value.ToString());
                }
                if (dgvDataManage.Rows[i].Cells["d_ThisWater"].Value.ToString() == "")
                {
                    thiswater = 0;
                }
                else
                {
                    thiswater = float.Parse(dgvDataManage.Rows[i].Cells["d_ThisWater"].Value.ToString());
                }
                //电
                if (dgvDataManage.Rows[i].Cells["d_LastPower"].Value.ToString() == "")
                {
                    lastpower = 0;
                }
                else
                {
                    lastpower = float.Parse(dgvDataManage.Rows[i].Cells["d_LastPower"].Value.ToString());
                }
                if (dgvDataManage.Rows[i].Cells["d_ThisPower"].Value.ToString() == "")
                {
                    thispower = 0;
                }
                else
                {
                    thispower = float.Parse(dgvDataManage.Rows[i].Cells["d_ThisPower"].Value.ToString());
                }

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
                #endregion
                #region 更新操作
                //更新操作
                sql_update = "update tb_data set d_p_Card=@dpcard,d_p_Department=@dpdepartment,d_LastTime=@dlasttime,d_ThisTime=@dthistime,d_LastWater=@dlastwater,d_ThisWater=@dthiswater,d_LastPower=@dlastpower,d_ThisPower=@dthispower,d_WaterCount=@dwatercount,d_PowerCount=@dpowercount,d_WaterMoney=@dwatermoney,d_PowerMoney=@dpowermoney,d_AllMoney=@dallmoney where d_ID=@did";
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
                flag_update += OleDbHelp.Execute(sql_update, para_update);
                #endregion
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

        //删除按钮
        private void btnDel_Click(object sender, EventArgs e)
        {
            bool NotEmpty = false;
            int len = dgvDataManage.Rows.Count;
            int flag_del = 0;
            string sql_del = "";
            for (int i = 0; i < len; i++)
            {
                if (dgvDataManage.Rows[i].Cells["select"].FormattedValue.ToString()=="True")
                {
                    NotEmpty = true;
                    break;
                }
            }
            if (NotEmpty)
            {
                if (DialogResult.Yes==MessageBox.Show(this,"确定删除？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                {
                    for (int i = 0; i < len; i++)
                    {
                        if (dgvDataManage.Rows[i].Cells["select"].FormattedValue.ToString() == "True")
                        {
                            sql_del = "delete from tb_data where d_ID=@did";
                            OleDbParameter[] para_del = { 
                                                            new OleDbParameter("@did",dgvDataManage.Rows[i].Cells["d_ID"].Value.ToString())
                                                            };
                            flag_del += OleDbHelp.Execute(sql_del, para_del);
                        }
                    }
                    if (flag_del>0)
                    {
                        BindData();
                        MessageBox.Show("成功删除"+flag_del+"行数据！","提示");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("删除失败，请重试！", "提示");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("未选中任何行！","提示");
                return;
            }
        }

        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            sql_bind = "select tb_data.*,tb_house.h_Name,tb_house.h_Remark from tb_data left join tb_house on tb_house.h_ID=tb_data.d_h_ID";
            sql_bind += " where tb_data.d_LastTime>=#" + dtpFrom.Value.ToShortDateString() + "# and tb_data.d_ThisTime<=#" + dtpTo.Value.ToShortDateString() + "#";
            BindData();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            sql_bind = "select tb_data.*,tb_house.h_Name,tb_house.h_Remark from tb_data left join tb_house on tb_house.h_ID=tb_data.d_h_ID";
            BindData();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            int len = dgvDataManage.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvDataManage.Rows[i].Cells["select"].Value = true;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            int len = dgvDataManage.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvDataManage.Rows[i].Cells["select"].Value = false;
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            int len = dgvDataManage.Rows.Count;//获取总行数
            for (int i = 0; i < len; i++)
            {
                if (dgvDataManage.Rows[i].Cells["select"].FormattedValue.ToString() == "True")
                {
                    dgvDataManage.Rows[i].Cells["select"].Value = "False";
                }
                else
                {
                    dgvDataManage.Rows[i].Cells["select"].Value = "True";
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            BaseData baseData = new BaseData();
            baseData.ShowDialog();
            BindPrice();
        }

        //导出详细信息的Excel
        private void btnExport_Click(object sender, EventArgs e)
        {
            OleDbConnection connExcel = OleDbHelp.conn;
            try
            {
                SaveFileDialog sfdExcel = new SaveFileDialog();
                sfdExcel.Filter = ("Excel 文件(*.xls)|*.xls");
                if (sfdExcel.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfdExcel.FileName;
                    if (System.IO.File.Exists(fileName))
                    {
                        System.IO.File.Delete(fileName);
                    }
                    int index = fileName.LastIndexOf("//");//获取最后一个/的索引
                    fileName = fileName.Substring(index + 1);//获取excel名称
                    //string sqlExcel ="select top 65535 tb_house.h_Name as 住房名称,tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 银行卡账号,tb_data.d_p_Department as 部门编号,tb_house.h_Remark as 房屋备注,Format(tb_data.d_LastTime)+'至'+Format(tb_data.d_ThisTime) as 抄表时间段,tb_data.d_LastWater as 上次水表读数,tb_data.d_ThisWater as 本次水表读数,tb_data.d_LastPower as 上次电表读数,tb_data.d_ThisPower as 本次电表读数,tb_data.d_WaterCount as 用水量,tb_data.d_PowerCount as 用电量,tb_data.d_WaterMoney as 水费,tb_data.d_PowerMoney as 电费,tb_data.d_AllMoney as 合计费用 into [Excel 8.0;database=" + fileName + "].[sheet1] ";
                    string sqlExcel = "select top 65535 tb_house.h_Name as 住房名称,tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 银行卡账号,tb_data.d_p_Department as 部门编号,tb_house.h_Remark as 房屋备注,Format(tb_data.d_LastTime)+'至'+Format(tb_data.d_ThisTime) as 抄表时间段,tb_data.d_LastWater as 上次水表读数,tb_data.d_ThisWater as 本次水表读数,tb_data.d_LastPower as 上次电表读数,tb_data.d_ThisPower as 本次电表读数,tb_data.d_WaterCount as 用水量,tb_data.d_PowerCount as 用电量,tb_data.d_WaterMoney as 水费,tb_data.d_PowerMoney as 电费,tb_data.d_AllMoney as 合计费用 into [Excel 8.0;database=" + fileName + "].[sheet1] ";
                    sqlExcel += (sql_bind + sql_end).Substring((sql_bind.LastIndexOf("from")));
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

        private void txtHouse_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                sql_bind = "select tb_data.*,tb_house.h_Name,tb_house.h_Remark from tb_data left join tb_house on tb_house.h_ID=tb_data.d_h_ID";
                sql_bind += " where h_Name like '%" + txtHouse.Text.Trim() + "%'";
                BindData();
            }
        }

        private void txtPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                sql_bind = "select tb_data.*,tb_house.h_Name,tb_house.h_Remark from tb_data left join tb_house on tb_house.h_ID=tb_data.d_h_ID";
                sql_bind += " where d_p_Name like '%" + txtPeople.Text.Trim() + "%'";
                BindData();
            }
        }

        //按账号导出数据，包括：姓名，账号，水费，电费，合计费用
        private void btnExportByPeople_Click(object sender, EventArgs e)
        {
            OleDbConnection connExcel = OleDbHelp.conn;
            try
            {
                SaveFileDialog sfdExcel = new SaveFileDialog();
                sfdExcel.Filter = ("Excel 文件(*.xls)|*.xls");
                if (sfdExcel.ShowDialog() == DialogResult.OK)
                {
                    string fileName = sfdExcel.FileName;
                    if (System.IO.File.Exists(fileName))
                    {
                        System.IO.File.Delete(fileName);
                    }
                    int index = fileName.LastIndexOf("//");//获取最后一个/的索引
                    fileName = fileName.Substring(index + 1);//获取excel名称
                    //string sqlExcel ="select top 65535 tb_house.h_Name as 住房名称,tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 银行卡账号,tb_data.d_p_Department as 部门编号,tb_house.h_Remark as 房屋备注,Format(tb_data.d_LastTime)+'至'+Format(tb_data.d_ThisTime) as 抄表时间段,tb_data.d_LastWater as 上次水表读数,tb_data.d_ThisWater as 本次水表读数,tb_data.d_LastPower as 上次电表读数,tb_data.d_ThisPower as 本次电表读数,tb_data.d_WaterCount as 用水量,tb_data.d_PowerCount as 用电量,tb_data.d_WaterMoney as 水费,tb_data.d_PowerMoney as 电费,tb_data.d_AllMoney as 合计费用 into [Excel 8.0;database=" + fileName + "].[sheet1] ";
                    string sqlExcel = "select top 65535 tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 账号, sum(tb_data.d_WaterMoney) as 水费,sum(tb_data.d_PowerMoney) as 电费, sum(tb_data.d_AllMoney) as 合计费用 into [Excel 8.0;database=" + fileName + "].[sheet1] ";
                    sqlExcel += sql_bind.Substring((sql_bind.LastIndexOf("from")))+" group by tb_data.d_p_Name,tb_data.d_p_Card order by tb_data.d_p_Name";
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

        //批量操作——导出
        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                sfdExcel.Filter = ("Excel文件(*.xls)|*.xls");
                sfdExcel.FileName = "本月水电数据导出文件";
                if (sfdExcel.ShowDialog()==DialogResult.OK)
                {
                    string fileName = sfdExcel.FileName;
                    if (System.IO.File.Exists(fileName))
                    {
                        System.IO.File.Delete(fileName);
                    }
                    fileName = fileName.Substring(fileName.LastIndexOf("//")+1);
                    string sqlExcel = "select top 65535 tb_data.d_ID as 自动编号,tb_house.h_Name as 住房名称,tb_data.d_p_Name as 教职工姓名,tb_data.d_p_Card as 银行卡账号,tb_data.d_p_Department as 部门编号,tb_house.h_Remark as 房屋备注,Format(tb_data.d_LastTime) as 上次抄表时间,Format(tb_data.d_ThisTime) as 本次抄表时间,tb_data.d_LastWater as 上次水表读数,tb_data.d_ThisWater as 本次水表读数,tb_data.d_LastPower as 上次电表读数,tb_data.d_ThisPower as 本次电表读数 into [Excel 8.0;database=" + fileName + "].[sheet1] ";
                    sqlExcel += (sql_bind + sql_end).Substring((sql_bind.LastIndexOf("from")));
                    OleDbConnection connExcel = OleDbHelp.conn;
                    OleDbCommand commExcel = new OleDbCommand(sqlExcel,connExcel);
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

        //批量操作——导入
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                ofdExcel.Filter = ("Excel文件(*.xls)|*.xls");
                if (ofdExcel.ShowDialog() == DialogResult.OK)
                {
                    //if (DialogResult.No==MessageBox.Show(this,"确定导入？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question))
                    //{
                    //    return;
                    //}
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
                                MessageBox.Show("导入成功！\n但是出现本次抄表记录小于上次抄表记录的现象\n该现象将导致用户数据为负值，现已按0处理\n请仔细检查文件中数据，并重新导入\n也可在数据管理界面进行修改！", "提示");
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
                MessageBox.Show("导入失败，请仔细检查导入文件的格式和内容是否符合导出文件格式！\n建议先导出文件，修改完成后再导入！", "提示");
                return;
            }
        }
    }
}
