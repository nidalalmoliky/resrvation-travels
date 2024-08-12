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
    public partial class printData :Form
    {
        private string go;
        private string back;
        private DateTime date1;
        private DateTime date2;
        private int number;
        private string combox;

        private string name;
        private string identity_type;
        private string number_identity;

        private string radiobutton;




        public printData(string go, string back, DateTime date1, DateTime date2, int number, string combox,string name,string identity_type,string number_identity,string radiobutton)
        {

            
            InitializeComponent();

            //save date
            this.go = go;
            this.back =back;
            this.date1 =date1;
            this.date2 =  date2;
            this.number = number;
            this.combox = combox;
            this.name = name;
            this.identity_type = identity_type;
            this.number_identity = number_identity;
            this.radiobutton = radiobutton;

            label1.Text = "مغادرتك هي من محافظة :" + go;
            label2.Text = "وصولك هو الى:" + back;
            label3.Text = "تاريخ المغادرة: " + date1.ToShortDateString();
            label4.Text = "تاريخ العودة :" + date2.ToShortDateString();
            label5.Text = "عدد الاشخاص الذين معك : " + number.ToString();
            label6 .Text= " الشركة التي اخترت ان تحجز فيها هي :"+combox;

            label7.Text = "اسمك الرباعي هو: "+name;
            label8.Text = " نوع هويتك هي :"+identity_type;
            label9.Text = " رقم هويتك"+number_identity;
            label10.Text = " السعر الاجمالي للرحلة هو:"+radiobutton;

        }

        private void printData_Load(object sender, EventArgs e)
        {
            
          
            /*
            text1.Text = text1.Text;
            text2.Text = text2.Text;
            date1.Value = date1.Value;
            date2.Value = date2.Value;
            comboBox1.SelectedItem = comboBox1.SelectedItem;
             


         */
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form contact_data = new contact_data();
            contact_data.Show();
        }


       
    }
}
