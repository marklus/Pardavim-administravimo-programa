namespace Grafine
{
    partial class Registration
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
            this.labelSingIn = new System.Windows.Forms.Label();
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.textBoxCnfPsw = new System.Windows.Forms.TextBox();
            this.textBoxPsw = new System.Windows.Forms.TextBox();
            this.textBoxUsrName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCompID = new System.Windows.Forms.TextBox();
            this.textBoxCompName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.labelSingIn);
            this.panel1.Controls.Add(this.buttonRegistr);
            this.panel1.Controls.Add(this.textBoxTel);
            this.panel1.Controls.Add(this.textBoxCnfPsw);
            this.panel1.Controls.Add(this.textBoxPsw);
            this.panel1.Controls.Add(this.textBoxUsrName);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxCompID);
            this.panel1.Controls.Add(this.textBoxCompName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 487);
            this.panel1.TabIndex = 1;
            // 
            // labelSingIn
            // 
            this.labelSingIn.AutoSize = true;
            this.labelSingIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSingIn.Font = new System.Drawing.Font("Arial Narrow", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSingIn.Location = new System.Drawing.Point(177, 458);
            this.labelSingIn.Name = "labelSingIn";
            this.labelSingIn.Size = new System.Drawing.Size(94, 20);
            this.labelSingIn.TabIndex = 13;
            this.labelSingIn.Text = "Prisijungimas";
            this.labelSingIn.Click += new System.EventHandler(this.labelSingIn_Click);
            this.labelSingIn.MouseEnter += new System.EventHandler(this.labelSingIn_MouseEnter);
            this.labelSingIn.MouseLeave += new System.EventHandler(this.labelSingIn_MouseLeave);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRegistr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonRegistr.Location = new System.Drawing.Point(154, 408);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(136, 34);
            this.buttonRegistr.TabIndex = 12;
            this.buttonRegistr.Text = "Užsiregistruoti";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.buttonRegistr_Click);
            // 
            // textBoxTel
            // 
            this.textBoxTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxTel.Location = new System.Drawing.Point(12, 372);
            this.textBoxTel.Multiline = true;
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(410, 30);
            this.textBoxTel.TabIndex = 10;
            this.textBoxTel.Text = "Telefono numeris";
            // 
            // textBoxCnfPsw
            // 
            this.textBoxCnfPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxCnfPsw.Location = new System.Drawing.Point(12, 326);
            this.textBoxCnfPsw.Multiline = true;
            this.textBoxCnfPsw.Name = "textBoxCnfPsw";
            this.textBoxCnfPsw.Size = new System.Drawing.Size(410, 30);
            this.textBoxCnfPsw.TabIndex = 9;
            this.textBoxCnfPsw.Text = "Patvirtinti slaptažodį";
            // 
            // textBoxPsw
            // 
            this.textBoxPsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxPsw.Location = new System.Drawing.Point(12, 279);
            this.textBoxPsw.Multiline = true;
            this.textBoxPsw.Name = "textBoxPsw";
            this.textBoxPsw.Size = new System.Drawing.Size(410, 30);
            this.textBoxPsw.TabIndex = 8;
            this.textBoxPsw.Text = "Slaptažodis";
            // 
            // textBoxUsrName
            // 
            this.textBoxUsrName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxUsrName.Location = new System.Drawing.Point(12, 231);
            this.textBoxUsrName.Multiline = true;
            this.textBoxUsrName.Name = "textBoxUsrName";
            this.textBoxUsrName.Size = new System.Drawing.Size(410, 30);
            this.textBoxUsrName.TabIndex = 7;
            this.textBoxUsrName.Text = "Prisijungimo vardas";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxEmail.Location = new System.Drawing.Point(12, 186);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(410, 30);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.Text = "Elektroninio pašto adresas";
            // 
            // textBoxCompID
            // 
            this.textBoxCompID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxCompID.Location = new System.Drawing.Point(12, 141);
            this.textBoxCompID.Multiline = true;
            this.textBoxCompID.Name = "textBoxCompID";
            this.textBoxCompID.Size = new System.Drawing.Size(410, 30);
            this.textBoxCompID.TabIndex = 5;
            this.textBoxCompID.Text = "Įmonės kodas";
            // 
            // textBoxCompName
            // 
            this.textBoxCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.textBoxCompName.Location = new System.Drawing.Point(12, 96);
            this.textBoxCompName.Multiline = true;
            this.textBoxCompName.Name = "textBoxCompName";
            this.textBoxCompName.Size = new System.Drawing.Size(410, 30);
            this.textBoxCompName.TabIndex = 4;
            this.textBoxCompName.Text = "Įmonės pavadinimas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.labelClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(507, 80);
            this.panel2.TabIndex = 1;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelClose.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.Location = new System.Drawing.Point(438, 3);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(23, 22);
            this.labelClose.TabIndex = 1;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            this.labelClose.MouseEnter += new System.EventHandler(this.labelClose_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(60, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registracija";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 487);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxCompName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCompID;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsrName;
        private System.Windows.Forms.TextBox textBoxCnfPsw;
        private System.Windows.Forms.TextBox textBoxPsw;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.Label labelSingIn;
    }
}