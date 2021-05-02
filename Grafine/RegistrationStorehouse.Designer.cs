﻿namespace Grafine
{
    partial class RegistrationStorehouse
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
            this.textBoxStockFree = new System.Windows.Forms.TextBox();
            this.labelSingIn = new System.Windows.Forms.Label();
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.textBoxStorehouseId = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxStorehouseName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxStockFree
            // 
            this.textBoxStockFree.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStockFree.Location = new System.Drawing.Point(108, 316);
            this.textBoxStockFree.Multiline = true;
            this.textBoxStockFree.Name = "textBoxStockFree";
            this.textBoxStockFree.Size = new System.Drawing.Size(288, 30);
            this.textBoxStockFree.TabIndex = 36;
            this.textBoxStockFree.Text = "Lasiva vieta";
            // 
            // labelSingIn
            // 
            this.labelSingIn.AutoSize = true;
            this.labelSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSingIn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSingIn.Location = new System.Drawing.Point(192, 464);
            this.labelSingIn.Name = "labelSingIn";
            this.labelSingIn.Size = new System.Drawing.Size(94, 20);
            this.labelSingIn.TabIndex = 35;
            this.labelSingIn.Text = "Prisijungimas";
            this.labelSingIn.Click += new System.EventHandler(this.labelSingIn_Click);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRegistr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonRegistr.Location = new System.Drawing.Point(176, 427);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(136, 34);
            this.buttonRegistr.TabIndex = 34;
            this.buttonRegistr.Text = "Užsiregistruoti";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // textBoxStorehouseId
            // 
            this.textBoxStorehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseId.Location = new System.Drawing.Point(108, 212);
            this.textBoxStorehouseId.Multiline = true;
            this.textBoxStorehouseId.Name = "textBoxStorehouseId";
            this.textBoxStorehouseId.Size = new System.Drawing.Size(288, 33);
            this.textBoxStorehouseId.TabIndex = 33;
            this.textBoxStorehouseId.Text = "sanID";
            // 
            // textBoxStock
            // 
            this.textBoxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStock.Location = new System.Drawing.Point(108, 262);
            this.textBoxStock.Multiline = true;
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(288, 30);
            this.textBoxStock.TabIndex = 32;
            this.textBoxStock.Text = "Užimtumas";
            // 
            // textBoxStorehouseName
            // 
            this.textBoxStorehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseName.Location = new System.Drawing.Point(108, 161);
            this.textBoxStorehouseName.Multiline = true;
            this.textBoxStorehouseName.Name = "textBoxStorehouseName";
            this.textBoxStorehouseName.Size = new System.Drawing.Size(288, 35);
            this.textBoxStorehouseName.TabIndex = 31;
            this.textBoxStorehouseName.Text = "Sandėlio pavadinimas";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sandėlio Registracija";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 145);
            this.panel2.TabIndex = 1;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(469, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.textBoxStockFree);
            this.panel1.Controls.Add(this.labelSingIn);
            this.panel1.Controls.Add(this.buttonRegistr);
            this.panel1.Controls.Add(this.textBoxStorehouseId);
            this.panel1.Controls.Add(this.textBoxStock);
            this.panel1.Controls.Add(this.textBoxStorehouseName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 489);
            this.panel1.TabIndex = 4;
            // 
            // RegistrationStorehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 489);
            this.Controls.Add(this.panel1);
            this.Name = "RegistrationStorehouse";
            this.Text = "RegistrationStorehouse";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxStockFree;
        private System.Windows.Forms.Label labelSingIn;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.TextBox textBoxStorehouseId;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxStorehouseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel1;
    }
}