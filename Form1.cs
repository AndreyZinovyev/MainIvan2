using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form main = new Main();
            main.ShowDialog();
            //Вход


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form regicration = new Form2();
            regicration.ShowDialog();
        }
    }
}
