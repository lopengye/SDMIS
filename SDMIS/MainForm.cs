using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDMIS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //关闭按钮事件
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Text = "欢迎您，" + Login.adminName+"           ";
            tsslInfo.Text = this.Text;
            tsslTime.Text = "现在的时间是：" + DateTime.Now.ToString() ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsslTime.Text = "现在的时间是：" + DateTime.Now.ToString();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PeopleManage peopleManage = new PeopleManage();
            peopleManage.ShowDialog();
        }

        private void houseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HouseManage houseManage = new HouseManage();
            houseManage.ShowDialog();
        }





        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                Application.Exit();
            }
        }

        private void baseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaseData baseData = new BaseData();
            baseData.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRecord newRecord = new NewRecord();
            newRecord.Show();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataManage dataManage = new DataManage();
            dataManage.Show();
        }

        private void pwdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePwd changePwd = new ChangePwd();
            changePwd.ShowDialog();
        }
    }
}
