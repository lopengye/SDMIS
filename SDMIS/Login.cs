using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace SDMIS
{
    public partial class Login : Form
    {
        public static string adminName = "";

        public Login()
        {
            InitializeComponent();
            LoadHistory();
        }

        //登陆按钮
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cbName.Text.Trim()!=""&&txtPwd.Text.Trim()!="")
            {
                string sql_login = "select a_Name from tb_admin where a_Name=@aname and a_Pwd=@apwd";
                OleDbParameter[] para_login = { 
                                              new OleDbParameter("@aname",cbName.Text.Trim()),
                                              new OleDbParameter("@apwd",txtPwd.Text.Trim())
                                              };
                if (null!=OleDbHelp.selectExecute(sql_login,para_login))
                {
                    adminName = cbName.Text.Trim();
                    this.Visible = false;
                    MainForm mainForm = new MainForm();
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！","提示");
                    txtPwd.Text = "";
                    return;
                }
            }
            else
            {
                MessageBox.Show("请输入用户名和密码！","提示");
                return;
            }
        }

        private void txtPwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                btnOK_Click(sender,e);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //保存
        private void SaveHistory()
        {
            string fileName = Path.Combine(Application .StartupPath,"log.db");
            StreamWriter sw = new StreamWriter(fileName,false,Encoding.Default);
            foreach (string  name in cbName.AutoCompleteCustomSource)
            {
                sw.WriteLine(name);
            }
            sw.Flush();
            sw.Close();
        }

        //读取
        private void LoadHistory()
        {
            string fileName = Path.Combine(Application.StartupPath,"log.db");
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName,Encoding.Default);
                string name = sr.ReadLine();
                while (name!=null)
                {
                    this.cbName.AutoCompleteCustomSource.Add(name);
                    this.cbName.Items.Add(name);
                    name = sr.ReadLine();
                }
                this.cbName.SelectedIndex = 0;
                sr.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cbName.AutoCompleteCustomSource.Contains(cbName.Text))
            {
                cbName.AutoCompleteCustomSource.Add(cbName.Text);
                SaveHistory();
            }
        }
    }
}
