using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Main
{
    public partial class Main : Form
    {
        SoccerContext db;
        public Main()
        {
            InitializeComponent();
            db = new SoccerContext();
            db.docx.Load();
            dataGridView1.DataSource = db.docx.Local.ToBindingList();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
                case "Электронная почта":
                    panel1.Visible = false;
                    panel3.Visible = true;
                    comboBox2.Text = "Электронная почта";
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox2.Text)
            {
                case "Логин":
                    panel3.Visible = false;
                    panel1.Visible = true;
                    comboBox1.Text = "Логин";
                    break;
            }
        }

        private void buttonadd_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            comboBox1.Text = "Логин";
            buttonSave.Visible = true;
            buttonback.Visible = true;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           


            switch (comboBox1.Text)
            {
                case "Логин":

                    docx docx = new docx();
                    docx.tip=comboBox1.SelectedItem.ToString();
                    docx.Name = username1.Text;
                    docx.password = password1.Text;
                    docx.email = mail1.Text;
                  
                    db.docx.Add(docx);
                    db.SaveChanges();
                    break;
                case "Электронная почта":
           


                    break;
            }
            switch (comboBox2.Text)
            {
                case "Электронная почта":
                    docx docx = new docx();
                    docx.tip = comboBox1.SelectedItem.ToString();
                    docx.email = mail2.Text;
                    docx.numberPhone = phoneNamber2.Text;
                    docx.password = password2.Text;
                    db.docx.Add(docx);
                    db.SaveChanges();
                    break;
            }
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            //Очистим то, что осталось запослненным
            login1.Clear();
            mail1.Clear();
            mail2.Clear();
            password1.Clear();
            password2.Clear();
            phoneNamber2.Clear();
            username1.Clear();
            //Законмим на этом

            //Прячем все 
            panel1.Visible = false;
            panel3.Visible = false;
            buttonSave.Visible = false;
            buttonback.Visible = false;
            //Спрятали
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
