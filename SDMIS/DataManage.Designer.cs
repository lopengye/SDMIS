namespace SDMIS
{
    partial class DataManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataManage));
            this.dbTime = new System.Windows.Forms.GroupBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDataManage = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.d_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_h_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_p_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_p_Card = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_p_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_LastTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_ThisTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_LastWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_ThisWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_LastPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_ThisPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_WaterCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_PowerCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_WaterMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_PowerMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_AllMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.h_Remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.gbDel = new System.Windows.Forms.GroupBox();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPowerPrice = new System.Windows.Forms.Label();
            this.lbWaterPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPeople = new System.Windows.Forms.TextBox();
            this.txtHouse = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbMany = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnExportByPeople = new System.Windows.Forms.Button();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.dbTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataManage)).BeginInit();
            this.gbDel.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMany.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbTime
            // 
            this.dbTime.Controls.Add(this.dtpFrom);
            this.dbTime.Controls.Add(this.btnShowAll);
            this.dbTime.Controls.Add(this.btnSearch);
            this.dbTime.Controls.Add(this.dtpTo);
            this.dbTime.Controls.Add(this.label2);
            this.dbTime.Controls.Add(this.label1);
            this.dbTime.Location = new System.Drawing.Point(12, 12);
            this.dbTime.Name = "dbTime";
            this.dbTime.Size = new System.Drawing.Size(240, 74);
            this.dbTime.TabIndex = 0;
            this.dbTime.TabStop = false;
            this.dbTime.Text = "查询时间段";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(29, 18);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(121, 21);
            this.dtpFrom.TabIndex = 8;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(156, 46);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 7;
            this.btnShowAll.Text = "显示全部";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(156, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "";
            this.dtpTo.Location = new System.Drawing.Point(29, 45);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(121, 21);
            this.dtpTo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "至";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "自";
            // 
            // dgvDataManage
            // 
            this.dgvDataManage.AllowUserToAddRows = false;
            this.dgvDataManage.AllowUserToDeleteRows = false;
            this.dgvDataManage.AllowUserToOrderColumns = true;
            this.dgvDataManage.AllowUserToResizeRows = false;
            this.dgvDataManage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataManage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDataManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.d_ID,
            this.d_h_ID,
            this.h_Name,
            this.d_p_Name,
            this.d_p_Card,
            this.d_p_Department,
            this.d_LastTime,
            this.d_ThisTime,
            this.d_LastWater,
            this.d_ThisWater,
            this.d_LastPower,
            this.d_ThisPower,
            this.d_WaterCount,
            this.d_PowerCount,
            this.d_WaterMoney,
            this.d_PowerMoney,
            this.d_AllMoney,
            this.h_Remark});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDataManage.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDataManage.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvDataManage.Location = new System.Drawing.Point(12, 92);
            this.dgvDataManage.Name = "dgvDataManage";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDataManage.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDataManage.RowHeadersVisible = false;
            this.dgvDataManage.RowTemplate.Height = 23;
            this.dgvDataManage.Size = new System.Drawing.Size(1070, 618);
            this.dgvDataManage.TabIndex = 6;
            this.dgvDataManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataManage_CellClick);
            this.dgvDataManage.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDataManage_DataError);
            // 
            // select
            // 
            this.select.HeaderText = "选择";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.ToolTipText = "单击以选择";
            this.select.Width = 50;
            // 
            // d_ID
            // 
            this.d_ID.DataPropertyName = "d_ID";
            this.d_ID.HeaderText = "编号";
            this.d_ID.Name = "d_ID";
            this.d_ID.Visible = false;
            // 
            // d_h_ID
            // 
            this.d_h_ID.DataPropertyName = "d_h_ID";
            this.d_h_ID.HeaderText = "住房编号";
            this.d_h_ID.Name = "d_h_ID";
            this.d_h_ID.Visible = false;
            // 
            // h_Name
            // 
            this.h_Name.DataPropertyName = "h_Name";
            this.h_Name.HeaderText = "住房名称";
            this.h_Name.Name = "h_Name";
            this.h_Name.ReadOnly = true;
            // 
            // d_p_Name
            // 
            this.d_p_Name.DataPropertyName = "d_p_Name";
            this.d_p_Name.HeaderText = "教职工姓名";
            this.d_p_Name.Name = "d_p_Name";
            this.d_p_Name.ReadOnly = true;
            // 
            // d_p_Card
            // 
            this.d_p_Card.DataPropertyName = "d_p_Card";
            this.d_p_Card.HeaderText = "账号";
            this.d_p_Card.Name = "d_p_Card";
            // 
            // d_p_Department
            // 
            this.d_p_Department.DataPropertyName = "d_p_Department";
            this.d_p_Department.HeaderText = "部门编号";
            this.d_p_Department.Name = "d_p_Department";
            this.d_p_Department.Width = 80;
            // 
            // d_LastTime
            // 
            this.d_LastTime.DataPropertyName = "d_LastTime";
            this.d_LastTime.HeaderText = "上次抄表时间";
            this.d_LastTime.Name = "d_LastTime";
            // 
            // d_ThisTime
            // 
            this.d_ThisTime.DataPropertyName = "d_ThisTime";
            this.d_ThisTime.HeaderText = "本次抄表时间";
            this.d_ThisTime.Name = "d_ThisTime";
            // 
            // d_LastWater
            // 
            this.d_LastWater.DataPropertyName = "d_LastWater";
            this.d_LastWater.HeaderText = "上次水表读数";
            this.d_LastWater.Name = "d_LastWater";
            // 
            // d_ThisWater
            // 
            this.d_ThisWater.DataPropertyName = "d_ThisWater";
            this.d_ThisWater.HeaderText = "本次水表读数";
            this.d_ThisWater.Name = "d_ThisWater";
            // 
            // d_LastPower
            // 
            this.d_LastPower.DataPropertyName = "d_LastPower";
            this.d_LastPower.HeaderText = "上次电表读数";
            this.d_LastPower.Name = "d_LastPower";
            // 
            // d_ThisPower
            // 
            this.d_ThisPower.DataPropertyName = "d_ThisPower";
            this.d_ThisPower.HeaderText = "本次电表读数";
            this.d_ThisPower.Name = "d_ThisPower";
            // 
            // d_WaterCount
            // 
            this.d_WaterCount.DataPropertyName = "d_WaterCount";
            this.d_WaterCount.HeaderText = "用水量/吨";
            this.d_WaterCount.Name = "d_WaterCount";
            // 
            // d_PowerCount
            // 
            this.d_PowerCount.DataPropertyName = "d_PowerCount";
            this.d_PowerCount.HeaderText = "用电量/度";
            this.d_PowerCount.Name = "d_PowerCount";
            // 
            // d_WaterMoney
            // 
            this.d_WaterMoney.DataPropertyName = "d_WaterMoney";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.d_WaterMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.d_WaterMoney.HeaderText = "水费/元";
            this.d_WaterMoney.Name = "d_WaterMoney";
            this.d_WaterMoney.Width = 80;
            // 
            // d_PowerMoney
            // 
            this.d_PowerMoney.DataPropertyName = "d_PowerMoney";
            dataGridViewCellStyle3.Format = "N2";
            this.d_PowerMoney.DefaultCellStyle = dataGridViewCellStyle3;
            this.d_PowerMoney.HeaderText = "电费/元";
            this.d_PowerMoney.Name = "d_PowerMoney";
            this.d_PowerMoney.Width = 80;
            // 
            // d_AllMoney
            // 
            this.d_AllMoney.DataPropertyName = "d_AllMoney";
            dataGridViewCellStyle4.Format = "N2";
            this.d_AllMoney.DefaultCellStyle = dataGridViewCellStyle4;
            this.d_AllMoney.HeaderText = "合计费用/元";
            this.d_AllMoney.Name = "d_AllMoney";
            this.d_AllMoney.Width = 120;
            // 
            // h_Remark
            // 
            this.h_Remark.DataPropertyName = "h_Remark";
            this.h_Remark.HeaderText = "备注";
            this.h_Remark.Name = "h_Remark";
            this.h_Remark.Width = 60;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(921, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(69, 45);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(120, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除选中行";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1002, 31);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(80, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "导出明细";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // gbDel
            // 
            this.gbDel.Controls.Add(this.btnInverse);
            this.gbDel.Controls.Add(this.btnNone);
            this.gbDel.Controls.Add(this.btnAll);
            this.gbDel.Controls.Add(this.btnDel);
            this.gbDel.Location = new System.Drawing.Point(612, 12);
            this.gbDel.Name = "gbDel";
            this.gbDel.Size = new System.Drawing.Size(199, 74);
            this.gbDel.TabIndex = 10;
            this.gbDel.TabStop = false;
            this.gbDel.Text = "删除选项，请及时删除无用数据";
            // 
            // btnInverse
            // 
            this.btnInverse.Location = new System.Drawing.Point(132, 19);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(57, 23);
            this.btnInverse.TabIndex = 13;
            this.btnInverse.Text = "反选";
            this.btnInverse.UseVisualStyleBackColor = true;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(69, 19);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(57, 23);
            this.btnNone.TabIndex = 12;
            this.btnNone.Text = "全不选";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(6, 19);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(57, 23);
            this.btnAll.TabIndex = 11;
            this.btnAll.Text = "全选";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.btnChange);
            this.gbInfo.Controls.Add(this.label6);
            this.gbInfo.Controls.Add(this.label5);
            this.gbInfo.Controls.Add(this.lbPowerPrice);
            this.gbInfo.Controls.Add(this.lbWaterPrice);
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Location = new System.Drawing.Point(414, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(192, 74);
            this.gbInfo.TabIndex = 11;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "电费/水费";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(137, 46);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(49, 23);
            this.btnChange.TabIndex = 6;
            this.btnChange.Text = "修改";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "元/吨";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "元/度";
            // 
            // lbPowerPrice
            // 
            this.lbPowerPrice.AutoSize = true;
            this.lbPowerPrice.Location = new System.Drawing.Point(53, 24);
            this.lbPowerPrice.Name = "lbPowerPrice";
            this.lbPowerPrice.Size = new System.Drawing.Size(0, 12);
            this.lbPowerPrice.TabIndex = 3;
            // 
            // lbWaterPrice
            // 
            this.lbWaterPrice.AutoSize = true;
            this.lbWaterPrice.Location = new System.Drawing.Point(53, 50);
            this.lbWaterPrice.Name = "lbWaterPrice";
            this.lbWaterPrice.Size = new System.Drawing.Size(0, 12);
            this.lbWaterPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "水费：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "电费：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPeople);
            this.groupBox1.Controls.Add(this.txtHouse);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(258, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 74);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "按房名/人名查询";
            // 
            // txtPeople
            // 
            this.txtPeople.Location = new System.Drawing.Point(53, 48);
            this.txtPeople.MaxLength = 20;
            this.txtPeople.Name = "txtPeople";
            this.txtPeople.Size = new System.Drawing.Size(87, 21);
            this.txtPeople.TabIndex = 4;
            this.txtPeople.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeople_KeyPress);
            // 
            // txtHouse
            // 
            this.txtHouse.Location = new System.Drawing.Point(53, 21);
            this.txtHouse.MaxLength = 20;
            this.txtHouse.Name = "txtHouse";
            this.txtHouse.Size = new System.Drawing.Size(87, 21);
            this.txtHouse.TabIndex = 3;
            this.txtHouse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHouse_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "人名：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "房名：";
            // 
            // gbMany
            // 
            this.gbMany.Controls.Add(this.btnIn);
            this.gbMany.Controls.Add(this.btnOut);
            this.gbMany.Location = new System.Drawing.Point(817, 12);
            this.gbMany.Name = "gbMany";
            this.gbMany.Size = new System.Drawing.Size(98, 74);
            this.gbMany.TabIndex = 13;
            this.gbMany.TabStop = false;
            this.gbMany.Text = "批量数据处理";
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(6, 46);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(86, 23);
            this.btnIn.TabIndex = 1;
            this.btnIn.Text = "导入";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(6, 20);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(86, 23);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "导出";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // btnExportByPeople
            // 
            this.btnExportByPeople.Location = new System.Drawing.Point(1002, 57);
            this.btnExportByPeople.Name = "btnExportByPeople";
            this.btnExportByPeople.Size = new System.Drawing.Size(80, 23);
            this.btnExportByPeople.TabIndex = 14;
            this.btnExportByPeople.Text = "按人员导出";
            this.btnExportByPeople.UseVisualStyleBackColor = true;
            this.btnExportByPeople.Click += new System.EventHandler(this.btnExportByPeople_Click);
            // 
            // ofdExcel
            // 
            this.ofdExcel.FileName = "openFileDialog1";
            // 
            // DataManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 722);
            this.Controls.Add(this.btnExportByPeople);
            this.Controls.Add(this.gbMany);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbDel);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDataManage);
            this.Controls.Add(this.dbTime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1110, 760);
            this.Name = "DataManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "数据管理界面(ESC键关闭窗口)";
            this.Load += new System.EventHandler(this.DataManage_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataManage_KeyPress);
            this.dbTime.ResumeLayout(false);
            this.dbTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataManage)).EndInit();
            this.gbDel.ResumeLayout(false);
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbMany.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox dbTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDataManage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.GroupBox gbDel;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPowerPrice;
        private System.Windows.Forms.Label lbWaterPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPeople;
        private System.Windows.Forms.TextBox txtHouse;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_h_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_p_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_p_Card;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_p_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_LastTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_ThisTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_LastWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_ThisWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_LastPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_ThisPower;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_WaterCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_PowerCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_WaterMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_PowerMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_AllMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn h_Remark;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.GroupBox gbMany;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnExportByPeople;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
    }
}