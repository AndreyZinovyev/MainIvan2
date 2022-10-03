using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Main
{
    public partial class Form2 : Form
    {
        TestConnect db;
        public Form2()
        {
            InitializeComponent();
            db = new TestConnect();
            db.Test.Load();
            dataGridView1.DataSource = db.Test.Local.ToBindingList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Test reg = new Test();
            reg.Login = Login.Text;
            reg.Password = Password.Text;

            db.Test.Add(reg);
            db.SaveChanges();
        }
    }
}
