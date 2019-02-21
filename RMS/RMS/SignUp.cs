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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ME\Downloads\RMS\RMS\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            if(checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Please Select only one box");
            }

            else if ( checkBox1.Checked)
            {
                string query = "Insert into Manager (mgr_name ,mgr_pswd) VALUES ('"+textBox2.Text+"', '"+textBox3.Text+"')";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Welcome Manager");
                
            }

            else if ( checkBox2.Checked)
            {
                string query = "Insert into Receptionist (recep_name ,recep_pswd) VALUES ('" + textBox2.Text + "', '" + textBox3.Text + "')";
                SqlDataAdapter sd = new SqlDataAdapter(query, con);
                sd.SelectCommand.ExecuteNonQuery();
                MessageBox.Show("Welcome Receptionist");
            }
            else if (!checkBox1.Checked || !checkBox2.Checked || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Fill All the boxes");
            }
           
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Login l = new Login();
            //l.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInOrSigUp o = new SignInOrSigUp();
            o.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
