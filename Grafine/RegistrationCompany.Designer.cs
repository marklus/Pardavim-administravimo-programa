namespace Grafine
{
    partial class RegistrationCompany
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
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.textBoxStorehouseId = new System.Windows.Forms.TextBox();
            this.textBoxCompID = new System.Windows.Forms.TextBox();
            this.textBoxCompName = new System.Windows.Forms.TextBox();
            this.labelSingIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRegistr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonRegistr.Location = new System.Drawing.Point(101, 187);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(136, 34);
            this.buttonRegistr.TabIndex = 17;
            this.buttonRegistr.Text = "Užsiregistruoti";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // textBoxStorehouseId
            // 
            this.textBoxStorehouseId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxStorehouseId.Location = new System.Drawing.Point(29, 76);
            this.textBoxStorehouseId.Multiline = true;
            this.textBoxStorehouseId.Name = "textBoxStorehouseId";
            this.textBoxStorehouseId.Size = new System.Drawing.Size(288, 33);
            this.textBoxStorehouseId.TabIndex = 16;
            this.textBoxStorehouseId.Text = "sanID";
            // 
            // textBoxCompID
            // 
            this.textBoxCompID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxCompID.Location = new System.Drawing.Point(29, 126);
            this.textBoxCompID.Multiline = true;
            this.textBoxCompID.Name = "textBoxCompID";
            this.textBoxCompID.Size = new System.Drawing.Size(288, 30);
            this.textBoxCompID.TabIndex = 15;
            this.textBoxCompID.Text = "Įmonės kodas";
            // 
            // textBoxCompName
            // 
            this.textBoxCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxCompName.Location = new System.Drawing.Point(29, 25);
            this.textBoxCompName.Multiline = true;
            this.textBoxCompName.Name = "textBoxCompName";
            this.textBoxCompName.Size = new System.Drawing.Size(288, 35);
            this.textBoxCompName.TabIndex = 14;
            this.textBoxCompName.Text = "Įmonės pavadinimas";
            // 
            // labelSingIn
            // 
            this.labelSingIn.AutoSize = true;
            this.labelSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSingIn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSingIn.Location = new System.Drawing.Point(117, 224);
            this.labelSingIn.Name = "labelSingIn";
            this.labelSingIn.Size = new System.Drawing.Size(94, 20);
            this.labelSingIn.TabIndex = 18;
            this.labelSingIn.Text = "Prisijungimas";
            this.labelSingIn.Click += new System.EventHandler(this.labelSingIn_Click);
            // 
            // RegistrationCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 251);
            this.Controls.Add(this.labelSingIn);
            this.Controls.Add(this.buttonRegistr);
            this.Controls.Add(this.textBoxStorehouseId);
            this.Controls.Add(this.textBoxCompID);
            this.Controls.Add(this.textBoxCompName);
            this.Name = "RegistrationCompany";
            this.Text = "RegistrationCompany";
            this.Load += new System.EventHandler(this.RegistrationCompany_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.TextBox textBoxStorehouseId;
        private System.Windows.Forms.TextBox textBoxCompID;
        private System.Windows.Forms.TextBox textBoxCompName;
        private System.Windows.Forms.Label labelSingIn;
    }
}