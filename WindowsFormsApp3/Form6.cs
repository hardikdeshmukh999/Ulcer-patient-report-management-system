using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        internal static int passingtexta;
        private long idtxt = (Form5.passingtext);
        public Form6()
        {
            InitializeComponent();
           
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\source\repos\WindowsFormsApp3\Database1.mdf;Integrated Security=True");

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO wound (woundlocation,woundtype,woundcomment,woundsize) VALUES('" + textBoxb.Text + "','" + textBoxc.Text + "','" + textBoxd.Text + "','" + textBoxe.Text + "')",con);
            
           
            cmd.ExecuteNonQuery();
            con.Close();

            Form4 wt = new Form4();
            wt.Show();
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
    }
}
