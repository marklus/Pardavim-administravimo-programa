
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.dataGridViewWarehouses = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTakenSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFreeSpace = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnList = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pradinisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katalogasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pardavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirkimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paskyraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonReturn);
            this.panel1.Controls.Add(this.dataGridViewWarehouses);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 450);
            this.panel1.TabIndex = 5;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonRefresh.Location = new System.Drawing.Point(528, 325);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 52);
            this.buttonRefresh.TabIndex = 13;
            this.buttonRefresh.Text = "Atstatyti";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonReturn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonReturn.Location = new System.Drawing.Point(642, 325);
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
            this.ColumnDelete,
            this.ColumnModify});
            this.dataGridViewWarehouses.Location = new System.Drawing.Point(12, 22);
            this.dataGridViewWarehouses.Name = "dataGridViewWarehouses";
            this.dataGridViewWarehouses.ReadOnly = true;
            this.dataGridViewWarehouses.Size = new System.Drawing.Size(739, 292);
            this.dataGridViewWarehouses.TabIndex = 2;
            this.dataGridViewWarehouses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWarehouses_CellContentClick);
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
            // ColumnModify
            // 
            this.ColumnModify.HeaderText = "Modifikuoti";
            this.ColumnModify.Name = "ColumnModify";
            this.ColumnModify.ReadOnly = true;
            this.ColumnModify.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnModify.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem,
            this.paskyraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 76);
            this.menuStrip1.TabIndex = 44;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.meniuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pradinisToolStripMenuItem,
            this.katalogasToolStripMenuItem,
            this.pardavimaiToolStripMenuItem,
            this.pirkimaiToolStripMenuItem});
            this.meniuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.meniuToolStripMenuItem.Image = global::Grafine.Properties.Resources.icon_128x128;
            this.meniuToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(72, 72);
            // 
            // pradinisToolStripMenuItem
            // 
            this.pradinisToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.pradinisToolStripMenuItem.Name = "pradinisToolStripMenuItem";
            this.pradinisToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pradinisToolStripMenuItem.Text = "Pradinis";
            this.pradinisToolStripMenuItem.Click += new System.EventHandler(this.pradinisToolStripMenuItem_Click);
            // 
            // katalogasToolStripMenuItem
            // 
            this.katalogasToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.katalogasToolStripMenuItem.Name = "katalogasToolStripMenuItem";
            this.katalogasToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.katalogasToolStripMenuItem.Text = "Katalogas";
            this.katalogasToolStripMenuItem.Click += new System.EventHandler(this.katalogasToolStripMenuItem_Click);
            // 
            // pardavimaiToolStripMenuItem
            // 
            this.pardavimaiToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.pardavimaiToolStripMenuItem.Name = "pardavimaiToolStripMenuItem";
            this.pardavimaiToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pardavimaiToolStripMenuItem.Text = "Pardavimai";
            // 
            // pirkimaiToolStripMenuItem
            // 
            this.pirkimaiToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.pirkimaiToolStripMenuItem.Name = "pirkimaiToolStripMenuItem";
            this.pirkimaiToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pirkimaiToolStripMenuItem.Text = "Pirkimai";
            // 
            // paskyraToolStripMenuItem
            // 
            this.paskyraToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.paskyraToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.paskyraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacijaToolStripMenuItem,
            this.atsijungtiToolStripMenuItem});
            this.paskyraToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.paskyraToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.paskyraToolStripMenuItem.Image = global::Grafine.Properties.Resources.User_icon_2_svg;
            this.paskyraToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.paskyraToolStripMenuItem.Name = "paskyraToolStripMenuItem";
            this.paskyraToolStripMenuItem.Size = new System.Drawing.Size(70, 72);
            this.paskyraToolStripMenuItem.Text = "Paskyra";
            this.paskyraToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // informacijaToolStripMenuItem
            // 
            this.informacijaToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.informacijaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.informacijaToolStripMenuItem.Name = "informacijaToolStripMenuItem";
            this.informacijaToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.informacijaToolStripMenuItem.Text = "Informacija";
            this.informacijaToolStripMenuItem.Click += new System.EventHandler(this.informacijaToolStripMenuItem_Click);
            // 
            // atsijungtiToolStripMenuItem
            // 
            this.atsijungtiToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.atsijungtiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.atsijungtiToolStripMenuItem.Name = "atsijungtiToolStripMenuItem";
            this.atsijungtiToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.atsijungtiToolStripMenuItem.Text = "Atsijungti";
            this.atsijungtiToolStripMenuItem.Click += new System.EventHandler(this.atsijungtiToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label2.Location = new System.Drawing.Point(185, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 64);
            this.label2.TabIndex = 45;
            this.label2.Text = "Sandėlių sąrašas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(762, 5);
            this.panel4.TabIndex = 47;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1, 390);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(762, 5);
            this.panel2.TabIndex = 48;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 394);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(762, 57);
            this.panel3.TabIndex = 49;
            // 
            // SandelysSarasas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SandelysSarasas";
            this.Text = "SandelysSarasas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWarehouses)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewWarehouses;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTakenSpace;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFreeSpace;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnList;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnModify;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pradinisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katalogasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pardavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirkimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paskyraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
    }
}