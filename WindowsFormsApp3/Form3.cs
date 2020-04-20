using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form1 eh = new Form1();
            eh.Show();
            this.Close();




        }


        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
            try
            {
                con.Open();
                string query = "select * from patient inner join wound on patient.patient_id=wound.patinet_id where patient_id='" + textBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Patient ID : " + textBox1.Text + " Not available");
            }
            


        }

        private void Button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Admin\\source\\repos\\WindowsFormsApp3\\Database1.mdf; Integrated Security = True"))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from patient,wound where patient_id=patinet_id", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();

            }
          

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
            try
            {
                con.Open();
                string query = "select * from patient inner join wound on patient.patient_id=wound.patinet_id where woundtype='" + textBoxc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Patients Not available");
            }

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\WindowsFormsApp3\Database1.mdf;Integrated Security=True");
            
            
                con.Open();
                string query =" Delete from patient where patient_id = '"+ textBox2.Text+ "'";
            
            SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            con.Open();
            string query2 = " Delete from wound where patinet_id = '" + textBox2.Text + "'";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.ExecuteNonQuery();
            DataTable de = new DataTable();
            SqlDataAdapter db = new SqlDataAdapter(cmd2);
            db.Fill(de);
            dataGridView1.DataSource = de;
            con.Close();




        }
    }
}