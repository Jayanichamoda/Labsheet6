namespace EmployeeManagement
{
    partial class Employee
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
            this.Namelbl = new System.Windows.Forms.Label();
            this.doblbl = new System.Windows.Forms.Label();
            this.usernamelbl = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.dobtxt = new System.Windows.Forms.TextBox();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.submitbtn = new System.Windows.Forms.Button();
            this.resetbtn = new System.Windows.Forms.Button();
            this.emaillbl = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.contactlbl = new System.Windows.Forms.Label();
            this.addresslbl = new System.Windows.Forms.Label();
            this.contacttxt = new System.Windows.Forms.TextBox();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(73, 49);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(64, 25);
            this.Namelbl.TabIndex = 0;
            this.Namelbl.Text = "Name";
            // 
            // doblbl
            // 
            this.doblbl.AutoSize = true;
            this.doblbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doblbl.Location = new System.Drawing.Point(73, 100);
            this.doblbl.Name = "doblbl";
            this.doblbl.Size = new System.Drawing.Size(118, 25);
            this.doblbl.TabIndex = 1;
            this.doblbl.Text = "Date of Birth";
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(73, 284);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(102, 25);
            this.usernamelbl.TabIndex = 2;
            this.usernamelbl.Text = "Username";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(73, 335);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(98, 25);
            this.passwordlbl.TabIndex = 3;
            this.passwordlbl.Text = "Password";
            // 
            // nametxt
            // 
            this.nametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nametxt.Location = new System.Drawing.Point(258, 46);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(251, 30);
            this.nametxt.TabIndex = 4;
            // 
            // dobtxt
            // 
            this.dobtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobtxt.Location = new System.Drawing.Point(258, 100);
            this.dobtxt.Name = "dobtxt";
            this.dobtxt.Size = new System.Drawing.Size(251, 30);
            this.dobtxt.TabIndex = 5;
            // 
            // usernametxt
            // 
            this.usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametxt.Location = new System.Drawing.Point(258, 279);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(251, 30);
            this.usernametxt.TabIndex = 6;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtxt.Location = new System.Drawing.Point(258, 330);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(251, 30);
            this.passwordtxt.TabIndex = 7;
            // 
            // submitbtn
            // 
            this.submitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitbtn.Location = new System.Drawing.Point(120, 399);
            this.submitbtn.Name = "submitbtn";
            this.submitbtn.Size = new System.Drawing.Size(104, 39);
            this.submitbtn.TabIndex = 8;
            this.submitbtn.Text = "Submit";
            this.submitbtn.UseVisualStyleBackColor = true;
            this.submitbtn.Click += new System.EventHandler(this.submitbtn_Click);
            // 
            // resetbtn
            // 
            this.resetbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbtn.Location = new System.Drawing.Point(303, 399);
            this.resetbtn.Name = "resetbtn";
            this.resetbtn.Size = new System.Drawing.Size(104, 39);
            this.resetbtn.TabIndex = 9;
            this.resetbtn.Text = "Reset";
            this.resetbtn.UseVisualStyleBackColor = true;
            this.resetbtn.Click += new System.EventHandler(this.resetbtn_Click);
            // 
            // emaillbl
            // 
            this.emaillbl.AutoSize = true;
            this.emaillbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillbl.Location = new System.Drawing.Point(73, 147);
            this.emaillbl.Name = "emaillbl";
            this.emaillbl.Size = new System.Drawing.Size(60, 25);
            this.emaillbl.TabIndex = 10;
            this.emaillbl.Text = "Email";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(258, 147);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(251, 30);
            this.emailtxt.TabIndex = 11;
            // 
            // contactlbl
            // 
            this.contactlbl.AutoSize = true;
            this.contactlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlbl.Location = new System.Drawing.Point(73, 197);
            this.contactlbl.Name = "contactlbl";
            this.contactlbl.Size = new System.Drawing.Size(151, 25);
            this.contactlbl.TabIndex = 12;
            this.contactlbl.Text = "Contact number";
            // 
            // addresslbl
            // 
            this.addresslbl.AutoSize = true;
            this.addresslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslbl.Location = new System.Drawing.Point(73, 241);
            this.addresslbl.Name = "addresslbl";
            this.addresslbl.Size = new System.Drawing.Size(85, 25);
            this.addresslbl.TabIndex = 13;
            this.addresslbl.Text = "Address";
            // 
            // contacttxt
            // 
            this.contacttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contacttxt.Location = new System.Drawing.Point(258, 194);
            this.contacttxt.Name = "contacttxt";
            this.contacttxt.Size = new System.Drawing.Size(251, 30);
            this.contacttxt.TabIndex = 14;
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(258, 236);
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(251, 30);
            this.addresstxt.TabIndex = 15;
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.addresstxt);
            this.Controls.Add(this.contacttxt);
            this.Controls.Add(this.addresslbl);
            this.Controls.Add(this.contactlbl);
            this.Controls.Add(this.emailtxt);
            this.Controls.Add(this.emaillbl);
            this.Controls.Add(this.resetbtn);
            this.Controls.Add(this.submitbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.dobtxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.doblbl);
            this.Controls.Add(this.Namelbl);
            this.Name = "Employee";
            this.Text = "CreateEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Namelbl;
        private System.Windows.Forms.Label doblbl;
        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox dobtxt;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Button submitbtn;
        private System.Windows.Forms.Button resetbtn;
        private System.Windows.Forms.Label emaillbl;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label contactlbl;
        private System.Windows.Forms.Label addresslbl;
        private System.Windows.Forms.TextBox contacttxt;
        private System.Windows.Forms.TextBox addresstxt;
    }
}