using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project2
{
    public partial class Form_main : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Guests.mdf;Integrated Security=True");
        SqlCommand cmd;

        public Form_main()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            // confirm before logout
            var result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //if yes, hide this form
                this.Hide();
                Form1 fl = new Form1();
                // show login window
                fl.Show();
            }
        }

        private void show_data()
        {
            con.Open();
            //search the student based on the student name
            SqlCommand cmd = new SqlCommand("SELECT guests_login.g_id as ID, guests_login.phone_num AS phone, guests_login.g_name AS name,  guests_login.booking_id AS BID FROM guests_login", con);
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView_records.DataSource = dt;
            con.Close();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            show_data();
        }

        private void ClearData()
        {
            textBox_gid.Text = "";
            textBox_gname.Text = "";
            textBox_gpn.Text = "";
        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            if (textBox_gid.Text == "" || textBox_gname.Text == "" || textBox_gpn.Text == "")
            {
                //throw out a message if they are empty
                MessageBox.Show("Please provide all guest information!");
                return;
            }
            // try: catch the error in your code
            try
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO guests_login(guests_login.g_id, guests_login.g_name, guests_login.phone_num) VALUES (@g_id,@g_name,@phone_num)", con);

                cmd.Parameters.AddWithValue("@g_id", textBox_gid.Text);
                cmd.Parameters.AddWithValue("@g_name", textBox_gname.Text);
                cmd.Parameters.AddWithValue("@phone_num", textBox_gpn.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Insert Successful!");
                ClearData();
                show_data();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
                ClearData();
            }


        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(textBox_gid.Text != null)
            {
                cmd = new SqlCommand("DELETE FROM guests_login WHERE guests_login.g_id = @g_id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@g_id", textBox_gid.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Guest is deleted!");
                show_data();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please input the guest ID you want to delete.");
            }
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Guests.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE guests_login SET guests_login.g_id = @g_id, guests_login.g_name = @g_name, guests_login.phone_num = @phone_num WHERE guests_login.g_id = @g_id", con);
            cmd.Parameters.AddWithValue("@g_id", textBox_gid.Text);
            cmd.Parameters.AddWithValue("@g_name", textBox_gname.Text);
            cmd.Parameters.AddWithValue("@phone_num", textBox_gpn.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information has been successfully updated!");
            show_data();
            ClearData();
        }

        private void button_max_Click(object sender, EventArgs e)
        {
            con.Open();
            int[] arr = { 100, 200, 300, 400 };
            int i, max, n;
            n = 4;
            max = arr[0];
            for(i = 1; i<n; i++)
            {
                if(arr[i]> max)
                    max = arr[i];
            }
            con.Close();
            MessageBox.Show("Max Room Rate: " + max);
           
        }

        private void button_min_Click(object sender, EventArgs e)
        {
            con.Open();
            int[] arr = { 100, 200, 300, 400 };
            int i, min, n;
            n = 4;
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] < min)
                    min = arr[i];
            }
            con.Close();
            MessageBox.Show("Min Room Rate: " + min);
        }

        private void button_avg_Click(object sender, EventArgs e)
        {
            con.Open();
            int[] arr = { 100, 200, 300, 400 };

            int sum = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                sum += arr[i];
            }

            int avg = sum / arr.Length;
            con.Close();
            MessageBox.Show("Avg Room Rate: " + avg);
        }
    }
}
    
