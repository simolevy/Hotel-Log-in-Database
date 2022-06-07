namespace Project2
{
    partial class Form_main
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
            this.button_logout = new System.Windows.Forms.Button();
            this.guest_id = new System.Windows.Forms.Label();
            this.guest_name = new System.Windows.Forms.Label();
            this.g_pn = new System.Windows.Forms.Label();
            this.textBox_gid = new System.Windows.Forms.TextBox();
            this.textBox_gname = new System.Windows.Forms.TextBox();
            this.textBox_gpn = new System.Windows.Forms.TextBox();
            this.button_show = new System.Windows.Forms.Button();
            this.button_insert = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.dataGridView_records = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button_min = new System.Windows.Forms.Button();
            this.button_max = new System.Windows.Forms.Button();
            this.button_avg = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_records)).BeginInit();
            this.SuspendLayout();
            // 
            // button_logout
            // 
            this.button_logout.Location = new System.Drawing.Point(342, 384);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(75, 23);
            this.button_logout.TabIndex = 0;
            this.button_logout.Text = "Logout";
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // guest_id
            // 
            this.guest_id.AutoSize = true;
            this.guest_id.Location = new System.Drawing.Point(207, 61);
            this.guest_id.Name = "guest_id";
            this.guest_id.Size = new System.Drawing.Size(46, 13);
            this.guest_id.TabIndex = 1;
            this.guest_id.Text = "GuestID";
            // 
            // guest_name
            // 
            this.guest_name.AutoSize = true;
            this.guest_name.Location = new System.Drawing.Point(196, 102);
            this.guest_name.Name = "guest_name";
            this.guest_name.Size = new System.Drawing.Size(66, 13);
            this.guest_name.TabIndex = 2;
            this.guest_name.Text = "Guest Name";
            // 
            // g_pn
            // 
            this.g_pn.AutoSize = true;
            this.g_pn.Location = new System.Drawing.Point(184, 152);
            this.g_pn.Name = "g_pn";
            this.g_pn.Size = new System.Drawing.Size(78, 13);
            this.g_pn.TabIndex = 3;
            this.g_pn.Text = "Phone Number";
            // 
            // textBox_gid
            // 
            this.textBox_gid.Location = new System.Drawing.Point(274, 58);
            this.textBox_gid.Name = "textBox_gid";
            this.textBox_gid.Size = new System.Drawing.Size(100, 20);
            this.textBox_gid.TabIndex = 4;
            // 
            // textBox_gname
            // 
            this.textBox_gname.Location = new System.Drawing.Point(274, 99);
            this.textBox_gname.Name = "textBox_gname";
            this.textBox_gname.Size = new System.Drawing.Size(100, 20);
            this.textBox_gname.TabIndex = 5;
            // 
            // textBox_gpn
            // 
            this.textBox_gpn.Location = new System.Drawing.Point(274, 145);
            this.textBox_gpn.Name = "textBox_gpn";
            this.textBox_gpn.Size = new System.Drawing.Size(100, 20);
            this.textBox_gpn.TabIndex = 6;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(187, 210);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 7;
            this.button_show.Text = "SHOW";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // button_insert
            // 
            this.button_insert.Location = new System.Drawing.Point(284, 209);
            this.button_insert.Name = "button_insert";
            this.button_insert.Size = new System.Drawing.Size(75, 23);
            this.button_insert.TabIndex = 8;
            this.button_insert.Text = "INSERT";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(380, 208);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 9;
            this.button_delete.Text = "DELETE";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(483, 208);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 10;
            this.button_update.Text = "UPDATE";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // dataGridView_records
            // 
            this.dataGridView_records.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_records.Location = new System.Drawing.Point(187, 239);
            this.dataGridView_records.Name = "dataGridView_records";
            this.dataGridView_records.Size = new System.Drawing.Size(371, 139);
            this.dataGridView_records.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(507, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Room Rate";
            // 
            // button_min
            // 
            this.button_min.Location = new System.Drawing.Point(510, 54);
            this.button_min.Name = "button_min";
            this.button_min.Size = new System.Drawing.Size(75, 23);
            this.button_min.TabIndex = 13;
            this.button_min.Text = "Min";
            this.button_min.UseVisualStyleBackColor = true;
            this.button_min.Click += new System.EventHandler(this.button_min_Click);
            // 
            // button_max
            // 
            this.button_max.Location = new System.Drawing.Point(510, 99);
            this.button_max.Name = "button_max";
            this.button_max.Size = new System.Drawing.Size(75, 23);
            this.button_max.TabIndex = 14;
            this.button_max.Text = "Max";
            this.button_max.UseVisualStyleBackColor = true;
            this.button_max.Click += new System.EventHandler(this.button_max_Click);
            // 
            // button_avg
            // 
            this.button_avg.Location = new System.Drawing.Point(510, 142);
            this.button_avg.Name = "button_avg";
            this.button_avg.Size = new System.Drawing.Size(75, 23);
            this.button_avg.TabIndex = 15;
            this.button_avg.Text = "Avg";
            this.button_avg.UseVisualStyleBackColor = true;
            this.button_avg.Click += new System.EventHandler(this.button_avg_Click);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_avg);
            this.Controls.Add(this.button_max);
            this.Controls.Add(this.button_min);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_records);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.textBox_gpn);
            this.Controls.Add(this.textBox_gname);
            this.Controls.Add(this.textBox_gid);
            this.Controls.Add(this.g_pn);
            this.Controls.Add(this.guest_name);
            this.Controls.Add(this.guest_id);
            this.Controls.Add(this.button_logout);
            this.Name = "Form_main";
            this.Text = "Staff_Information";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_records)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Label guest_id;
        private System.Windows.Forms.Label guest_name;
        private System.Windows.Forms.Label g_pn;
        private System.Windows.Forms.TextBox textBox_gid;
        private System.Windows.Forms.TextBox textBox_gname;
        private System.Windows.Forms.TextBox textBox_gpn;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Button button_insert;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.DataGridView dataGridView_records;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_min;
        private System.Windows.Forms.Button button_max;
        private System.Windows.Forms.Button button_avg;
    }
}