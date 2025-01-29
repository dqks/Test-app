using System.Text.RegularExpressions;
using System.Windows.Forms;

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
                MessageBox.Show(
                    "Введите верное ФИО",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBox2.Text, @"^[А-Я]+\-\d{2}$"))
            {
                MessageBox.Show(
                    "Введите верное название группы",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            TreeNode.makeTreeNode();

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
