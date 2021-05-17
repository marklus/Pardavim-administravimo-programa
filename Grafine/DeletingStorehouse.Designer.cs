namespace Grafine
{
    partial class DeletingStorehouse
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
            this.checkBoxDeleteParts = new System.Windows.Forms.CheckBox();
            this.labelBack = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxStorehouseId = new System.Windows.Forms.TextBox();
            this.textBoxStorehouseName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxDeleteParts
            // 
            this.checkBoxDeleteParts.AutoSize = true;
            this.checkBoxDeleteParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeleteParts.Location = new System.Drawing.Point(155, 203);
            this.checkBoxDeleteParts.Name = "checkBoxDeleteParts";
            this.checkBoxDeleteParts.Size = new System.Drawing.Size(291, 24);
            this.checkBoxDeleteParts.TabIndex = 36;
            this.checkBoxDeleteParts.Text = "Ištrinti ir sandėlyje laikomas dalis";
            this.checkBoxDeleteParts.UseVisualStyleBackColor = true;
            this.checkBoxDeleteParts.CheckedChanged += new System.EventHandler(this.checkBoxDeleteParts_CheckedChanged);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Arial Narrow", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelBack.Location = new System.Drawing.Point(268, 295);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(46, 22);
            this.labelBack.TabIndex = 35;
            this.labelBack.Text = "Atgal";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonDelete.Location = new System.Drawing.Point(224, 241);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(136, 42);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Ištrinti";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxStorehouseId
            // 
            this.textBoxStorehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseId.Location = new System.Drawing.Point(159, 149);
            this.textBoxStorehouseId.Multiline = true;
            this.textBoxStorehouseId.Name = "textBoxStorehouseId";
            this.textBoxStorehouseId.Size = new System.Drawing.Size(288, 33);
            this.textBoxStorehouseId.TabIndex = 33;
            this.textBoxStorehouseId.Text = "sanID";
            // 
            // textBoxStorehouseName
            // 
            this.textBoxStorehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseName.Location = new System.Drawing.Point(159, 108);
            this.textBoxStorehouseName.Multiline = true;
            this.textBoxStorehouseName.Name = "textBoxStorehouseName";
            this.textBoxStorehouseName.Size = new System.Drawing.Size(288, 35);
            this.textBoxStorehouseName.TabIndex = 31;
            this.textBoxStorehouseName.Text = "Sandėlio pavadinimas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.checkBoxDeleteParts);
            this.panel1.Controls.Add(this.labelBack);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.textBoxStorehouseId);
            this.panel1.Controls.Add(this.textBoxStorehouseName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 390);
            this.panel1.TabIndex = 5;
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
            this.menuStrip1.TabIndex = 45;
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
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 60);
            this.label2.TabIndex = 46;
            this.label2.Text = "Sandėlio šalinimas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(565, 5);
            this.panel4.TabIndex = 49;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 334);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(565, 57);
            this.panel3.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 5);
            this.panel2.TabIndex = 50;
            // 
            // DeletingStorehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.panel1);
            this.Name = "DeletingStorehouse";
            this.Text = "DeletingStorehouse";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDeleteParts;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxStorehouseId;
        private System.Windows.Forms.TextBox textBoxStorehouseName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pradinisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem katalogasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pardavimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pirkimaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paskyraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atsijungtiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}