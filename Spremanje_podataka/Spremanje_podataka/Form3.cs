using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spremanje_podataka
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frmForm4 = new Form4();
            frmForm4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frmForm2 = new Form2();
            frmForm2.Show();
            this.Hide();
        }
    }
}
