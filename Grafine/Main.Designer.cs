namespace Grafine
{
    partial class Main
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
            this.dataGridViewContent = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBuyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSeller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pradinisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katalogasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pardavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirkimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paskyraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).BeginInit();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.dataGridViewContent);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 379);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewContent
            // 
            this.dataGridViewContent.AllowUserToAddRows = false;
            this.dataGridViewContent.AllowUserToDeleteRows = false;
            this.dataGridViewContent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnDate,
            this.ColumnBuyer,
            this.ColumnSeller,
            this.ColumnPart,
            this.ColumnAmount,
            this.ColumnType});
            this.dataGridViewContent.Location = new System.Drawing.Point(3, 39);
            this.dataGridViewContent.Name = "dataGridViewContent";
            this.dataGridViewContent.ReadOnly = true;
            this.dataGridViewContent.Size = new System.Drawing.Size(897, 319);
            this.dataGridViewContent.TabIndex = 41;
            this.dataGridViewContent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewContent_CellContentClick);
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Data";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            // 
            // ColumnBuyer
            // 
            this.ColumnBuyer.HeaderText = "Užsakovas";
            this.ColumnBuyer.Name = "ColumnBuyer";
            this.ColumnBuyer.ReadOnly = true;
            // 
            // ColumnSeller
            // 
            this.ColumnSeller.HeaderText = "Pardavėjas";
            this.ColumnSeller.Name = "ColumnSeller";
            this.ColumnSeller.ReadOnly = true;
            // 
            // ColumnPart
            // 
            this.ColumnPart.HeaderText = "Prekė";
            this.ColumnPart.Name = "ColumnPart";
            this.ColumnPart.ReadOnly = true;
            // 
            // ColumnAmount
            // 
            this.ColumnAmount.HeaderText = "Kiekis";
            this.ColumnAmount.Name = "ColumnAmount";
            this.ColumnAmount.ReadOnly = true;
            // 
            // ColumnType
            // 
            this.ColumnType.HeaderText = "Tipas";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 5);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(0, 443);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(903, 60);
            this.panel3.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 46);
            this.button4.TabIndex = 42;
            this.button4.Text = "Atstatyti";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(903, 76);
            this.menuStrip1.TabIndex = 39;
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
            this.pradinisToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.pradinisToolStripMenuItem.Text = "Pradinis";
            this.pradinisToolStripMenuItem.Click += new System.EventHandler(this.pradinisToolStripMenuItem_Click);
            // 
            // katalogasToolStripMenuItem
            // 
            this.katalogasToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.katalogasToolStripMenuItem.Name = "katalogasToolStripMenuItem";
            this.katalogasToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.katalogasToolStripMenuItem.Text = "Katalogas";
            this.katalogasToolStripMenuItem.Click += new System.EventHandler(this.katalogasToolStripMenuItem_Click);
            // 
            // pardavimaiToolStripMenuItem
            // 
            this.pardavimaiToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.pardavimaiToolStripMenuItem.Name = "pardavimaiToolStripMenuItem";
            this.pardavimaiToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.pardavimaiToolStripMenuItem.Text = "Pardavimai";
            // 
            // pirkimaiToolStripMenuItem
            // 
            this.pirkimaiToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.pirkimaiToolStripMenuItem.Name = "pirkimaiToolStripMenuItem";
            this.pirkimaiToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
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
            this.informacijaToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.informacijaToolStripMenuItem.Text = "Informacija";
            this.informacijaToolStripMenuItem.Click += new System.EventHandler(this.informacijaToolStripMenuItem_Click);
            // 
            // atsijungtiToolStripMenuItem
            // 
            this.atsijungtiToolStripMenuItem.BackColor = System.Drawing.Color.Gray;
            this.atsijungtiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.atsijungtiToolStripMenuItem.Name = "atsijungtiToolStripMenuItem";
            this.atsijungtiToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.atsijungtiToolStripMenuItem.Text = "Atsijungti";
            this.atsijungtiToolStripMenuItem.Click += new System.EventHandler(this.atsijungtiToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 59);
            this.label1.TabIndex = 40;
            this.label1.Text = "Pagrindinis";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Main";
            this.Text = "Main";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContent)).EndInit();
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pradinisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katalogasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pardavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirkimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paskyraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBuyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSeller;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.Button button4;
    }
}