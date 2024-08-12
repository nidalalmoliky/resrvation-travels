using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Books
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.SetBounds(100, 100, 500, 300);
           
            this.Size = new Size(1000, 800);
            this.Text = " واجهة البرنامج";
           // this.FormBorderStyle=FormBorderStyle.None;
          //  this.CenterToScreen();
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2, (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);//out from program
        }

        private void small_screen_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void big_screen_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form view_trip = new view_trip();
            view_trip.Show();
            
        }
    }
}
