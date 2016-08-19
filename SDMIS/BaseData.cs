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
    public partial class BaseData : Form
    {
        public BaseData()
        {
            InitializeComponent();
        }

        private void BaseData_Load(object sender, EventArgs e)
        {
            BindData();
        }

        //
        private void BindData()
        {
            txtWater.Text = OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='WaterPrice'").ToString();
            txtPower.Text = OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='PowerPrice'").ToString();
            dtpLast.Value = Convert.ToDateTime(OleDbHelp.selectExecute("select b_Value from tb_base where b_Type='LastTime'"));
        }

        private void BaseData_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string water = txtWater.Text.Trim();
            string power = txtPower.Text.Trim();
            bool err = false;
            //验证格式
            for (int i = 0; i < water.Length; i++)
            {
                if ((water[i]<'0'||water[i]>'9')&&water[i]!='.')
                {
                    err = true;
                    break;
                }
            }
            for (int i = 0; i < power.Length; i++)
            {
                if ((power[i] < '0' || power[i] > '9')&&power[i] != '.')
                {
                    err = true;
                    break;
                }
            }
            if (err)
            {
                MessageBox.Show("输入有误，请核查！", "提示");
                return;
            }
            string sql_water = "update tb_base set b_Value=@watervalue where b_Type=@watertype";
            OleDbParameter[] para_water = { 
                                          new OleDbParameter("@watervalue",txtWater.Text.Trim()),
                                          new OleDbParameter("@watertype","WaterPrice")
                                          };
            int water_flag = OleDbHelp.Execute(sql_water,para_water);
            string sql_power = "update tb_base set b_Value=@powervalue where b_Type=@powertype";
            OleDbParameter[] para_power = { 
                                          new OleDbParameter("@powervalue",txtPower.Text.Trim()),
                                          new OleDbParameter("@powertype","PowerPrice")
                                          };
            int power_flag = OleDbHelp.Execute(sql_power,para_power);
            string sql_lasttime = "update tb_base set b_Value=@lasttime where b_Type=@lasttype";
            OleDbParameter[] para_lasttime = { 
                                             new OleDbParameter("@lasttime",dtpLast.Value.ToShortDateString()),
                                             new OleDbParameter("@lasttype","LastTime")
                                             };
            int last_flag = OleDbHelp.Execute(sql_lasttime,para_lasttime);
            if (water_flag>0&&power_flag>0&&last_flag>0)
            {
                DialogResult res=MessageBox.Show(this,"保存成功，关闭该窗口？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.None);
                switch (res)
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        this.Close();
                        break;
                    case System.Windows.Forms.DialogResult.No:
                        break;
                    default:
                        break;
                }
                return;
            }
            else
            {
                MessageBox.Show("保存失败，请重试！", "提示");
                return;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
