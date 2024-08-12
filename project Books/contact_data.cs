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
    public partial class contact_data : Form
    {
        public contact_data()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form payment_method = new payment_method();
            payment_method.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
