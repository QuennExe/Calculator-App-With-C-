using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_App
{
    public partial class Form1 : Form
    {
        

        private char process;
        private bool Doyouwanttodelete;
        private int firstnumber;
        public Form1()
            // @Lolita
        {
            InitializeComponent();

           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete) 
            { 
                screen_label.Text = ""; 
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text=="0") screen_label.Text="";
            screen_label.Text += "1";

        }

        private void number_2_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "2";
        }

        private void number_4_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "4";
        }

        private void number_5_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "5";
        }

        private void number_6_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "6";
        }

        private void number_7_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "7";
        }

        private void number_8_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "8";
        }

        private void number_9_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "9";
        }

        private void number_0_Click(object sender, EventArgs e)
        {
            if (Doyouwanttodelete)
            {
                screen_label.Text = "";
                Doyouwanttodelete = false;
            }
            if (screen_label.Text == "0") screen_label.Text = "";
            screen_label.Text += "0";
        }

        private void collection_button_Click(object sender, EventArgs e)
        {
            process = '+';
            Doyouwanttodelete = true;
            firstnumber= Convert.ToInt32(screen_label.Text);
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            int secondnumber= Convert.ToInt32(screen_label.Text);
            int conclusion;

            switch (process)
            {
                case '+':
                    conclusion = firstnumber + secondnumber;
                    break;
                case '-':
                    conclusion = firstnumber - secondnumber;
                    break;
                case '*':
                    conclusion = firstnumber * secondnumber;
                    break;
                case '/':
                    conclusion = firstnumber / secondnumber;
                    break;
                case '%':
                    conclusion = firstnumber % secondnumber;
                    break;
                default: 
                    conclusion=0;
                    break;
            }
            screen_label.Text=  Convert.ToString(conclusion);
        }

        private void percentage_button_Click(object sender, EventArgs e)
        {
            process = '%';
            Doyouwanttodelete = true;
            firstnumber = Convert.ToInt32(screen_label.Text);

        }

        private void division_button_Click(object sender, EventArgs e)
        {
            process = '/';
            Doyouwanttodelete = true;
            firstnumber = Convert.ToInt32(screen_label.Text);
        }

        private void impact_button_Click(object sender, EventArgs e)
        {
            process = '*';
            Doyouwanttodelete = true;
            firstnumber = Convert.ToInt32(screen_label.Text);
        }

        private void extraction_button_Click(object sender, EventArgs e)
        {
            process = '-';
            Doyouwanttodelete = true;
            firstnumber = Convert.ToInt32(screen_label.Text);
        }

        private void restart_button_Click(object sender, EventArgs e)
        {
            screen_label.Text="0";
        }

       

        private void screen_label_Click(object sender, EventArgs e)
        {

        }
    }
}
