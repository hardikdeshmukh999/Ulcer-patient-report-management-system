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
    public partial class Form5 : Form
    {
       internal static long passingtext;
       
        public Form5()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\WindowsFormsApp3\Database1.mdf;Integrated Security=True");


        private void Button2_Click(object sender, EventArgs e)
        {


            passingtext = long.Parse(textBox3.Text);
                con.Open();
                string query = "INSERT INTO patient (fullname,phonenumber,address,insurancetype,insurancename) VALUES('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, con);
                SDA.SelectCommand.ExecuteNonQuery();
                con.Close();

                Form6 wt = new Form6();
                wt.Show();
                this.Close();


            
            
        }

        private void name(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }
    }
}
