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


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        

        

        public Form1()
        {
            InitializeComponent();
            txtout2.PasswordChar = '*'; 
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        string doctor = "kavita";

        private void Button1_Click(object sender, EventArgs e)
        {
            

            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Admin\\source\\repos\\WindowsFormsApp3\\Database1.mdf; Integrated Security = True");
            
            SqlCommand cmd = new SqlCommand("select * from account where username=@username and password=@password ", con);
            cmd.Parameters.AddWithValue("@username", txtout1.Text);
            cmd.Parameters.AddWithValue("@password", txtout2.Text);
            con.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            if(count==1)
            {
                MessageBox.Show("Login Successfull");
                if (txtout1.Text == doctor)
                {
                    Form3 eh = new Form3();
                    eh.Show();
                    this.Hide();


                }
                else
                {
                    Form2 at = new Form2();
                    at.Show();
                    this.Hide();

                }
               

               


            }
            else
            {
                
                MessageBox.Show("Login Unsuccessfull");
            }

           

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Txtout2_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
