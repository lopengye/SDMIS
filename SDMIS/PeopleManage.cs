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
    public partial class PeopleManage : Form
    {
        private static string sql_bind = "select * from tb_people";
        private static int pid;
        private static int len;//行数

        public PeopleManage()
        {
            InitializeComponent();
        }

        private void PeopleManage_Load(object sender, EventArgs e)
        {
            cbType.SelectedIndex = 0;
            sql_bind = "select * from tb_people";
            BindData(sql_bind);
        }

        //绑定类型
        //private void BindType()
        //{
        //    cbType.Items.Clear();
        //    cbType.Items.Add(new ListItem("1", "姓名"));
        //    cbType.Items.Add(new ListItem("2", "工资卡号"));
        //    cbType.Items.Add(new ListItem("3", "部门代码"));
        //    cbType.DisplayMember = "Text";
        //    cbType.ValueMember = "Value";
        //    cbType.SelectedIndex = 0;
        //}

        //绑定数据
        /// <summary>
        /// 
        /// </summary>
        private void BindData(string sql,params OleDbParameter[] paras)
        {
            dgvPeople.DataSource = OleDbHelp.GetDataTable(sql_bind,paras);
        }

        //查询按钮
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Clear();
            if (txtKey.Text.Trim()!="")
            {
                if (cbType.SelectedIndex==0)
                {
                    sql_bind = "select * from tb_people where p_Name like @pname";
                    OleDbParameter[] para_name = { 
                                                 new OleDbParameter("@pname","%"+txtKey.Text.Trim()+"%")
                                                 };
                    BindData(sql_bind,para_name);
                }
                if (cbType.SelectedIndex==1)
                {
                    sql_bind = "select * from tb_people where p_Card like @pcard";
                    OleDbParameter[] para_card = { 
                                                 new OleDbParameter("@pcard","%"+txtKey.Text.Trim()+"%")
                                                 };
                    BindData(sql_bind, para_card);
                }
                if (cbType.SelectedIndex==2)
                {
                    sql_bind = "select * from tb_people where p_Department=@pdepart";
                    OleDbParameter[] para_depart = { 
                                                   new OleDbParameter("@pdepart",txtKey.Text.Trim())
                                                   };
                    BindData(sql_bind,para_depart);
                }
                sql_bind = "select * from tb_people";
            }
            else
            {
                sql_bind = "select * from tb_people";
                BindData(sql_bind);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text=="添加")
            {
                Clear();
                txtName.Enabled = true;
                txtCard.Enabled = true;
                txtDepartment.Enabled = true;
                btnUpdate.Text = "修改";
                btnUpdate.Enabled = false;
                btnCancel.Enabled = true;
            }
            if (btnAdd.Text=="确定")
            {
                if (txtName.Text.Trim() == "" || txtCard.Text.Trim() == "" || txtDepartment.Text.Trim() == "")
                {
                    MessageBox.Show("请输入完整的信息！", "提示");
                    return;
                }
                //验证卡号
                string card = txtCard.Text.Trim();
                for (int i = 0; i < card.Length; i++)
                {
                    if (card[i] > '9' || card[i] < '0')
                    {
                        MessageBox.Show("工资卡号为19位或以内的数字组成，请正确输入", "提示");
                        return;
                    }
                }
                //验证部门编号
                //string depart = txtDepartment.Text.Trim();
                //for (int i = 0; i < depart.Length; i++)
                //{
                //    if (depart[i] > '9' || card[i] < '0')
                //    {
                //        MessageBox.Show("工资卡号为3位或以内的数字组成，请正确输入", "提示");
                //        return;
                //    }
                //}
                string sql_check = "select p_Card from tb_people where p_Card=@pcard";
                OleDbParameter[] para_check = { 
                                          new OleDbParameter("@pcard",txtCard.Text.Trim())
                                          };
                if (null != OleDbHelp.selectExecute(sql_check, para_check))
                {
                    MessageBox.Show("已存在的工资卡号，请仔细核对信息！", "提示");
                    return;
                }
                string sql_insert = "insert into tb_people(p_Name,p_Card,p_Department) values(@pname,@pcard,@pdepartment)";
                OleDbParameter[] para_insert = { 
                                           new OleDbParameter("@pname",txtName.Text.Trim()),
                                           new OleDbParameter("@pcard",txtCard.Text.Trim()),
                                           new OleDbParameter("@pdepartment",txtDepartment.Text.Trim())
                                           };
                int flag = OleDbHelp.Execute(sql_insert, para_insert);
                if (flag > 0)
                {
                    BindData(sql_bind);
                    MessageBox.Show("添加成功！", "提示");
                    return;
                }
                else
                {
                    MessageBox.Show("添加失败，请重试！", "提示");
                    return;
                }
            }
            btnAdd.Text = "确定";
        }

        //取消按钮

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            txtName.Enabled = false;
            txtCard.Enabled = false;
            txtDepartment.Enabled = false;
            btnAdd.Enabled = true;
            btnAdd.Text = "添加";
            btnUpdate.Enabled = false;
            btnUpdate.Text = "修改";
            btnCancel.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text=="修改")
            {
                txtName.Enabled = true;
                txtCard.Enabled = true;
                txtDepartment.Enabled = true;
                btnCancel.Enabled = true;
                btnAdd.Enabled = false;
            }
            if (btnUpdate.Text=="确定")
            {
                if (txtName.Text.Trim() == "" || txtCard.Text.Trim() == "" || txtDepartment.Text.Trim() == "")
                {
                    MessageBox.Show("请输入完整的信息！", "提示");
                    return;
                }
                //验证卡号
                string card = txtCard.Text.Trim();
                for (int i = 0; i < card.Length; i++)
                {
                    if (card[i] > '9' || card[i] < '0')
                    {
                        MessageBox.Show("工资卡号为19位或以内的数字组成，请正确输入", "提示");
                        return;
                    }
                }
                string sql_check = "select p_Card from tb_people where p_Card=@pcard and p_ID<>@pid";
                OleDbParameter[] para_check = { 
                                          new OleDbParameter("@pcard",txtCard.Text.Trim()),
                                          new OleDbParameter("@pid",pid)
                                          };
                if (null != OleDbHelp.selectExecute(sql_check, para_check))
                {
                    MessageBox.Show("已存在的工资卡号，请仔细核对信息！", "提示");
                    return;
                }
                string sql_update = "update tb_people set p_Name=@pname,p_Card=@pcard,p_Department=@pdepart where p_ID=@pid";
                OleDbParameter[] para_update = { 
                                           new OleDbParameter("@pname",txtName.Text.Trim()),
                                           new OleDbParameter("@pcard",txtCard.Text.Trim()),
                                           new OleDbParameter("@pdepart",txtDepartment.Text.Trim()),
                                           new OleDbParameter("@pid",pid)
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
            }
            btnUpdate.Text = "确定";
        }

        //清空
        private void Clear()
        {
            txtName.Text = "";
            txtCard.Text = "";
            txtDepartment.Text = "";
        }

        private void dgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvPeople.Rows.Count <= 0)
            {
                return;
            }
            btnAdd.Enabled = true;
            btnCancel.Enabled = false;
            btnUpdate.Enabled = true;
            pid = Convert.ToInt32(dgvPeople.CurrentRow.Cells["p_ID"].Value);
            txtName.Text = dgvPeople.CurrentRow.Cells["p_Name"].Value.ToString();
            txtCard.Text=dgvPeople.CurrentRow.Cells["p_Card"].Value.ToString();
            txtDepartment.Text = dgvPeople.CurrentRow.Cells["p_Department"].Value.ToString();
            if (this.dgvPeople.CurrentRow.Cells["select"].Selected)
            {
                if (this.dgvPeople.CurrentRow.Cells["select"].FormattedValue.ToString() == "False")
                {
                    this.dgvPeople.CurrentRow.Cells["select"].Value = true;
                }
                else
                {
                    this.dgvPeople.CurrentRow.Cells["select"].Value = false;
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            len = dgvPeople.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvPeople.Rows[i].Cells["select"].Value = true;
            }
        }

        private void btnNone_Click(object sender, EventArgs e)
        {
            len = dgvPeople.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvPeople.Rows[i].Cells["select"].Value = false;
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            len = dgvPeople.Rows.Count;//获取总行数
            for (int i = 0; i < len; i++)
            {
                if (dgvPeople.Rows[i].Cells["select"].FormattedValue.ToString() == "True")
                {
                    dgvPeople.Rows[i].Cells["select"].Value = "False";
                }
                else
                {
                    dgvPeople.Rows[i].Cells["select"].Value = "True";
                }
            }
        }

        //删除按钮
        private void btnDel_Click(object sender, EventArgs e)
        {
            bool NotEmpty = false;
            len = dgvPeople.Rows.Count;
            int flag = 0;
            string sql_del = "";
            for (int i = 0; i < len; i++)
            {
                if (dgvPeople.Rows[i].Cells["select"].FormattedValue.ToString()=="True")
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
                            if (dgvPeople.Rows[i].Cells["select"].FormattedValue.ToString()=="True")
                            {
                                sql_del = "delete from tb_people where p_ID=@pid";
                                OleDbParameter[] para_del = { 
                                                            new OleDbParameter("@pid",dgvPeople.Rows[i].Cells["p_ID"].Value.ToString())
                                                            };
                                flag += OleDbHelp.Execute(sql_del,para_del);
                            }
                        }
                        if (flag>0)
                        {
                            sql_bind = "select * from tb_people";
                            BindData(sql_bind);
                            MessageBox.Show("成功删除"+flag+"行数据！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("删除失败，请重试!", "提示");
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
                return;
            }
        }

        private void PeopleManage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                this.Close();
            }
        }

        private void txtKey_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnSearch_Click(sender,e);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            #region 将Excel表数据存到数据库的临时表中
            try
            {
                ofdExcel.Filter = ("Excel文件(*.xls)|*.xls");
                if (ofdExcel.ShowDialog() == DialogResult.OK)
                {
                    string fileName = ofdExcel.FileName;
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

                    string sql_del = "delete from tb_temp";
                    OleDbHelp.Execute(sql_del);

                    #region 定义变量
                    string pname = "";
                    string pcard = "";
                    string pdepartment = "";

                    string sql_insert = "";
                    int flag_insert = 0;
                    #endregion

                    OleDbConnection connExcel = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Jet OLEDB:Database Password=;Extended properties=Excel 5.0;Data Source=" + fileName);
                    connExcel.Open();
                    string get_data = "select * from [Sheet1$]";
                    OleDbCommand commExcel = new OleDbCommand(get_data, connExcel);
                    OleDbDataReader dr = commExcel.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            //获取数据
                            pname = dr.GetValue(1).ToString();
                            pcard = dr.GetValue(2).ToString();
                            pdepartment = dr.GetValue(3).ToString();

                            //将数据添加到临时表中
                            sql_insert = "insert into tb_temp(t_Name,t_Card,t_Department) values(@tname,@tcard,@tdepartment)";
                            OleDbParameter[] para_insert = { 
                                                       new OleDbParameter("@tname",pname),
                                                       new OleDbParameter("@tcard",pcard),
                                                       new OleDbParameter("@tdepartment",pdepartment)
                                                       };
                            flag_insert += OleDbHelp.Execute(sql_insert, para_insert);
                        }
                        dr.Close();
                        connExcel.Close();
                        if (flag_insert <= 0)
                        {
                            MessageBox.Show("同步数据失败，请重试！", "提示");
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
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("同步数据失败，请重试！", "提示");
                return;
            }
            #endregion
            

            BindAccess();
            BindExcel();
            BindData(sql_bind);
            gbAccess.Visible = true;
            gbExcel.Visible = true;
        }

        private void dgvAccess_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvAccess.CurrentRow.Cells["selecta"].Selected)
            {
                if (this.dgvAccess.CurrentRow.Cells["selecta"].FormattedValue.ToString() == "False")
                {
                    this.dgvAccess.CurrentRow.Cells["selecta"].Value = true;
                }
                else
                {
                    this.dgvAccess.CurrentRow.Cells["selecta"].Value = false;
                }
            }
        }

        private void dgvExcel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvExcel.CurrentRow.Cells["selecte"].Selected)
            {
                if (this.dgvExcel.CurrentRow.Cells["selecte"].FormattedValue.ToString() == "False")
                {
                    this.dgvExcel.CurrentRow.Cells["selecte"].Value = true;
                }
                else
                {
                    this.dgvExcel.CurrentRow.Cells["selecte"].Value = false;
                }
            }
        }

        private void btnAlla_Click(object sender, EventArgs e)
        {
            len = dgvAccess.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvAccess.Rows[i].Cells["selecta"].Value = true;
            }
        }

        private void btnNonea_Click(object sender, EventArgs e)
        {
            len = dgvAccess.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvAccess.Rows[i].Cells["selecta"].Value = false;
            }
        }

        private void btnInversea_Click(object sender, EventArgs e)
        {
            len = dgvAccess.Rows.Count;//获取总行数
            for (int i = 0; i < len; i++)
            {
                if (dgvAccess.Rows[i].Cells["selecta"].FormattedValue.ToString() == "True")
                {
                    dgvAccess.Rows[i].Cells["selecta"].Value = "False";
                }
                else
                {
                    dgvAccess.Rows[i].Cells["selecta"].Value = "True";
                }
            }
        }

        //从系统删除——按钮
        private void btnDela_Click(object sender, EventArgs e)
        {
            bool NotEmpty = false;
            len = dgvAccess.Rows.Count;
            int flag = 0;
            string sql_del = "";
            for (int i = 0; i < len; i++)
            {
                if (dgvAccess.Rows[i].Cells["selecta"].FormattedValue.ToString() == "True")
                {
                    NotEmpty = true;
                    break;
                }
            }
            if (NotEmpty)
            {
                DialogResult res = MessageBox.Show(this, "确定删除？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (res)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < len; i++)
                        {
                            if (dgvAccess.Rows[i].Cells["selecta"].FormattedValue.ToString() == "True")
                            {
                                sql_del = "delete from tb_people where p_ID=@pid";
                                OleDbParameter[] para_del = { 
                                                            new OleDbParameter("@pid",dgvAccess.Rows[i].Cells["ap_ID"].Value.ToString())
                                                            };
                                flag += OleDbHelp.Execute(sql_del, para_del);
                            }
                        }
                        if (flag > 0)
                        {
                            BindAccess();
                            BindData(sql_bind);
                            MessageBox.Show("成功删除" + flag + "行数据！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("删除失败，请重试!", "提示");
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
                MessageBox.Show("未选中任何行！", "提示");
                return;
            }
        }

        private void btnAlle_Click(object sender, EventArgs e)
        {
            len = dgvExcel.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvExcel.Rows[i].Cells["selecte"].Value = true;
            }
        }

        private void btnNonee_Click(object sender, EventArgs e)
        {
            len = dgvExcel.Rows.Count;
            for (int i = 0; i < len; i++)
            {
                dgvExcel.Rows[i].Cells["selecte"].Value = false;
            }
        }

        private void btnInversee_Click(object sender, EventArgs e)
        {
            len = dgvExcel.Rows.Count;//获取总行数
            for (int i = 0; i < len; i++)
            {
                if (dgvExcel.Rows[i].Cells["selecte"].FormattedValue.ToString() == "True")
                {
                    dgvExcel.Rows[i].Cells["selecte"].Value = "False";
                }
                else
                {
                    dgvExcel.Rows[i].Cells["selecte"].Value = "True";
                }
            }
        }

        //添加到系统——按钮
        private void btnAdde_Click(object sender, EventArgs e)
        {
            bool NotEmpty = false;
            len = dgvExcel.Rows.Count;
            int flag = 0;
            string sql_add= "";
            for (int i = 0; i < len; i++)
            {
                if (dgvExcel.Rows[i].Cells["selecte"].FormattedValue.ToString() == "True")
                {
                    NotEmpty = true;
                    break;
                }
            }
            if (NotEmpty)
            {
                DialogResult res = MessageBox.Show(this, "确定添加选中人员信息到本系统？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch (res)
                {
                    case DialogResult.Yes:
                        for (int i = 0; i < len; i++)
                        {
                            if (dgvExcel.Rows[i].Cells["selecte"].FormattedValue.ToString() == "True")
                            {
                                sql_add = "insert into tb_people(p_Name,p_Card,p_Department) values(@tname,@tcard,@tdepartment)";
                                OleDbParameter[] para_insert = { 
                                           new OleDbParameter("@tname",dgvExcel.Rows[i].Cells["t_Name"].Value.ToString()),
                                           new OleDbParameter("@tcard",dgvExcel.Rows[i].Cells["t_Card"].Value.ToString()),
                                           new OleDbParameter("@tdepartment",dgvExcel.Rows[i].Cells["t_Department"].Value.ToString())
                                           };
                                flag += OleDbHelp.Execute(sql_add, para_insert);
                            }
                        }
                        if (flag > 0)
                        {
                            BindExcel();
                            BindData(sql_bind);
                            MessageBox.Show("成功添加" + flag + "行数据！", "提示");
                        }
                        else
                        {
                            MessageBox.Show("添加失败，请重试!", "提示");
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
                MessageBox.Show("未选中任何行！", "提示");
                return;
            }
        }

        //绑定Access
        private void BindAccess()
        {
            string sql_acheck = "SELECT tb_people.p_ID,tb_people.p_Name,tb_people.p_Card,tb_people.p_Department FROM tb_people WHERE not exists (select * from tb_temp where tb_temp.t_Name=tb_people.p_Name and tb_temp.t_Card=tb_people.p_Card and tb_temp.t_Department=tb_people.p_Department)";
            dgvAccess.DataSource = OleDbHelp.GetDataTable(sql_acheck);
        }

        //绑定Excel
        private void BindExcel()
        {
            string sql_echeck = "SELECT tb_temp.t_Name,tb_temp.t_Card,tb_temp.t_Department FROM tb_temp WHERE not exists (select * from tb_people where tb_temp.t_Name=tb_people.p_Name and tb_temp.t_Card=tb_people.p_Card and tb_temp.t_Department=tb_people.p_Department)";
            dgvExcel.DataSource = OleDbHelp.GetDataTable(sql_echeck);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            sql_bind = "select * from tb_people";
            BindData(sql_bind);
        }
    }
}
