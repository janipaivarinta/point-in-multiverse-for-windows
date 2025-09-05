using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Random rnd = new Random();
            int num = rnd.Next(2);

            int sequence1 = rnd.Next(1000, 9999);
            int sequence2 = rnd.Next(1000, 9999);
            int sequence3 = rnd.Next(1000, 9999);
            int sequence4 = rnd.Next(1000, 9999);

            int sequence5 = rnd.Next(1000, 9999);
            int sequence6 = rnd.Next(1000, 9999);
            int sequence7 = rnd.Next(1000, 9999);
            int sequence8 = rnd.Next(1000, 9999);

            int xyz = rnd.Next(3);

            string letter1 = "";

            if (xyz == 0)
                letter1 = "X@d";
            else if (xyz == 1)
                letter1 = "Y@d";
            else
                letter1 = "Z@d";

            int check1 = rnd.Next(1000, 9999);
            int check2 = rnd.Next(1000, 9999);

            if (num == 1)
            {
                textBox1.Text = "+" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2;
                Clipboard.SetText("+" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2);
            }
            else
            {
                textBox1.Text = "-" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2;
                Clipboard.SetText("-" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2);
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(2);

            int sequence1 = rnd.Next(1000, 9999);
            int sequence2 = rnd.Next(1000, 9999);
            int sequence3 = rnd.Next(1000, 9999);
            int sequence4 = rnd.Next(1000, 9999);

            int xyz = rnd.Next(3);

            string letter1 = "";

            if (xyz == 0)
                letter1 = "X@d";
            else if (xyz == 1)
                letter1 = "Y@d";
            else
                letter1 = "Z@d";

            int check1 = rnd.Next(1000, 9999);

            if (num == 1)
            {
                textBox1.Text = "+" + sequence1 + sequence2 + sequence3 + sequence4 + letter1 + check1;
                Clipboard.SetText("+" + sequence1 + sequence2 + sequence3 + sequence4 + letter1 + check1);
            }

            else
            {
                textBox1.Text = "-" + sequence1 + sequence2 + sequence3 + sequence4 + letter1 + check1;
                Clipboard.SetText("-" + sequence1 + sequence2 + sequence3 + sequence4 + letter1 + check1);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(2);

            int sequence1 = rnd.Next(1000, 9999);
            int sequence2 = rnd.Next(1000, 9999);
            int sequence3 = rnd.Next(1000, 9999);
            int sequence4 = rnd.Next(1000, 9999);

            int sequence5 = rnd.Next(1000, 9999);
            int sequence6 = rnd.Next(1000, 9999);
            int sequence7 = rnd.Next(1000, 9999);
            int sequence8 = rnd.Next(1000, 9999);

            int xyz = rnd.Next(3);

            string letter1 = "";

            if (xyz == 0)
                letter1 = "X@d";
            else if (xyz == 1)
                letter1 = "Y@d";
            else
                letter1 = "Z@d";

            int check1 = rnd.Next(1000, 9999);
            int check2 = rnd.Next(1000, 9999);

            if (num == 1)
            {
                textBox1.Text = "+" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2;
                Clipboard.SetText("+" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2);
            }
            else
            {
                textBox1.Text = "-" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2;
                Clipboard.SetText("-" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + letter1 + check1 + check2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(2);

            int sequence1 = rnd.Next(1000, 9999);
            int sequence2 = rnd.Next(1000, 9999);
            int sequence3 = rnd.Next(1000, 9999);
            int sequence4 = rnd.Next(1000, 9999);

            int sequence5 = rnd.Next(1000, 9999);
            int sequence6 = rnd.Next(1000, 9999);
            int sequence7 = rnd.Next(1000, 9999);
            int sequence8 = rnd.Next(1000, 9999);

            int sequence9 = rnd.Next(1000, 9999);
            int sequence10 = rnd.Next(1000, 9999);
            int sequence11 = rnd.Next(1000, 9999);
            int sequence12 = rnd.Next(1000, 9999);

            int sequence13 = rnd.Next(1000, 9999);
            int sequence14 = rnd.Next(1000, 9999);
            int sequence15 = rnd.Next(1000, 9999);
            int sequence16 = rnd.Next(1000, 9999);

            int xyz = rnd.Next(3);

            string letter1 = "";

            if (xyz == 0)
                letter1 = "X@d";
            else if (xyz == 1)
                letter1 = "Y@d";
            else
                letter1 = "Z@d";

            int check1 = rnd.Next(1000, 9999);
            int check2 = rnd.Next(1000, 9999);
            int check3 = rnd.Next(1000, 9999);
            int check4 = rnd.Next(1000, 9999);

            if (num == 1)
            {
                textBox1.Text = "+" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + sequence9 + sequence10 + sequence11 + sequence12 + sequence13 + sequence14 + sequence15 + sequence16 + letter1 + check1 + check2 + check3 + check4;
                Clipboard.SetText("+" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + sequence9 + sequence10 + sequence11 + sequence12 + sequence13 + sequence14 + sequence15 + sequence16 + letter1 + check1 + check2 + check3 + check4);
            }
            else
            {
                textBox1.Text = "-" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + sequence9 + sequence10 + sequence11 + sequence12 + sequence13 + sequence14 + sequence15 + sequence16 + letter1 + check1 + check2 + check3 + check4;
                Clipboard.SetText("-" + sequence1 + sequence2 + sequence3 + sequence4 + sequence5 + sequence6 + sequence7 + sequence8 + sequence9 + sequence10 + sequence11 + sequence12 + sequence13 + sequence14 + sequence15 + sequence16 + letter1 + check1 + check2 + check3 + check4);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
