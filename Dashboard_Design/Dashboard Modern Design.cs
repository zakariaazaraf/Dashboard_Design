using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard_Design
{
    public partial class DashboradDesignForm : Form
    {
        public DashboradDesignForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximaizePic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            MaximaizePic.Visible = false;
            MinimaizePic.Visible = true;
        }

        private void RestorePic_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void MinimaizePic_Click(object sender, EventArgs e)
        {
            
            WindowState = FormWindowState.Normal;
            MinimaizePic.Visible = false;
            MaximaizePic.Visible = true;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuPanel.Width == 300)
            {
                bunifuGradientPanel1.Visible = false;
                menuPanel.Width = 90;
                bunifuGradientPanel1.Width = 75;
                bunifuSeparator1.Width = 55;
                menuTransitionFirst.Show(bunifuGradientPanel1);
            }
            else
            {
                bunifuGradientPanel1.Visible = false;
                menuPanel.Width = 300;
                bunifuGradientPanel1.Width = 270;
                bunifuSeparator1.Width = 250;
                menuTransitionSecond.Show(bunifuGradientPanel1);
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.chart1.Series["ChartLine"].Points.AddXY("Day1", 40);
            this.chart1.Series["ChartLine"].Points.AddXY("Day2", 35);
            this.chart1.Series["ChartLine"].Points.AddXY("Day3", 40);
            this.chart1.Series["ChartLine"].Points.AddXY("Day4", 20);
            this.chart1.Series["ChartLine"].Points.AddXY("Day5", 30);
            this.chart1.Series["ChartLine"].Points.AddXY("Day6", 70);
            this.chart1.Series["ChartLine"].Points.AddXY("Day7", 80);
        }
    }
}
