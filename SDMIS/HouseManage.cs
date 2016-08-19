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
    public partial class HouseManage : Form
    {
        private static string sql_bind = "select tb_house.*,tb_people.p_Name from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
        private static int hid;//行号
        private static int len;//总列数

        //从弹出框获取数据
        public static int pid=0;//职工编号
        public static string pname="";//职工名称

        public HouseManage()
        {
            InitializeComponent();
        }

        //按ESC键关闭该窗口
        private void HouseManage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                this.Close();
            }
        }

        private void HouseManage_Load(object sender, EventArgs e)
        {
            sql_bind = "select tb_house.*,tb_people.p_Name from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
            btnCancel.Enabled = false;
            btnUpdate.Enabled = false;
            rbHouse.Checked = true;
            cbSearch.Enabled = false;
            BindData(sql_bind);
            BindPeople();
            
        }

        //绑定数据
        private void BindData(string sql,params OleDbParameter[] paras)
        {
            dgvHouse.DataSource = OleDbHelp.GetDataTable(sql,paras);
        }

        //绑定教职工信息
        private void BindPeople()
        {
            cbSearch.Items.Clear();
            cbSearch.DataSource = OleDbHelp.GetDataTable("select p_ID,p_Name from tb_people");
            cbSearch.DisplayMember = "p_Name";
            cbSearch.ValueMember = "p_ID";
        }

        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rbHouse.Checked)
            {
                if (txtSearch.Text.Trim()!="")
                {
                    sql_bind = "select tb_house.*,tb_people.p_Name from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
                    sql_bind += " where tb_house.h_Name like '%"+txtSearch.Text.Trim()+"%'";
                    BindData(sql_bind);
                }
                else
                {
                    sql_bind = "select tb_house.*,tb_people.p_Name from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
                    BindData(sql_bind);
                }
            }
            else if (rbPeople.Checked)
            {
                if (cbSearch.Text.Trim()!="")
                {
                    sql_bind = "select tb_house.*,tb_people.p_Name from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
                    sql_bind += " where tb_people.p_ID="+cbSearch.SelectedValue.ToString();
                    BindData(sql_bind);
                }
                else
                {
                    sql_bind = "select tb_house.*,tb_people.p_Name from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
                    BindData(sql_bind);
                }
            }
            else
            {
                MessageBox.Show("系统出错！","提示");
            }
        }

        //
        private void rbHouse_CheckedChanged(object sender, EventArgs e)
        {
            cbSearch.Enabled = false;
            txtSearch.Enabled = true;
        }

        //
        private void rbPeople_CheckedChanged(object sender, EventArgs e)
        {
            
            txtSearch.Text = "";
            txtSearch.Enabled = false;
            cbSearch.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text=="添加")
            {
                Clear();
                btnUpdate.Text = "修改";
                btnUpdate.Enabled = false;
                txtHouse.Enabled = true;
                txtRemark.Enabled = true;
                btnGetPeople.Enabled = true;
                btnClear.Enabled = true;
                btnCancel.Enabled = true;
            }
            if (btnAdd.Text=="确定")
            {
                #region
                if (txtHouse.Text.Trim() == "")
                {
                    MessageBox.Show("请输入必填信息！", "提示");
                    return;
                }
                string sql_check = "select h_Name from tb_house where h_Name=@hname";
                OleDbParameter[] para_check = { 
                                          new OleDbParameter("@hname",txtHouse.Text.Trim())
                                          };
                if (null != OleDbHelp.selectExecute(sql_check, para_check))
                {
                    MessageBox.Show("该名称已存在！", "提示");
                    return;
                }
                string sql_insert = "insert into tb_house(h_Name,h_p_ID,h_Remark) values(@hname,@hpid,@hremark)";
                OleDbParameter[] para_insert = { 
                                           new OleDbParameter("@hname",txtHouse.Text.Trim()),
                                           new OleDbParameter("@hpid",pid),
                                           new OleDbParameter("",txtRemark.Text.Trim())
                                           };
                if (OleDbHelp.Execute(sql_insert, para_insert) > 0)
                {
                    BindData(sql_bind);
                    Clear();
                    MessageBox.Show("添加成功！", "提示");
                    return;
                }
                else
                {
                    MessageBox.Show("添加失败，请重试！", "提示");
                    return;
                }
                #endregion
            }
            btnAdd.Text = "确定";
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnAdd.Enabled = true;
            btnAdd.Text = "添加";
                btnUpdate.Text = "修改";
                btnUpdate.Enabled = false;
            btnCancel.Enabled = false;

            txtHouse.Enabled = false;
            txtRemark.Enabled = false;
            btnClear.Enabled = false;
            btnGetPeople.Enabled = false;

            pid = 0;
            pname = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text=="修改")
            {
                btnAdd.Enabled = false;
                txtHouse.Enabled = true;
                txtRemark.Enabled = true;
                btnGetPeople.Enabled = true;
                btnClear.Enabled = true;
                btnCancel.Enabled = true;
            }
            if (btnUpdate.Text=="确定")
            {
                #region
                if (txtHouse.Text.Trim() == "")
                {
                    MessageBox.Show("请输入必填信息！", "提示");
                    return;
                }
                string sql_check = "select h_Name from tb_house where h_Name=@hname and h_ID<>@hid";
                OleDbParameter[] para_check = { 
                                          new OleDbParameter("@hname",txtHouse.Text.Trim()),
                                          new OleDbParameter("@hid",hid)
                                          };
                if (null != OleDbHelp.selectExecute(sql_check, para_check))
                {
                    MessageBox.Show("该住房名称已存在！", "提示");
                    return;
                }
                string sql_update = "update tb_house set h_Name=@hname,h_p_ID=@hpid,h_Remark=@hremark where h_ID=@hid";
                OleDbParameter[] para_update = { 
                                           new OleDbParameter("@hname",txtHouse.Text.Trim()),
                                           new OleDbParameter("@hpid",pid),
                                           new OleDbParameter("@hremark",txtRemark.Text.Trim()),
                                           new OleDbParameter("@hid",hid),
                                           };
                if (OleDbHelp.Execute(sql_update, para_update) > 0)
                {
                    BindData(sql_bind);
                    MessageBox.Show("修改成功！", "提示");
                    return;
                }
                else
                {
                    MessageBox.Show("修改失败，请重试！", "提示");
                    return;
                }
                #endregion
            }
            btnUpdate.Text = "确定";
        }

        private void Clear()
        {
            pid = 0;
            pname = "";
            txtPeople.Text = "";
            txtHouse.Text = "";
            txtRemark.Text = "";
        }

        //单元格单击
        private void dgvHouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvHouse.Rows.Count <= 0)
            {
                return;
            }
            btnAdd.Enabled = true;
            btnAdd.Text = "添加";
            //btnUpdate.Text = "修改";
            btnCancel.Enabled = false;
            btnUpdate.Enabled = true;
            
            hid = Convert.ToInt32(dgvHouse.CurrentRow.Cells["h_ID"].Value);
            txtHouse.Text=dgvHouse.CurrentRow.Cells["h_Name"].Value.ToString();
            pid = Convert.ToInt32(dgvHouse.CurrentRow.Cells["h_p_ID"].Value);
            txtPeople.Text = dgvHouse.CurrentRow.Cells["p_Name"].Value.ToString();
            txtRemark.Text=dgvHouse.CurrentRow.Cells["h_Remark"].Value.ToString();
            if (this.dgvHouse.CurrentRow.Cells["select"].Selected)
            {
                if (this.dgvHouse.CurrentRow.Cells["select"].FormattedValue.ToString()=="False")
                {
                    this.dgvHouse.CurrentRow.Cells["select"].Value=true;
                }
                else
                {
                    this.dgvHouse.CurrentRow.Cells["select"].Value=false;
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            len = dgvHouse.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvHouse.Rows[i].Cells["select"].Value = true;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            len = dgvHouse.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvHouse.Rows[i].Cells["select"].Value = false;
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            len = dgvHouse.Rows.Count;//获取总行数
            for (int i = 0; i < len; i++)
            {
                if (dgvHouse.Rows[i].Cells["select"].FormattedValue.ToString() == "True")
                {
                    dgvHouse.Rows[i].Cells["select"].Value = "False";
                }
                else
                {
                    dgvHouse.Rows[i].Cells["select"].Value = "True";
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            bool NotEmpty = false;
            len = dgvHouse.Rows.Count;
            int flag = 0;
            string sql_del = "";
            for (int i = 0; i < len; i++)
            {
                if (dgvHouse.Rows[i].Cells["select"].FormattedValue.ToString()=="True")
                {
                    NotEmpty = true;
                    break;
                }
            }
            if (NotEmpty)
            {
                DialogResult res = MessageBox.Show(this,"确定删除？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                switch (res)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < len; i++)
                        {
                            if (dgvHouse.Rows[i].Cells["select"].FormattedValue.ToString()=="True")
                            {
                                sql_del = "delete from tb_house where h_ID=@hid";
                                OleDbParameter[] para_del = { 
                                                            new OleDbParameter("@hid",dgvHouse.Rows[i].Cells["h_ID"].Value.ToString())
                                                            };
                                flag += OleDbHelp.Execute(sql_del,para_del);
                            }
                        }
                        if (flag>0)
                        {
                            BindData(sql_bind);
                            MessageBox.Show("成功删除"+flag+"行数据！","提示");
                        }
                        else
                        {
                            MessageBox.Show("删除失败，请重试！","提示");
                        }
                        break;
                    case DialogResult.No:
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("未选中任何行！","提示");
            }
        }

        private void btnGetPeople_Click(object sender, EventArgs e)
        {
            GetPeople getPeople = new GetPeople();
            getPeople.ShowDialog();
            txtPeople.Text = pname;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pid = 0;
            pname = "";
            txtPeople.Text = "";
        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            try
            {
                ofdExcel.Filter=("Excel文件(*.xls)|*.xls");
                if (ofdExcel.ShowDialog()==DialogResult.OK)
                {
                    string fileName = ofdExcel.FileName;
                    if (fileName=="")
                    {
                        MessageBox.Show("未选择任何文件！", "提示");
                        return;
                    }
                    if (fileName.Substring(fileName.LastIndexOf(".") + 1) != "xls")
                    {
                        MessageBox.Show("请选择Excel(*.xls)文件！", "提示");
                        return;
                    }
                    txtRoad.Text = fileName;
                    btnIn.Enabled=true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("打开文件错误，请重试！","提示");
                return;
            }
        }

        //导入操作
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                //数据定义
                string hname = "";
                int hpid = 0;
                string hremark = "";

                string sql_check = "";
                int flag_check = 0;
                string sql_insert = "";
                int flag_insert = 0;
                

                string fileName = txtRoad.Text.Trim();
                OleDbConnection connExcel = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=;Extended properties=Excel 5.0;Data Source=" + fileName);
                connExcel.Open();
                string get_data = "select * from [Sheet1$]";
                OleDbCommand commExcel = new OleDbCommand(get_data, connExcel);
                OleDbDataReader dr = commExcel.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        sql_insert = "insert into T_BoxSettingDetail (Poclass,FloorName,ProviderCode,ProviderName,Orderdate,FloorStuff,InchUnit,Length,Width,Height,PaperSize,Line1,Line2,Line3,Line4,Line5,Line6,Tile,PressCut,PressLine,Ordernum,PresentNum,OpenNum,BoxForm,PieceMode,LongCutNum,MakeLength,MakeWidth,MakeHeight,BandsRate,Ruffle1,Ruffle2,TSNum,TSWidth,BreakDegree,Compression,UnitPrice,SellingPrice,ProductLen,WorkDetail,CreateDate,Operator,Memo,ModelNum,CutLength,CutWidth)" +
                            " values(@PoClass,@FloorName,@ProviderCode,@ProviderName,@Orderdate,@FloorStuff,@InchUnit,@Length,@)";
                    }   
                }
                //if (dr.HasRows)
                //{
                //    while (dr.Read())
                //    {
                //        hname = dr.GetValue(0).ToString();
                //        hpid = Convert.ToInt32(dr.GetValue(1));
                //        hremark = dr.GetValue(2).ToString();

                //        sql_check = "select h_ID from tb_house where h_Name='"+hname+"'";
                //        if (null!=OleDbHelp.selectExecute(sql_check))
                //        {
                //            flag_check++;
                //            continue;
                //        }

                //        sql_insert = "insert into tb_house(h_Name,h_p_ID,h_Remark) values(@hname,@hpid,@hremark)";
                //        OleDbParameter[] para_insert = { 
                //                                       new OleDbParameter("@hname",hname),
                //                                       new OleDbParameter("@hpid",hpid),
                //                                       new OleDbParameter("@hremark",hremark)
                //                                       };
                //        flag_insert += OleDbHelp.Execute(sql_insert,para_insert);
                //    }
                //    dr.Close();
                //    connExcel.Close();
                //    if (flag_insert>=0)
                //    {
                //        BindData(sql_bind);
                //        MessageBox.Show("导入成功\n共上传了"+flag_insert+"条数据！\n已存在"+flag_check+"条数据\n入住职工信息请在左侧列表中修改！\n注意：住房名称不能重复","提示");
                //        return;
                //    }
                //    else
                //    {
                //        MessageBox.Show("导入失败，请检查文件格式后重试！", "提示");
                //        return;
                //    }
                //}
                //else
                //{
                //    dr.Close();
                //    connExcel.Close();
                //    MessageBox.Show("该文件中没有数据，请仔细检查！","提示");
                //}
            }
            catch (Exception)
            {
                MessageBox.Show("导入失败，请检查文件格式后重试！","提示");
                return;
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnSearch_Click(sender,e);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            sql_bind = "select tb_house.*,tb_people.p_Name from tb_house left join tb_people on tb_house.h_p_ID =tb_people.p_ID";
            BindData(sql_bind);
        }
    }
}
