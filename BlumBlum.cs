using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlumBlumShub
{
    public partial class BlumBlum : Form
    {
        public BlumBlum()
        {
            InitializeComponent();
           
        }
        private void BlumBlum_Load(object sender, System.EventArgs e)
        {
            
        }

        private void BlumBlum_Closed(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void Alghoritm(int n, int s)
        {
            Point[] points = new Point[n];
            int[] x = new int[n];
            int p = 967;
            int q = 859;

            int M = p * q;
                x[0] = (s * s) % M;

                for (int i = 1; i < x.Length; i++)
                {
                    x[i] = (x[i - 1] * x[i - 1]) % M;
                }
            for (int i = 0; i < x.Length; i++) result.Text += ($"{x[i]}" + Environment.NewLine);



            for (int i = 0; i < n; i++)
            {
                chart1.Series[0].Points.AddXY(i, x[i]);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            result.Text = null;
            Alghoritm(int.Parse(numcount.Text), int.Parse(seed.Text));
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                chart1.SaveImage(saveFileDialog1.FileName+".png", System.Drawing.Imaging.ImageFormat.Png);

        }

       
    }
}
