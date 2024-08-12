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
    public partial class view_trip : Form
    {

        private string go;
        private string back;
        private DateTime date1;
        private DateTime date2;
        private int number;
        private string combox;


        ///////////////// this gropbox1;
        private string name;
        private string identity_type;
        private string number_identity;

        private string radiobutton;
       

        public view_trip()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void saturday_Click(object sender, EventArgs e)
        {
            groupBox1_view.Visible = true;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
         //   groupBox2_view.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //groupBox1_view.Visible = false;
            
        }

        private void groupBox2_view_Enter(object sender, EventArgs e)
        {
           
        }

        private void sunday_Click(object sender, EventArgs e)
        {
            //groupBox2_view.Visible = true;
            groupBox1_view.Visible = false;
        }

        private void groupBox2_view_Enter_1(object sender, EventArgs e)
        {
            //groupBox2_view.Visible = false;
        }

        private void button2_view_Click(object sender, EventArgs e)
        {



            go = textBox5.Text;
            back = textBox1.Text;
            date1 = dateTimePicker1.Value;
            date2 = dateTimePicker2.Value;
            number = (int)input_number.Value;
            combox = comboBox2.SelectedItem.ToString();
            radiobutton=radioButton1.Checked?radioButton1.Text:radioButton2.Text;
            name = textBox1_name.Text;
            identity_type = textBox2_identiy.Text;
            number_identity = id_number.Text;

            Form printData = new printData(go, back, date1, date2, number, combox, name,identity_type,number_identity,radiobutton);
            printData.Show();


        }

        private void button1_view_Click(object sender, EventArgs e)
        { 
        
           
        }

        private void view_trip_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1_view.Visible = false;
            groupBox2.Visible = false;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox1_view.Visible = false;
            groupBox1.Visible = false;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        }
    }

