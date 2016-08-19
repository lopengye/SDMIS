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
    public partial class ChangePwd : Form
    {
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtOld.Text.Trim()==""||txtNew.Text.Trim()==""||txtAgain.Text.Trim()=="")
            {
                MessageBox.Show("请输入必要信息！","提示");
                return;
            }
            if (txtNew.Text.Trim()!=txtAgain.Text.Trim())
            {
                MessageBox.Show("两次输入的密码不同！","提示");
                return;
            }
            string admin_name = Login.adminName;
            string sql_check = "select  a_Pwd from tb_admin where a_Name=@aname";
            OleDbParameter[] para_check = { 
                                          new OleDbParameter("@aname",admin_name)
                                          };
            if (txtOld.Text.Trim()!=OleDbHelp.selectExecute(sql_check,para_check).ToString())
            {
                MessageBox.Show("旧密码错误，请检查！", "提示");
                return;
            }
            string sql_update = "update tb_admin set a_Pwd=@apwd where a_Name=@aname";
            OleDbParameter[] para_update = { 
                                           new OleDbParameter("@apwd",txtNew.Text.Trim()),
                                           new OleDbParameter("@aname",admin_name)
                                           };
            if (Convert.ToInt32( OleDbHelp.Execute(sql_update,para_update))>0)
            {
                MessageBox.Show("修改成功！", "提示");
                return;
            }
            else
            {
                MessageBox.Show("修改失败！", "提示");
                return;
            }
        }

        private void ChangePwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
