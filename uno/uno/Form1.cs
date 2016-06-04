using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;

namespace uno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //Estas variables son las del tiempo. RR
        int mile;
        int seg;
        int min;
        int hor;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = true;
            if (min == 61)
            {
                hor += 1;
                min = 0;
            }

            if (seg == 61)
            {
                min += 1;
                seg = 0;
            }
            seg += 1;
            label1.Text= hor.ToString() + ":" + min.ToString() + ":" seg.ToString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Visible = true;
            if (mile == 61)
            {
                mile = 0;
            }
            mile += 1;
            label2.Text = mile.ToString();
        }
    }
}
