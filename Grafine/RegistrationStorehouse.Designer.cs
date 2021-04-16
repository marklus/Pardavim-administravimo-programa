namespace Grafine
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
            this.labelSingIn = new System.Windows.Forms.Label();
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxStorehouseName = new System.Windows.Forms.TextBox();
            this.textBoxStorehouseId = new System.Windows.Forms.TextBox();
            this.textBoxĮmonė = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelSingIn
            // 
            this.labelSingIn.AutoSize = true;
            this.labelSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSingIn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSingIn.Location = new System.Drawing.Point(115, 305);
            this.labelSingIn.Name = "labelSingIn";
            this.labelSingIn.Size = new System.Drawing.Size(94, 20);
            this.labelSingIn.TabIndex = 23;
            this.labelSingIn.Text = "Prisijungimas";
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRegistr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonRegistr.Location = new System.Drawing.Point(99, 268);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(136, 34);
            this.buttonRegistr.TabIndex = 22;
            this.buttonRegistr.Text = "Užsiregistruoti";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxType.Location = new System.Drawing.Point(24, 131);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(288, 30);
            this.textBoxType.TabIndex = 20;
            this.textBoxType.Text = "Sandėlio tipas";
            // 
            // textBoxStorehouseName
            // 
            this.textBoxStorehouseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseName.Location = new System.Drawing.Point(24, 30);
            this.textBoxStorehouseName.Multiline = true;
            this.textBoxStorehouseName.Name = "textBoxStorehouseName";
            this.textBoxStorehouseName.Size = new System.Drawing.Size(288, 35);
            this.textBoxStorehouseName.TabIndex = 19;
            this.textBoxStorehouseName.Text = "Sandėlio pavadinimas";
            // 
            // textBoxStorehouseId
            // 
            this.textBoxStorehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseId.Location = new System.Drawing.Point(24, 81);
            this.textBoxStorehouseId.Multiline = true;
            this.textBoxStorehouseId.Name = "textBoxStorehouseId";
            this.textBoxStorehouseId.Size = new System.Drawing.Size(288, 33);
            this.textBoxStorehouseId.TabIndex = 21;
            this.textBoxStorehouseId.Text = "sanID";
            // 
            // textBoxĮmonė
            // 
            this.textBoxĮmonė.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxĮmonė.Location = new System.Drawing.Point(24, 185);
            this.textBoxĮmonė.Multiline = true;
            this.textBoxĮmonė.Name = "textBoxĮmonė";
            this.textBoxĮmonė.Size = new System.Drawing.Size(288, 30);
            this.textBoxĮmonė.TabIndex = 24;
            this.textBoxĮmonė.Text = "Įmonė kuriai Priklauso";
            // 
            // RegistrationStorehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 348);
            this.Controls.Add(this.textBoxĮmonė);
            this.Controls.Add(this.labelSingIn);
            this.Controls.Add(this.buttonRegistr);
            this.Controls.Add(this.textBoxStorehouseId);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.textBoxStorehouseName);
            this.Name = "RegistrationStorehouse";
            this.Text = "RegistrationStorehouse";
            this.Load += new System.EventHandler(this.RegistrationStorehouse_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSingIn;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.TextBox textBoxStorehouseName;
        private System.Windows.Forms.TextBox textBoxStorehouseId;
        private System.Windows.Forms.TextBox textBoxĮmonė;
    }
}