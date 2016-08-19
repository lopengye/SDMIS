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
    public partial class GetPeople : Form
    {
        private static string sql_bind = "select * from tb_people";

        public GetPeople()
        {
            InitializeComponent();
        }

        private void GetPeople_Load(object sender, EventArgs e)
        {
            BindData();
        }

        //
        private void BindData()
        {
            //sql_bind = "select * from tb_people";
            dgvPeople.DataSource = OleDbHelp.GetDataTable(sql_bind);
        }

        private void GetPeople_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==27)
            {
                this.Close();
            }
        }

        private void dgvPeople_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPeople.Rows.Count<=0)
            {
                return;
            }
            dgvPeople.CurrentRow.Selected = true ;
        }

        private void dgvPeople_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPeople.Rows.Count <= 0)
            {
                return;
            }
            dgvPeople.CurrentRow.Selected = true;
            HouseManage.pid = Convert.ToInt32(this.dgvPeople.CurrentRow.Cells["p_ID"].Value);
            HouseManage.pname = this.dgvPeople.CurrentRow.Cells["p_Name"].Value.ToString();
            this.Close();
        }

        //查询
        private void Search()
        {
            sql_bind = "select * from tb_people";
            bool NotEmpty = false;
            if (txtName.Text.Trim()!="")
            {
                sql_bind += " where p_Name like '%"+txtName.Text.Trim()+"%'";
                NotEmpty = true;
            }
            if (txtCard.Text.Trim()!="")
            {
                if (NotEmpty)
                {
                    sql_bind += " and p_Card like '%"+txtCard.Text.Trim()+"%'";
                }
                else
                {
                    sql_bind += " where p_Card like '%" + txtCard.Text.Trim() + "%'";
                    NotEmpty = true;
                }
            }
            if (txtDepartment.Text.Trim()!="")
            {
                if (NotEmpty)
                {
                    sql_bind += " and p_Department='" + txtDepartment.Text.Trim()+"'";
                }
                else
                {
                    sql_bind += " where p_Department='" + txtDepartment.Text.Trim() + "'";
                }
            }
            BindData();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Search();
            }
        }

        private void txtCard_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Search();
            }
        }

        private void txtDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Search();
            }
        }
    }
}
