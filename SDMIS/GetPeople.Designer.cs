namespace SDMIS
{
    partial class GetPeople
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCard = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.dgvPeople = new System.Windows.Forms.DataGridView();
            this.p_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(59, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(63, 21);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "帐号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "部门号：";
            // 
            // txtCard
            // 
            this.txtCard.Location = new System.Drawing.Point(175, 29);
            this.txtCard.Name = "txtCard";
            this.txtCard.Size = new System.Drawing.Size(117, 21);
            this.txtCard.TabIndex = 4;
            this.txtCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCard_KeyPress);
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(357, 29);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(63, 21);
            this.txtDepartment.TabIndex = 5;
            this.txtDepartment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDepartment_KeyPress);
            // 
            // dgvPeople
            // 
            this.dgvPeople.AllowUserToAddRows = false;
            this.dgvPeople.AllowUserToDeleteRows = false;
            this.dgvPeople.AllowUserToOrderColumns = true;
            this.dgvPeople.AllowUserToResizeRows = false;
            this.dgvPeople.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPeople.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.p_ID,
            this.p_Name,
            this.p_Card,
            this.p_Department});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPeople.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPeople.Location = new System.Drawing.Point(12, 56);
            this.dgvPeople.Name = "dgvPeople";
            this.dgvPeople.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPeople.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPeople.RowHeadersVisible = false;
            this.dgvPeople.RowTemplate.Height = 23;
            this.dgvPeople.Size = new System.Drawing.Size(408, 682);
            this.dgvPeople.TabIndex = 6;
            this.dgvPeople.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeople_CellClick);
            this.dgvPeople.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPeople_CellDoubleClick);
            // 
            // p_ID
            // 
            this.p_ID.DataPropertyName = "p_ID";
            this.p_ID.HeaderText = "职工编号";
            this.p_ID.Name = "p_ID";
            this.p_ID.ReadOnly = true;
            this.p_ID.Visible = false;
            // 
            // p_Name
            // 
            this.p_Name.DataPropertyName = "p_Name";
            this.p_Name.HeaderText = "教职工姓名";
            this.p_Name.Name = "p_Name";
            this.p_Name.ReadOnly = true;
            this.p_Name.Width = 140;
            // 
            // p_Card
            // 
            this.p_Card.DataPropertyName = "p_Card";
            this.p_Card.HeaderText = "账号";
            this.p_Card.Name = "p_Card";
            this.p_Card.ReadOnly = true;
            this.p_Card.Width = 150;
            // 
            // p_Department
            // 
            this.p_Department.DataPropertyName = "p_Department";
            this.p_Department.HeaderText = "部门编号";
            this.p_Department.Name = "p_Department";
            this.p_Department.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "支持多条件模糊查询，双击即选择";
            // 
            // GetPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(434, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvPeople);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GetPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "请选择";
            this.Load += new System.EventHandler(this.GetPeople_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GetPeople_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCard;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.DataGridView dgvPeople;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Department;
        private System.Windows.Forms.Label label4;
    }
}