﻿
namespace Finalproject.View
{
    partial class frmCreate_User
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
            this.lblid = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtstaff = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btncreatenewuserr = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(92, 92);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(24, 20);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(70, 135);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(70, 173);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(46, 20);
            this.lblemail.TabIndex = 2;
            this.lblemail.Text = "Email";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Location = new System.Drawing.Point(57, 211);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(62, 20);
            this.lbladdress.TabIndex = 3;
            this.lbladdress.Text = "Address";
            // 
            // lbltype
            // 
            this.lbltype.AutoSize = true;
            this.lbltype.Location = new System.Drawing.Point(44, 250);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(75, 20);
            this.lbltype.TabIndex = 4;
            this.lbltype.Text = "Staff Type";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(49, 299);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(70, 20);
            this.lblpassword.TabIndex = 5;
            this.lblpassword.Text = "Password";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(122, 135);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(166, 27);
            this.txtname.TabIndex = 7;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(122, 173);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(166, 27);
            this.txtemail.TabIndex = 8;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(122, 211);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(166, 27);
            this.txtaddress.TabIndex = 9;
            // 
            // txtstaff
            // 
            this.txtstaff.Location = new System.Drawing.Point(122, 250);
            this.txtstaff.Name = "txtstaff";
            this.txtstaff.Size = new System.Drawing.Size(166, 27);
            this.txtstaff.TabIndex = 10;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(122, 292);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(166, 27);
            this.txtpassword.TabIndex = 11;
            // 
            // btncreatenewuserr
            // 
            this.btncreatenewuserr.Location = new System.Drawing.Point(150, 346);
            this.btncreatenewuserr.Name = "btncreatenewuserr";
            this.btncreatenewuserr.Size = new System.Drawing.Size(94, 29);
            this.btncreatenewuserr.TabIndex = 12;
            this.btncreatenewuserr.Text = "Create";
            this.btncreatenewuserr.UseVisualStyleBackColor = true;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(119, 92);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(169, 27);
            this.txtid.TabIndex = 13;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // frmCreate_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 436);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btncreatenewuserr);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtstaff);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbltype);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCreate_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lbltype;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtstaff;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btncreatenewuserr;
        private System.Windows.Forms.TextBox txtid;
    }
}