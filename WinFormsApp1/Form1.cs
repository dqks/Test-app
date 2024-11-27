using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Максим Штин";
            textBox2.Text = "ИС-22";
            if (!Regex.IsMatch(textBox1.Text, @"^[А-Я]{1}[а-я]+ [А-Я]{1}[а-я]+([А-Я]{1}[а-я]+$)?"))
            {
                label3.Text = "Введите верное ФИО";
                return;
            }

            if (!Regex.IsMatch(textBox2.Text, @"^[А-Я]+\-\d{2}$"))
            {
                label3.Text = "Введите верное название группы";
                return;
            }



            label3.Text = "";
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
