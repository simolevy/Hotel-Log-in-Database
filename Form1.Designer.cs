namespace Project2
{
    partial class Form1
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
            this.staff_login = new System.Windows.Forms.Button();
            this.staff_name = new System.Windows.Forms.Label();
            this.staff_id = new System.Windows.Forms.Label();
            this.textBox_sname = new System.Windows.Forms.TextBox();
            this.textBox_sid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // staff_login
            // 
            this.staff_login.Location = new System.Drawing.Point(336, 259);
            this.staff_login.Name = "staff_login";
            this.staff_login.Size = new System.Drawing.Size(75, 23);
            this.staff_login.TabIndex = 0;
            this.staff_login.Text = "Login";
            this.staff_login.UseVisualStyleBackColor = true;
            this.staff_login.Click += new System.EventHandler(this.staff_login_Click);
            // 
            // staff_name
            // 
            this.staff_name.AutoSize = true;
            this.staff_name.Location = new System.Drawing.Point(268, 138);
            this.staff_name.Name = "staff_name";
            this.staff_name.Size = new System.Drawing.Size(60, 13);
            this.staff_name.TabIndex = 1;
            this.staff_name.Text = "Staff Name";
            // 
            // staff_id
            // 
            this.staff_id.AutoSize = true;
            this.staff_id.Location = new System.Drawing.Point(268, 196);
            this.staff_id.Name = "staff_id";
            this.staff_id.Size = new System.Drawing.Size(43, 13);
            this.staff_id.TabIndex = 2;
            this.staff_id.Text = "Staff ID";
            // 
            // textBox_sname
            // 
            this.textBox_sname.Location = new System.Drawing.Point(381, 138);
            this.textBox_sname.Name = "textBox_sname";
            this.textBox_sname.Size = new System.Drawing.Size(100, 20);
            this.textBox_sname.TabIndex = 3;
            // 
            // textBox_sid
            // 
            this.textBox_sid.Location = new System.Drawing.Point(381, 189);
            this.textBox_sid.Name = "textBox_sid";
            this.textBox_sid.Size = new System.Drawing.Size(100, 20);
            this.textBox_sid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_sid);
            this.Controls.Add(this.textBox_sname);
            this.Controls.Add(this.staff_id);
            this.Controls.Add(this.staff_name);
            this.Controls.Add(this.staff_login);
            this.Name = "Form1";
            this.Text = "Staff_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button staff_login;
        private System.Windows.Forms.Label staff_name;
        private System.Windows.Forms.Label staff_id;
        private System.Windows.Forms.TextBox textBox_sname;
        private System.Windows.Forms.TextBox textBox_sid;
        private System.Windows.Forms.Label label1;
    }
}

