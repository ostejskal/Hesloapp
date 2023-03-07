using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesloapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string heslo; //pro testování výsledků

        private void button1_Click(object sender, EventArgs e)
        {
            heslo = textBox1.Text;
        }
        public string VratHeslo() //pro testování metod
        { return heslo; }
    }
}
