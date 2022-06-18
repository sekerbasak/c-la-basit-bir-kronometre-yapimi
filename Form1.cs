using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer_ile_kronometre_örn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dakika++;
            label4.Text = Convert.ToString(dakika);
        }
        int dakika = 0;
        int saniye = 1;
        int salise = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 60000;
            timer2.Interval = 1000;
            timer3.Interval = 10;
            
            button2.Enabled = false;
            button1.Enabled = true;

            label4.Text = "0";
            label5.Text = "0";
            label6.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (saniye == 60)
            {
                saniye = 0;
            }
             saniye++;
            label5.Text = Convert.ToString(saniye);
          
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (salise == 100)
            {
                salise = 0;
            }
            salise++;
            label6.Text = Convert.ToString(salise);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
        }
    }
}
