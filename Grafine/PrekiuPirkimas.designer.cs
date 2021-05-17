
namespace Grafine
{
    partial class PrekiuPirkimas
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
            this.label1 = new System.Windows.Forms.Label();
            this.Add_Button = new System.Windows.Forms.Button();
            this.comboBoxWarehouse = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFree = new System.Windows.Forms.TextBox();
            this.textBoxTaken = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pradinisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katalogasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pardavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirkimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paskyraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pasirinkite sandelį";
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Add_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Button.Location = new System.Drawing.Point(194, 264);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(133, 52);
            this.Add_Button.TabIndex = 17;
            this.Add_Button.Text = "Pridėti naują";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(239, 103);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(305, 33);
            this.comboBoxWarehouse.TabIndex = 18;
            this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kiekis";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownAmount.Location = new System.Drawing.Point(102, 168);
            this.numericUpDownAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAmount.Name = "numericUpDownAmount";
            this.numericUpDownAmount.Size = new System.Drawing.Size(66, 31);
            this.numericUpDownAmount.TabIndex = 20;
            this.numericUpDownAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Laisvas Plotas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFree
            // 
            this.textBoxFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFree.Location = new System.Drawing.Point(444, 165);
            this.textBoxFree.Name = "textBoxFree";
            this.textBoxFree.ReadOnly = true;
            this.textBoxFree.Size = new System.Drawing.Size(100, 31);
            this.textBoxFree.TabIndex = 22;
            // 
            // textBoxTaken
            // 
            this.textBoxTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTaken.Location = new System.Drawing.Point(444, 206);
            this.textBoxTaken.Name = "textBoxTaken";
            this.textBoxTaken.ReadOnly = true;
            this.textBoxTaken.Size = new System.Drawing.Size(100, 31);
            this.textBoxTaken.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(234, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Užimtas Plotas";
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
            this.menuStrip1.Size = new System.Drawing.Size(565, 76);
            this.menuStrip1.TabIndex = 43;
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.DarkGray;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 61);
            this.label8.TabIndex = 44;
            this.label8.Text = "Pirkimas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 5);
            this.panel1.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 340);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 57);
            this.panel3.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 339);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 5);
            this.panel2.TabIndex = 51;
            // 
            // PrekiuPirkimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(565, 398);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxTaken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxWarehouse);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.label1);
            this.Name = "PrekiuPirkimas";
            this.Text = "PrekiuPirkimas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_Button;
        private System.Windows.Forms.ComboBox comboBoxWarehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFree;
        private System.Windows.Forms.TextBox textBoxTaken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pradinisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katalogasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pardavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirkimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paskyraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}