using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassFactorial;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = "0";
            bool ok = int.TryParse(textBox1.Text, out int n);
            Factorial obj = new Factorial();
            if (n > 0 && ok)
                label2.Text = Convert.ToString(obj.count(n));
        }
    }
}
