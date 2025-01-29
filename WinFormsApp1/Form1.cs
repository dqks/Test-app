using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormRegistration : Form
    {

        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = "Максим Штин";
            textBoxGroup.Text = "ИС-22";
            if (!Regex.IsMatch(textBoxFullName.Text, @"^[А-Я]{1}[а-я]+ [А-Я]{1}[а-я]+([А-Я]{1}[а-я]+$)?"))
            {
                MessageBox.Show(
                    "Введите верное ФИО",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBoxGroup.Text, @"^[А-Я]+\-\d{2}$"))
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


/*
 
Редактирование теста

Просмотр результатов теста - значит нельзя создавать тест с одинаковым названием
 
 */