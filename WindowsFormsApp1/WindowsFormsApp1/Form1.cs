using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Text = "Hello World!!!";
            Mes mes1 = new Mes();
            Form1.ActiveForm.Text = mes1.libmes();
            textBox1.Text = "После изменения";
            textBox1.Text = "Изменение из ГитХаба";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
