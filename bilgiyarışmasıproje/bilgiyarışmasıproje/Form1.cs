using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilgiyarışmasıproje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int dogru, yanlis = 0;
        int soruno = 0;
        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;

            btnB.Enabled = false;

            btnC.Enabled = false;

            btnD.Enabled = false;

            btnsonraki.Enabled = true;



            label5.Text = btnA.Text;

            if (label4.Text == label5.Text)
            {

                dogru++;

                lbldogru.Text = dogru.ToString();

                pictureBox1.Visible = true;
            }

            else
            {

                yanlis++;

                lblyanlıs.Text = yanlis.ToString();

                pictureBox2.Visible = true;



            }













        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;

            btnB.Enabled = false;

            btnC.Enabled = false;

            btnD.Enabled = false;

            btnsonraki.Enabled = true;



            label5.Text = btnC.Text;

            if (label4.Text == label5.Text)
            {

                dogru++;

                lbldogru.Text = dogru.ToString();

                pictureBox1.Visible = true;
            }

            else
            {

                yanlis++;

                lblyanlıs.Text = yanlis.ToString();

                pictureBox2.Visible = true;



            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;

            btnB.Enabled = false;

            btnC.Enabled = false;

            btnD.Enabled = false;

            btnsonraki.Enabled = true;


            label5.Text = btnD.Text;

            if (label4.Text == label5.Text)
            {

                dogru++;

                lbldogru.Text = dogru.ToString();

                pictureBox1.Visible = true;
            }

            else
            {

                yanlis++;

                lblyanlıs.Text = yanlis.ToString();

                pictureBox2.Visible = true;



            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnB_Click(object sender, EventArgs e)
        {


            btnA.Enabled = false;

            btnB.Enabled = false;

            btnC.Enabled = false;

            btnD.Enabled = false;

            btnsonraki.Enabled = true;

            label5.Text = btnB.Text;





            if (label4.Text == label5.Text)
            {

                dogru++;

                lbldogru.Text = dogru.ToString();

                pictureBox1.Visible = true;
            }

            else
            {

                yanlis++;

                lblyanlıs.Text = yanlis.ToString();

                pictureBox2.Visible = true;



            }



        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;

            btnB.Enabled = true;

            btnC.Enabled = true;

            btnD.Enabled = true;

            btnsonraki.Enabled = false;

            pictureBox2.Visible = false;

            pictureBox1.Visible = false;

            soruno = soruno + 1;
            lblsoruno.Text = soruno.ToString();


            
            




            if (soruno == 1)
            {
                richTextBox1.Text = "Fırat üniversitesi ne zaman kurulmuştur ? ";

                btnA.Text = "1453";

                btnB.Text = "1975";

                btnC.Text = "1996";

                btnD.Text = "2002";

                label4.Text = "1975";
            }

            if (soruno == 2)
            {
                richTextBox1.Text = " Atatürk kaç yılında doğmuştur ? ";


                btnA.Text = "1071";

                btnB.Text = "1938";

                btnC.Text = "1881";

                btnD.Text = "1889";

                label4.Text = "1881";


            }

            if (soruno == 3)
            {
                richTextBox1.Text = " İstiklal marşını kim yazmıştır ? ";


                btnA.Text = "Mehmet Ali Birand";

                btnB.Text = "Mehmet Ali Erbil ";

                btnC.Text = "Barış Manço";

                btnD.Text = "Mehmet Akif Ersoy";

                label4.Text = "Mehmet Akif Ersoy";

                btnsonraki.Text = "Sonuçlar";

            }

            if (soruno==4)
            {
                MessageBox.Show("Doğru: " + dogru + " \nYanlış : " + yanlis);


            }




        }
    }
}
