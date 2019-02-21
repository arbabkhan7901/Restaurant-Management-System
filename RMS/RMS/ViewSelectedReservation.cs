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
    public partial class ViewSelectedReservation : Form
    {
        public ViewSelectedReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ME\Downloads\RMS\RMS\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            DateTime dateTime;
            if (string.IsNullOrEmpty(dateTimePicker1.Text) || (string.IsNullOrEmpty(dateTimePicker2.Text)))
            {
                MessageBox.Show("Fill all boxes First");
            }

            else if (DateTime.TryParse(dateTimePicker2.Text, out dateTime) == false || DateTime.TryParse(dateTimePicker1.Text, out dateTime) == false)
            {
                MessageBox.Show("invalid Dates");
            }
            else if (DateTime.Parse(dateTimePicker1.Text) > DateTime.Parse(dateTimePicker2.Text))
            {
                MessageBox.Show("Invalid Dates");
            }
            else
            {
                string sql2 = "select tableno, res_date as Date from reservation where res_date between'" + DateTime.Parse(dateTimePicker1.Text) + "' and '" + DateTime.Parse(dateTimePicker2.Text) + "' order by res_date";
                SqlDataAdapter adap = new SqlDataAdapter(sql2, con);

                DataTable dt = new DataTable();
                adap.Fill(dt);
                if (dt.Rows.Count == 0)
                {
                    dataGridView1.DataSource = null;
                    label4.Show();
                }
                else
                {
                    label4.Hide();
                    dataGridView1.DataSource = dt;
                }

            }

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewReservationToRecep v = new ViewReservationToRecep();
            v.Show();
        }

        private void ViewSelectedReservation_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;

            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Value = DateTime.Today;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ME\Downloads\RMS\RMS\Database1.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
            MessageBox.Show("Resevation cancel");
            //string q = "DELETE FROM Reservation WHERE tableNo=" + dataGridView1.SelectedRows[rowIndex].Cells[0].Value + "";
            //SqlDataAdapter sda = new SqlDataAdapter(q, con);
            //sda.SelectCommand.ExecuteNonQuery();
            con.Close();
         
        }
    }
}
