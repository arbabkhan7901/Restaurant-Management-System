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

namespace RMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectOne so = new SelectOne();
            so.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ME\Downloads\RMS\RMS\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            if (textBox1.Text == "Manager" || textBox1.Text== "manager" )
            {
                string query = "Select Count(*) From Manager where mgr_pswd ='" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if ( dt.Rows.Count == 1)
                {
                    this.Hide();
                    Manager m = new Manager();
                    m.Show();
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            else if (textBox1.Text == "Receptionist" || textBox1.Text == "receptionist" )
            {
                string query = "Select Count(*) From Receptionist where recep_pswd ='" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    Receptionist r = new Receptionist();
                    r.Show();
                }
                else
                {
                    MessageBox.Show("Try Again");
                }
            }
            else if (textBox1.Text == "Customer" || textBox1.Text == "customer" && textBox2.Text == "123")
            {
                this.Hide();
                Customer cust = new Customer();
                cust.Show();
            }
            else
            {
                MessageBox.Show("Invalid Id or Password");
            }
            con.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
           
    }
}
