﻿
namespace Grafine
{
    partial class SandelysSarasas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataGridViewWarehouses = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTakenSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFreeSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Controls.Add(this.dataGridViewWarehouses);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 512);
            this.panel1.TabIndex = 5;
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturn.Location = new System.Drawing.Point(631, 451);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(108, 52);
            this.buttonReturn.TabIndex = 12;
            this.buttonReturn.Text = "Grįžti";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // dataGridViewWarehouses
            // 
            this.dataGridViewWarehouses.AllowUserToAddRows = false;
            this.dataGridViewWarehouses.AllowUserToDeleteRows = false;
            this.dataGridViewWarehouses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWarehouses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnCode,
            this.ColumnTakenSpace,
            this.ColumnFreeSpace,
            this.ColumnList,
            this.ColumnDelete});
            this.dataGridViewWarehouses.Location = new System.Drawing.Point(11, 153);
            this.dataGridViewWarehouses.Name = "dataGridViewWarehouses";
            this.dataGridViewWarehouses.ReadOnly = true;
            this.dataGridViewWarehouses.Size = new System.Drawing.Size(727, 292);
            this.dataGridViewWarehouses.TabIndex = 2;
            this.dataGridViewWarehouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWarehouses_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(751, 145);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(179, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sandėlių Sąrašas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Pavadinimas";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // ColumnCode
            // 
            this.ColumnCode.HeaderText = "Vidinis Kodas";
            this.ColumnCode.Name = "ColumnCode";
            this.ColumnCode.ReadOnly = true;
            // 
            // ColumnTakenSpace
            // 
            this.ColumnTakenSpace.HeaderText = "Užimtumas";
            this.ColumnTakenSpace.Name = "ColumnTakenSpace";
            this.ColumnTakenSpace.ReadOnly = true;
            // 
            // ColumnFreeSpace
            // 
            this.ColumnFreeSpace.HeaderText = "Laisvas_Plotas";
            this.ColumnFreeSpace.Name = "ColumnFreeSpace";
            this.ColumnFreeSpace.ReadOnly = true;
            // 
            // ColumnList
            // 
            this.ColumnList.HeaderText = "Prekių_Sąrašas";
            this.ColumnList.Name = "ColumnList";
            this.ColumnList.ReadOnly = true;
            // 
            // ColumnDelete
            // 
            this.ColumnDelete.HeaderText = "Šalinti";
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.ReadOnly = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefresh.Location = new System.Drawing.Point(517, 451);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 52);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "Atstatyti";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // SandelysSarasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 512);
            this.Controls.Add(this.panel1);
            this.Name = "SandelysSarasas";
            this.Text = "SandelysSarasas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewWarehouses;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTakenSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFreeSpace;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnList;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.Button buttonRefresh;
    }
}