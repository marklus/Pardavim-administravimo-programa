namespace Grafine
{
    partial class DaliesSalinimas
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pradinisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.katalogasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pardavimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pirkimaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paskyraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atsijungtiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 59);
            this.label1.TabIndex = 39;
            this.label1.Text = "Mašinų dalies šalinimas";
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
            this.menuStrip1.Size = new System.Drawing.Size(681, 76);
            this.menuStrip1.TabIndex = 40;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(0, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(681, 5);
            this.panel4.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(0, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(681, 57);
            this.panel3.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 24);
            this.label7.TabIndex = 45;
            this.label7.Text = "Įveskite vidinį kodą";
            // 
            // textBoxCode
            // 
            this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxCode.Location = new System.Drawing.Point(259, 104);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.ReadOnly = true;
            this.textBoxCode.Size = new System.Drawing.Size(410, 40);
            this.textBoxCode.TabIndex = 44;
            // 
            // Delete_Button
            // 
            this.Delete_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Delete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Delete_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Delete_Button.Location = new System.Drawing.Point(536, 178);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(133, 52);
            this.Delete_Button.TabIndex = 46;
            this.Delete_Button.Text = "Šalinti";
            this.Delete_Button.UseVisualStyleBackColor = false;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // DaliesSalinimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(681, 358);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "DaliesSalinimas";
            this.Text = "DaliesSalinimas";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button Delete_Button;
    }
}