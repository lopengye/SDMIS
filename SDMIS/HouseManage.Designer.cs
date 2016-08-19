namespace SDMIS
{
    partial class HouseManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseManage));
            this.dgvHouse = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.h_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_p_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbPeople = new System.Windows.Forms.RadioButton();
            this.rbHouse = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbAddUpdate = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGetPeople = new System.Windows.Forms.Button();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbDel = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.gbExcel = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnChose = new System.Windows.Forms.Button();
            this.txtRoad = new System.Windows.Forms.TextBox();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbAddUpdate.SuspendLayout();
            this.gbDel.SuspendLayout();
            this.gbExcel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHouse
            // 
            this.dgvHouse.AllowUserToAddRows = false;
            this.dgvHouse.AllowUserToDeleteRows = false;
            this.dgvHouse.AllowUserToOrderColumns = true;
            this.dgvHouse.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHouse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHouse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHouse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.h_ID,
            this.h_Name,
            this.h_p_ID,
            this.p_Name,
            this.h_Remark});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHouse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHouse.Location = new System.Drawing.Point(13, 13);
            this.dgvHouse.Name = "dgvHouse";
            this.dgvHouse.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHouse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHouse.RowHeadersVisible = false;
            this.dgvHouse.RowTemplate.Height = 23;
            this.dgvHouse.Size = new System.Drawing.Size(544, 708);
            this.dgvHouse.TabIndex = 0;
            this.dgvHouse.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHouse_CellClick);
            // 
            // select
            // 
            this.select.HeaderText = "选择";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Width = 50;
            // 
            // h_ID
            // 
            this.h_ID.DataPropertyName = "h_ID";
            this.h_ID.HeaderText = "住房编号";
            this.h_ID.Name = "h_ID";
            this.h_ID.ReadOnly = true;
            this.h_ID.Visible = false;
            // 
            // h_Name
            // 
            this.h_Name.DataPropertyName = "h_Name";
            this.h_Name.HeaderText = "住房名称";
            this.h_Name.Name = "h_Name";
            this.h_Name.ReadOnly = true;
            this.h_Name.Width = 240;
            // 
            // h_p_ID
            // 
            this.h_p_ID.DataPropertyName = "h_p_ID";
            this.h_p_ID.HeaderText = "教职工编号";
            this.h_p_ID.Name = "h_p_ID";
            this.h_p_ID.ReadOnly = true;
            this.h_p_ID.Visible = false;
            // 
            // p_Name
            // 
            this.p_Name.DataPropertyName = "p_Name";
            this.p_Name.HeaderText = "入住教职工";
            this.p_Name.Name = "p_Name";
            this.p_Name.ReadOnly = true;
            this.p_Name.Width = 130;
            // 
            // h_Remark
            // 
            this.h_Remark.DataPropertyName = "h_Remark";
            this.h_Remark.HeaderText = "备注";
            this.h_Remark.Name = "h_Remark";
            this.h_Remark.ReadOnly = true;
            // 
            // gbSearch
            // 
            this.gbSearch.Controls.Add(this.btnShowAll);
            this.gbSearch.Controls.Add(this.btnSearch);
            this.gbSearch.Controls.Add(this.cbSearch);
            this.gbSearch.Controls.Add(this.txtSearch);
            this.gbSearch.Controls.Add(this.rbPeople);
            this.gbSearch.Controls.Add(this.rbHouse);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Location = new System.Drawing.Point(563, 13);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(529, 97);
            this.gbSearch.TabIndex = 1;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "查询";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(448, 63);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "显示全部";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(239, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(97, 65);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 20);
            this.cbSearch.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(97, 39);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 21);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // rbPeople
            // 
            this.rbPeople.AutoSize = true;
            this.rbPeople.Location = new System.Drawing.Point(8, 66);
            this.rbPeople.Name = "rbPeople";
            this.rbPeople.Size = new System.Drawing.Size(71, 16);
            this.rbPeople.TabIndex = 2;
            this.rbPeople.TabStop = true;
            this.rbPeople.Text = "教职工：";
            this.rbPeople.UseVisualStyleBackColor = true;
            this.rbPeople.CheckedChanged += new System.EventHandler(this.rbPeople_CheckedChanged);
            // 
            // rbHouse
            // 
            this.rbHouse.AutoSize = true;
            this.rbHouse.Location = new System.Drawing.Point(8, 40);
            this.rbHouse.Name = "rbHouse";
            this.rbHouse.Size = new System.Drawing.Size(83, 16);
            this.rbHouse.TabIndex = 1;
            this.rbHouse.TabStop = true;
            this.rbHouse.Text = "住房名称：";
            this.rbHouse.UseVisualStyleBackColor = true;
            this.rbHouse.CheckedChanged += new System.EventHandler(this.rbHouse_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "提示：住房名称处支持模糊查询";
            // 
            // gbAddUpdate
            // 
            this.gbAddUpdate.Controls.Add(this.btnClear);
            this.gbAddUpdate.Controls.Add(this.btnGetPeople);
            this.gbAddUpdate.Controls.Add(this.txtPeople);
            this.gbAddUpdate.Controls.Add(this.btnUpdate);
            this.gbAddUpdate.Controls.Add(this.btnCancel);
            this.gbAddUpdate.Controls.Add(this.label7);
            this.gbAddUpdate.Controls.Add(this.label6);
            this.gbAddUpdate.Controls.Add(this.txtRemark);
            this.gbAddUpdate.Controls.Add(this.label5);
            this.gbAddUpdate.Controls.Add(this.btnAdd);
            this.gbAddUpdate.Controls.Add(this.label4);
            this.gbAddUpdate.Controls.Add(this.txtHouse);
            this.gbAddUpdate.Controls.Add(this.label3);
            this.gbAddUpdate.Controls.Add(this.label2);
            this.gbAddUpdate.Location = new System.Drawing.Point(563, 116);
            this.gbAddUpdate.Name = "gbAddUpdate";
            this.gbAddUpdate.Size = new System.Drawing.Size(529, 154);
            this.gbAddUpdate.TabIndex = 2;
            this.gbAddUpdate.TabStop = false;
            this.gbAddUpdate.Text = "添加/修改";
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(269, 67);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(57, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "置空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnGetPeople
            // 
            this.btnGetPeople.Enabled = false;
            this.btnGetPeople.Location = new System.Drawing.Point(206, 67);
            this.btnGetPeople.Name = "btnGetPeople";
            this.btnGetPeople.Size = new System.Drawing.Size(57, 23);
            this.btnGetPeople.TabIndex = 17;
            this.btnGetPeople.Text = "选择";
            this.btnGetPeople.UseVisualStyleBackColor = true;
            this.btnGetPeople.Click += new System.EventHandler(this.btnGetPeople_Click);
            // 
            // txtPeople
            // 
            this.txtPeople.Enabled = false;
            this.txtPeople.Location = new System.Drawing.Point(77, 69);
            this.txtPeople.MaxLength = 20;
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(121, 21);
            this.txtPeople.TabIndex = 16;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(239, 123);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(204, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "可选";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(204, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "*20个汉字或字母以内";
            // 
            // txtRemark
            // 
            this.txtRemark.Enabled = false;
            this.txtRemark.Location = new System.Drawing.Point(77, 95);
            this.txtRemark.MaxLength = 20;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(121, 21);
            this.txtRemark.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "住房备注：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(77, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "入住职工：";
            // 
            // txtHouse
            // 
            this.txtHouse.Enabled = false;
            this.txtHouse.Location = new System.Drawing.Point(77, 42);
            this.txtHouse.MaxLength = 20;
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(121, 21);
            this.txtHouse.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "住房名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "提示：在列表中选择要修改的一列，在下面进行修改。带*号的为必填项";
            // 
            // gbDel
            // 
            this.gbDel.Controls.Add(this.btnDel);
            this.gbDel.Controls.Add(this.btnInverse);
            this.gbDel.Controls.Add(this.btnNone);
            this.gbDel.Controls.Add(this.btnAll);
            this.gbDel.Controls.Add(this.label9);
            this.gbDel.Location = new System.Drawing.Point(563, 276);
            this.gbDel.Name = "gbDel";
            this.gbDel.Size = new System.Drawing.Size(529, 67);
            this.gbDel.TabIndex = 3;
            this.gbDel.TabStop = false;
            this.gbDel.Text = "删除";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(272, 35);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(203, 35);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(57, 23);
            this.btnInverse.TabIndex = 10;
            this.btnInverse.Text = "反选";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(140, 35);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(57, 23);
            this.btnNone.TabIndex = 9;
            this.btnNone.Text = "全不选";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(77, 35);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(57, 23);
            this.btnAll.TabIndex = 8;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(6, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(485, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "提示：在列表中选择要删除的一行或多行，然后点击删除。删除操作不可恢复，请谨慎操作";
            // 
            // gbExcel
            // 
            this.gbExcel.Controls.Add(this.label8);
            this.gbExcel.Controls.Add(this.btnIn);
            this.gbExcel.Controls.Add(this.btnChose);
            this.gbExcel.Controls.Add(this.txtRoad);
            this.gbExcel.Location = new System.Drawing.Point(563, 474);
            this.gbExcel.Name = "gbExcel";
            this.gbExcel.Size = new System.Drawing.Size(529, 247);
            this.gbExcel.TabIndex = 4;
            this.gbExcel.TabStop = false;
            this.gbExcel.Text = "批量操作";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(6, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(365, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "提示：只能导入住房信息，入住职工信息需要在本界面上方手动修改";
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
            this.btnIn.Location = new System.Drawing.Point(450, 39);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "导入";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnChose
            // 
            this.btnChose.Location = new System.Drawing.Point(369, 39);
            this.btnChose.Name = "btnChose";
            this.btnChose.Size = new System.Drawing.Size(75, 23);
            this.btnChose.TabIndex = 1;
            this.btnChose.Text = "选择";
            this.btnChose.UseVisualStyleBackColor = true;
            this.btnChose.Click += new System.EventHandler(this.btnChose_Click);
            // 
            // txtRoad
            // 
            this.txtRoad.Enabled = false;
            this.txtRoad.Location = new System.Drawing.Point(8, 41);
            this.txtRoad.Name = "txtRoad";
            this.txtRoad.Size = new System.Drawing.Size(355, 21);
            this.txtRoad.TabIndex = 0;
            // 
            // HouseManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 732);
            this.Controls.Add(this.gbExcel);
            this.Controls.Add(this.gbDel);
            this.Controls.Add(this.gbAddUpdate);
            this.Controls.Add(this.gbSearch);
            this.Controls.Add(this.dgvHouse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1110, 760);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1110, 760);
            this.Name = "HouseManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "住房信息管理(ESC键关闭)";
            this.Load += new System.EventHandler(this.HouseManage_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HouseManage_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHouse)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbAddUpdate.ResumeLayout(false);
            this.gbAddUpdate.PerformLayout();
            this.gbDel.ResumeLayout(false);
            this.gbDel.PerformLayout();
            this.gbExcel.ResumeLayout(false);
            this.gbExcel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHouse;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rbPeople;
        private System.Windows.Forms.RadioButton rbHouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbAddUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbDel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox gbExcel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGetPeople;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_p_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Remark;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnChose;
        private System.Windows.Forms.TextBox txtRoad;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnShowAll;
    }
}