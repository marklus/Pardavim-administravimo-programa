
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "Pasirinkite sandelį";
            // 
            // Add_Button
            // 
            this.Add_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Add_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Add_Button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Add_Button.Location = new System.Drawing.Point(13, 118);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(133, 52);
            this.Add_Button.TabIndex = 17;
            this.Add_Button.Text = "Pridėti naują";
            this.Add_Button.UseVisualStyleBackColor = false;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // comboBoxWarehouse
            // 
            this.comboBoxWarehouse.FormattingEnabled = true;
            this.comboBoxWarehouse.Location = new System.Drawing.Point(193, 12);
            this.comboBoxWarehouse.Name = "comboBoxWarehouse";
            this.comboBoxWarehouse.Size = new System.Drawing.Size(362, 21);
            this.comboBoxWarehouse.TabIndex = 18;
            this.comboBoxWarehouse.SelectedIndexChanged += new System.EventHandler(this.comboBoxWarehouse_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kiekis";
            // 
            // numericUpDownAmount
            // 
            this.numericUpDownAmount.Location = new System.Drawing.Point(80, 61);
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
            this.numericUpDownAmount.Size = new System.Drawing.Size(66, 20);
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
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "Laisvas Plotas";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxFree
            // 
            this.textBoxFree.Location = new System.Drawing.Point(317, 57);
            this.textBoxFree.Name = "textBoxFree";
            this.textBoxFree.ReadOnly = true;
            this.textBoxFree.Size = new System.Drawing.Size(100, 20);
            this.textBoxFree.TabIndex = 22;
            // 
            // textBoxTaken
            // 
            this.textBoxTaken.Location = new System.Drawing.Point(317, 83);
            this.textBoxTaken.Name = "textBoxTaken";
            this.textBoxTaken.ReadOnly = true;
            this.textBoxTaken.Size = new System.Drawing.Size(100, 20);
            this.textBoxTaken.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Užimtas Plotas";
            // 
            // PrekiuPirkimas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(565, 182);
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
    }
}