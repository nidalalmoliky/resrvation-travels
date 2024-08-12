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
    public partial class payment_method : Form
    {
        public payment_method()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked ==false && radioButton2.Checked==false)
            {

                MessageBox.Show("عذرا قم بالاختيار ومن ثم اضغط على زر الارسال");
               }
                else
                {
              
                MessageBox.Show("تم ارسال البيانات بنجاح");

                }
            /*
            if (radioButton2.Checked == true)
                MessageBox.Show("تم ارسال البيانات بنجاح");
            else {
                MessageBox.Show("عذرا قم بالاختيار ومن ثم اضغط على زر الارسال");
            */
            }
        }
            }
        
    

