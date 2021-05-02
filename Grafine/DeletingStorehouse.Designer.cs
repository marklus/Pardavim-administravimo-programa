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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxDeleteParts
            // 
            this.checkBoxDeleteParts.AutoSize = true;
            this.checkBoxDeleteParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxDeleteParts.Location = new System.Drawing.Point(115, 265);
            this.checkBoxDeleteParts.Name = "checkBoxDeleteParts";
            this.checkBoxDeleteParts.Size = new System.Drawing.Size(268, 21);
            this.checkBoxDeleteParts.TabIndex = 36;
            this.checkBoxDeleteParts.Text = "Ištrinti ir sandėlyje laikomas dalis";
            this.checkBoxDeleteParts.UseVisualStyleBackColor = true;
            this.checkBoxDeleteParts.CheckedChanged += new System.EventHandler(this.checkBoxDeleteParts_CheckedChanged);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBack.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelBack.Location = new System.Drawing.Point(209, 338);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(41, 20);
            this.labelBack.TabIndex = 35;
            this.labelBack.Text = "Atgal";
            this.labelBack.Click += new System.EventHandler(this.labelBack_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonDelete.Location = new System.Drawing.Point(162, 301);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(136, 34);
            this.buttonDelete.TabIndex = 34;
            this.buttonDelete.Text = "Ištrinti";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxStorehouseId
            // 
            this.textBoxStorehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseId.Location = new System.Drawing.Point(88, 210);
            this.textBoxStorehouseId.Multiline = true;
            this.textBoxStorehouseId.Name = "textBoxStorehouseId";
            this.textBoxStorehouseId.Size = new System.Drawing.Size(288, 33);
            this.textBoxStorehouseId.TabIndex = 33;
            this.textBoxStorehouseId.Text = "sanID";
            // 
            // textBoxStorehouseName
            // 
            this.textBoxStorehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseName.Location = new System.Drawing.Point(88, 169);
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
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 121);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sandėlio Trinimas";
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
            this.labelClose.Location = new System.Drawing.Point(438, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.checkBoxDeleteParts);
            this.panel1.Controls.Add(this.labelBack);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.textBoxStorehouseId);
            this.panel1.Controls.Add(this.textBoxStorehouseName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 374);
            this.panel1.TabIndex = 5;
            // 
            // DeletingStorehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 374);
            this.Controls.Add(this.panel1);
            this.Name = "DeletingStorehouse";
            this.Text = "DeletingStorehouse";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDeleteParts;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxStorehouseId;
        private System.Windows.Forms.TextBox textBoxStorehouseName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Panel panel1;
    }
}