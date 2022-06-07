using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void staff_login_Click(object sender, EventArgs e)
        {
            if (textBox_sid.Text == "" || textBox_sname.Text == "")
            {
                //throw out a message if they are empty
                MessageBox.Show("Please provide Name and ID!");
                return;
            }
            // try: catch the error in your code
            try
            {

                // connection string, it is the path/value used to find the database. It can be found in database properties.
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename=|DataDirectory|\Guests.mdf;Integrated Security=True";

                //create sql connection called "con", used to connect to Students database
                SqlConnection con = new SqlConnection(connectionString);
                // the sql command you want to execute in DBMS
                SqlCommand cmd = new SqlCommand("Select * from Staff where staff_name = @staff_name and staff_id = @staff_id", con);

                //Assign values to variables. Give TextBox: username -> @username; TextBox: password-> @password
                cmd.Parameters.AddWithValue("@staff_id", textBox_sid.Text);
                cmd.Parameters.AddWithValue("@staff_name", textBox_sname.Text);

                //open the connection to DB
                con.Open();

                //select records from a database and populate a DataSet with the selected rows.
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                //add rows in data adapter
                adapt.Fill(ds);

                // close the connection after query
                con.Close();

                //get the collection of tables in the DataSet.
                int count = ds.Tables[0].Rows.Count;

                //if count is equal to 1, that means the SQL query get the record., then show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    Form_main fm = new Form_main();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed: Could Not Find Your Account!");
                }
            }
            // catch trow out error message if there is an error
            catch (Exception ex)
            {
                //show the error message
                MessageBox.Show(ex.Message);
            }
        }
    }
}
