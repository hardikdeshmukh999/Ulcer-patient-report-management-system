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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        private long idtxt = Form5.passingtext;
        private int idtxta = Form6.passingtexta;


        public Form4()
        {
            InitializeComponent();


        }
        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
        }




        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 wt = new Form2();
            wt.Show();
            this.Close();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Admin\\source\\repos\\WindowsFormsApp3\\Database1.mdf; Integrated Security = True"))
            {
                connection.Open();
                using (SqlCommand command1 = new SqlCommand("SELECT * FROM patient WHERE phonenumber='" + idtxt + "'", connection))
                {
                    SqlDataReader drc = command1.ExecuteReader();
                    if (drc.Read())
                    {
                        textBox1.Text = drc["fullname"].ToString();
                        textBox2.Text = drc["phonenumber"].ToString();
                        textBox7.Text = drc["patient_id"].ToString();
                        textBox4.Text = drc["insurancetype"].ToString();
                        textBox5.Text = drc["insurancename"].ToString();
                        textBox6.Text = drc["address"].ToString();

                    }
                    drc.Close();
                    using (SqlCommand command2 = new SqlCommand("SELECT * FROM wound WHERE patinet_id='" + textBox7.Text + "'", connection))
                    {
                        SqlDataReader drab = command2.ExecuteReader();

                        if (drab.Read())
                        {

                            textBox3.Text = drab["woundtype"].ToString();
                            textBox9.Text = drab["woundlocation"].ToString();
                            textBox8.Text = drab["woundsize"].ToString();
                            textBox10.Text = drab["woundcomment"].ToString();

                        }


                    }




                }
                connection.Close();

                
            }
            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new FileStream("C:/Windows/Temp/createpdf.pdf", FileMode.Create,FileAccess.ReadWrite));
            doc.Open();
            Paragraph p9 = new Paragraph("Report" );
            doc.Add(p9);
            Paragraph p10 = new Paragraph(" ");
            doc.Add(p10);
            Paragraph p11 = new Paragraph("Personal Details");
            doc.Add(p11);
            Paragraph p12 = new Paragraph(" ");

            doc.Add(p12);
            Paragraph p1 = new Paragraph("Name : " + textBox1.Text);
            doc.Add(p1);
            Paragraph p4 = new Paragraph("Patient ID : " + textBox7.Text);
            doc.Add(p4);
            Paragraph p5 = new Paragraph("Phone No. : " + textBox2.Text);
            doc.Add(p5);
            Paragraph p6 = new Paragraph("Insurance Type : " + textBox4.Text);
            doc.Add(p6);
            Paragraph p7 = new Paragraph("Insurance Name : " + textBox5.Text);
            doc.Add(p7);
            Paragraph p8 = new Paragraph("Address : " + textBox6.Text);
            doc.Add(p8);

            Paragraph p13 = new Paragraph(" ");
            doc.Add(p13);
            Paragraph p14 = new Paragraph("Wound Details");
            doc.Add(p14);
            Paragraph p15 = new Paragraph(" ");
            doc.Add(p15);
            Paragraph p16 = new Paragraph("Wound Type : " + textBox3.Text);
            doc.Add(p16);
            Paragraph p17 = new Paragraph("Wound Location : " + textBox9.Text);
            doc.Add(p17);
            Paragraph p18 = new Paragraph("Wound Size : " + textBox8.Text);
            doc.Add(p18);
            Paragraph p19 = new Paragraph("Wound Comment : " + textBox10.Text);
            doc.Add(p19);
            Paragraph p20 = new Paragraph(" ");
            doc.Add(p20);

            Paragraph p2 = new Paragraph("Remedies : " + textBox11.Text);
            doc.Add(p2);
            Paragraph p21 = new Paragraph(" ");
            doc.Add(p21);
            Paragraph p3 = new Paragraph("Causes : " + textBox12.Text);
            doc.Add(p3);
            doc.Close();
            MessageBox.Show("PDF created");


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string mouth = "Mouth Ulcers";
            string pep = "Peptic Ulcers";
            string art = "Arterial Ulcers";
            string pre = "Pressure Ulcers";

            if (textBox3.Text == mouth)
            {
                textBox11.Text = "1)using a rinse of saltwater and baking soda."+Environment.NewLine+ "2)Placing milk of magnesia on the mouth ulcer." + Environment.NewLine + "3)Covering mouth ulcers with baking soda paste.";

            }
            else
            {
                if (textBox3.Text == pep)
                {
                    textBox11.Text = "1)Consider foods containing probiotics." + Environment.NewLine + "2)Consider eliminating milk." + Environment.NewLine + "3)Limit or avoid alcohol.";

                }
                else
                {
                    if(textBox3.Text==art)
                    {
                        textBox11.Text = "1)Nursing goals include improving circulation, conservatively debriding the wound, and controlling pain." + Environment.NewLine + "2)Use occlusive dressings to protect the ulcer from infection." + Environment.NewLine + "Encourage him to wash daily with mild soap and water and to dry carefully, especially between the toes.";

                    }
                    else
                    {
                        textBox11.Text = "1)Care for the sore as directed by your provider. Keep the wound clean to prevent infection. Clean the sore every time you change a dressing." + Environment.NewLine + "2)Use special pillows, foam cushions, booties, or mattress pads to reduce the pressure. Some pads are water- or air-filled to help support and cushion the area." + Environment.NewLine + "3)Change positions often. If you are in a wheelchair, try to change your position every 15 minutes. If you are in bed, you should be moved about every 2 hours.";


                    }
                }
            }
           
            
               
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string mouth = "Mouth Ulcers";
            string pep = "Peptic Ulcers";
            string art = "Arterial Ulcers";
            string pre = "Pressure Ulcers";
            if (textBox3.Text == mouth)
            {
                textBox12.Text = "1)biting the tongue or inside of the cheek" + Environment.NewLine + "2)braces, poor-fitting dentures, and other apparatus that may rub against the mouth and gums" + Environment.NewLine + "3)medications including beta-blockers and pain killers";

            }
            else
            {
                if (textBox3.Text == pep)
                {
                    textBox12.Text =  "1)Inflammation of the stomach's inner layer, producing an ulcer." + Environment.NewLine + "3)Regular use of certain pain relievers.";
                }
                else
                {
                    if (textBox3.Text == art)
                    {
                        textBox12.Text = "1)Obesity" + Environment.NewLine + "2)Absence of protective sensation due to peripheral neuropathy" + Environment.NewLine + "3)Limited joint mobility";
                    }
                    else
                    {
                        textBox12.Text = "1)Shear occurs when two surfaces move in the opposite direction. For example, when a bed is elevated at the head, you can slide down in bed." + Environment.NewLine + "2)Friction occurs when the skin rubs against clothing or bedding. It can make fragile skin more vulnerable to injury, especially if the skin is also moist." + Environment.NewLine + "3) Constant pressure on any part of your body can lessen the blood flow to tissues. Blood flow is essential to delivering oxygen and other nutrients to tissues.";
                    }
                }
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form1 eh = new Form1();
            eh.Show();
            this.Close();

        }
    }
}


