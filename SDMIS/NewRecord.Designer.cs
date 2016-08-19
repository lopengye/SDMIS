namespace SDMIS
{
    partial class NewRecord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewRecord));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpLast = new System.Windows.Forms.DateTimePicker();
            this.dtpThis = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvNewRecord = new System.Windows.Forms.DataGridView();
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
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPowerPrice = new System.Windows.Forms.Label();
            this.lbWaterPrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.sfdExcel = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExportByCard = new System.Windows.Forms.Button();
            this.gbMany = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
            this.ofdExcel = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewRecord)).BeginInit();
            this.gbTime.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbMany.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "上次抄表时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "本次抄表时间：";
            // 
            // dtpLast
            // 
            this.dtpLast.CustomFormat = "";
            this.dtpLast.Enabled = false;
            this.dtpLast.Location = new System.Drawing.Point(101, 19);
            this.dtpLast.Name = "dtpLast";
            this.dtpLast.Size = new System.Drawing.Size(122, 21);
            this.dtpLast.TabIndex = 2;
            // 
            // dtpThis
            // 
            this.dtpThis.Location = new System.Drawing.Point(101, 45);
            this.dtpThis.Name = "dtpThis";
            this.dtpThis.Size = new System.Drawing.Size(122, 21);
            this.dtpThis.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(447, 58);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "确定添加数据";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvNewRecord
            // 
            this.dgvNewRecord.AllowUserToAddRows = false;
            this.dgvNewRecord.AllowUserToDeleteRows = false;
            this.dgvNewRecord.AllowUserToOrderColumns = true;
            this.dgvNewRecord.AllowUserToResizeRows = false;
            this.dgvNewRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewRecord.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNewRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dgvNewRecord.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNewRecord.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvNewRecord.Location = new System.Drawing.Point(12, 92);
            this.dgvNewRecord.Name = "dgvNewRecord";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewRecord.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNewRecord.RowHeadersVisible = false;
            this.dgvNewRecord.RowTemplate.Height = 23;
            this.dgvNewRecord.Size = new System.Drawing.Size(1070, 618);
            this.dgvNewRecord.TabIndex = 5;
            this.dgvNewRecord.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvNewRecord_DataError);
            // 
            // d_ID
            // 
            this.d_ID.DataPropertyName = "d_ID";
            this.d_ID.HeaderText = "编号";
            this.d_ID.Name = "d_ID";
            this.d_ID.Width = 60;
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
            this.d_WaterCount.ReadOnly = true;
            // 
            // d_PowerCount
            // 
            this.d_PowerCount.DataPropertyName = "d_PowerCount";
            this.d_PowerCount.HeaderText = "用电量/度";
            this.d_PowerCount.Name = "d_PowerCount";
            this.d_PowerCount.ReadOnly = true;
            // 
            // d_WaterMoney
            // 
            this.d_WaterMoney.DataPropertyName = "d_WaterMoney";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.d_WaterMoney.DefaultCellStyle = dataGridViewCellStyle2;
            this.d_WaterMoney.HeaderText = "水费/元";
            this.d_WaterMoney.Name = "d_WaterMoney";
            this.d_WaterMoney.ReadOnly = true;
            this.d_WaterMoney.Width = 80;
            // 
            // d_PowerMoney
            // 
            this.d_PowerMoney.DataPropertyName = "d_PowerMoney";
            dataGridViewCellStyle3.Format = "N2";
            this.d_PowerMoney.DefaultCellStyle = dataGridViewCellStyle3;
            this.d_PowerMoney.HeaderText = "电费/元";
            this.d_PowerMoney.Name = "d_PowerMoney";
            this.d_PowerMoney.ReadOnly = true;
            this.d_PowerMoney.Width = 80;
            // 
            // d_AllMoney
            // 
            this.d_AllMoney.DataPropertyName = "d_AllMoney";
            dataGridViewCellStyle4.Format = "N2";
            this.d_AllMoney.DefaultCellStyle = dataGridViewCellStyle4;
            this.d_AllMoney.HeaderText = "合计费用/元";
            this.d_AllMoney.Name = "d_AllMoney";
            this.d_AllMoney.ReadOnly = true;
            this.d_AllMoney.Width = 120;
            // 
            // h_Remark
            // 
            this.h_Remark.DataPropertyName = "h_Remark";
            this.h_Remark.HeaderText = "备注";
            this.h_Remark.Name = "h_Remark";
            this.h_Remark.Width = 60;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.label1);
            this.gbTime.Controls.Add(this.dtpLast);
            this.gbTime.Controls.Add(this.label2);
            this.gbTime.Controls.Add(this.dtpThis);
            this.gbTime.Location = new System.Drawing.Point(12, 12);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(232, 74);
            this.gbTime.TabIndex = 6;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "抄表时间";
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
            this.gbInfo.Location = new System.Drawing.Point(250, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(191, 74);
            this.gbInfo.TabIndex = 7;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "电费/水费";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(135, 46);
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
            this.label6.Location = new System.Drawing.Point(94, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "元/吨";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "元/度";
            // 
            // lbPowerPrice
            // 
            this.lbPowerPrice.AutoSize = true;
            this.lbPowerPrice.Location = new System.Drawing.Point(53, 25);
            this.lbPowerPrice.Name = "lbPowerPrice";
            this.lbPowerPrice.Size = new System.Drawing.Size(0, 12);
            this.lbPowerPrice.TabIndex = 3;
            // 
            // lbWaterPrice
            // 
            this.lbWaterPrice.AutoSize = true;
            this.lbWaterPrice.Location = new System.Drawing.Point(53, 51);
            this.lbWaterPrice.Name = "lbWaterPrice";
            this.lbWaterPrice.Size = new System.Drawing.Size(0, 12);
            this.lbWaterPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "水费：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "电费：";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(559, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "保存表中数据";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExport
            // 
            this.btnExport.Enabled = false;
            this.btnExport.Location = new System.Drawing.Point(6, 20);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "导出明细";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExportByCard);
            this.groupBox1.Controls.Add(this.btnExport);
            this.groupBox1.Location = new System.Drawing.Point(775, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 74);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "更多选项";
            // 
            // btnExportByCard
            // 
            this.btnExportByCard.Enabled = false;
            this.btnExportByCard.Location = new System.Drawing.Point(6, 46);
            this.btnExportByCard.Name = "btnExportByCard";
            this.btnExportByCard.Size = new System.Drawing.Size(133, 23);
            this.btnExportByCard.TabIndex = 10;
            this.btnExportByCard.Text = "按账号导出";
            this.btnExportByCard.UseVisualStyleBackColor = true;
            this.btnExportByCard.Click += new System.EventHandler(this.btnExportByCard_Click);
            // 
            // gbMany
            // 
            this.gbMany.Controls.Add(this.btnIn);
            this.gbMany.Controls.Add(this.btnOut);
            this.gbMany.Location = new System.Drawing.Point(671, 12);
            this.gbMany.Name = "gbMany";
            this.gbMany.Size = new System.Drawing.Size(98, 74);
            this.gbMany.TabIndex = 12;
            this.gbMany.TabStop = false;
            this.gbMany.Text = "批量数据处理";
            // 
            // btnIn
            // 
            this.btnIn.Enabled = false;
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
            this.btnOut.Enabled = false;
            this.btnOut.Location = new System.Drawing.Point(6, 20);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(86, 23);
            this.btnOut.TabIndex = 0;
            this.btnOut.Text = "导出";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // NewRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 722);
            this.Controls.Add(this.gbMany);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.dgvNewRecord);
            this.Controls.Add(this.btnAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(1110, 760);
            this.Name = "NewRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加抄表数据(ESC键关闭窗口)";
            this.Load += new System.EventHandler(this.NewRecord_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewRecord_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewRecord)).EndInit();
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbMany.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpLast;
        private System.Windows.Forms.DateTimePicker dtpThis;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvNewRecord;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPowerPrice;
        private System.Windows.Forms.Label lbWaterPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog sfdExcel;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExportByCard;
        private System.Windows.Forms.GroupBox gbMany;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.OpenFileDialog ofdExcel;
    }
}