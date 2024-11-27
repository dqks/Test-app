using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2 form;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string? subject;
            if (listBox1.SelectedItem != null)
            {
                subject = listBox1.SelectedItem.ToString();

            }
            else
            {
                label3.Text = "Выберите нужный предмет";
                return;
            }

            string level = "";

            for (int i = 0; i < panel1.Controls.Count; i++)
            {
                RadioButton radio = (RadioButton)panel1.Controls[i];
                if (radio.Checked == true)
                {
                    level = radio.Text;
                }
            }

            if (level == "")
            {
                label3.Text = "Выберите нужный уровень";
                return;
            }

            Form3 form3 = new Form3(subject, level);
            form3.Show();
            this.Close();
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            createTestForm createTest = new createTestForm();
            createTest.Show();
            this.Close();
        }
    }
}


//Создать форму для создания вопросов к тесту, предметов и т.д.