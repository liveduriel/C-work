﻿namespace e1
{
    partial class RenewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.require = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conWeb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.duty,
            this.require,
            this.address,
            this.conName,
            this.conWeb,
            this.conInfo});
            this.dataGridView1.Location = new System.Drawing.Point(33, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(814, 463);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // name
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.name.DefaultCellStyle = dataGridViewCellStyle1;
            this.name.HeaderText = "岗位名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 150;
            // 
            // duty
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.duty.DefaultCellStyle = dataGridViewCellStyle2;
            this.duty.HeaderText = "岗位职责";
            this.duty.Name = "duty";
            this.duty.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.duty.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.duty.Width = 200;
            // 
            // require
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.require.DefaultCellStyle = dataGridViewCellStyle3;
            this.require.HeaderText = "岗位要求";
            this.require.Name = "require";
            this.require.ReadOnly = true;
            this.require.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.require.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.require.Width = 200;
            // 
            // address
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.address.DefaultCellStyle = dataGridViewCellStyle4;
            this.address.HeaderText = "工作地点";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.address.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // conName
            // 
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.conName.DefaultCellStyle = dataGridViewCellStyle5;
            this.conName.HeaderText = "公司名称";
            this.conName.Name = "conName";
            this.conName.ReadOnly = true;
            this.conName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // conWeb
            // 
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.conWeb.DefaultCellStyle = dataGridViewCellStyle6;
            this.conWeb.HeaderText = "公司网址";
            this.conWeb.Name = "conWeb";
            this.conWeb.ReadOnly = true;
            this.conWeb.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conWeb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // conInfo
            // 
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.conInfo.DefaultCellStyle = dataGridViewCellStyle7;
            this.conInfo.HeaderText = "公司简介";
            this.conInfo.Name = "conInfo";
            this.conInfo.ReadOnly = true;
            this.conInfo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.conInfo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.conInfo.Width = 200;
            // 
            // RenewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 573);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RenewForm";
            this.Text = "display";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn duty;
        private System.Windows.Forms.DataGridViewTextBoxColumn require;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn conName;
        private System.Windows.Forms.DataGridViewTextBoxColumn conWeb;
        private System.Windows.Forms.DataGridViewTextBoxColumn conInfo;
    }
}