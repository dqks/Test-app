using System.Text.Json;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {

        User user;

        public Form2()
        {
            InitializeComponent();

            if (comboBoxSubjects.Items.Count == 0)
            {
                foreach (var node in TreeNode.tests)
                {
                    comboBoxSubjects.Items.Add(node.ID);
                }
            }
        }

        public Form2(User user)
        {
            InitializeComponent();

            if (comboBoxSubjects.Items.Count == 0)
            {
                foreach (var node in TreeNode.tests)
                {
                    comboBoxSubjects.Items.Add(node.ID);
                }
            }

            this.user = user;
        }

        async private void nextButton_Click(object sender, EventArgs e)
        {
            string? subject;
            if (comboBoxSubjects.SelectedItem != null)
            {
                subject = comboBoxSubjects.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show(
                    "Выберите нужный предмет",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string level = "";

            for (int i = 0; i < panelLevels.Controls.Count; i++)
            {
                RadioButton radio = (RadioButton)panelLevels.Controls[i];
                if (radio.Checked == true)
                {
                    level = radio.Text;
                }
            }

            if (level == "")
            {
                MessageBox.Show(
                    "Выберите нужный уровень",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            List<TreeNode> subjects = TreeNode.tests; //Получаем массив из всех деревьев
            TreeNode child = new TreeNode("");

            try
            {
                foreach (TreeNode node in subjects)
                {
                    if (node.ID == subject)
                    {
                        child = node.GetChild(level);// Получаем блок вопросов по ключу
                                                     // уровня сложности по выбранному предмету
                    }
                }

                if (child == null)
                {
                    MessageBox.Show(
                        "Выбранного теста не существует",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                Form3 form3 = new Form3(subject, level, child, user);
                form3.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Выбранного теста не существует",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void addTestButton_Click(object sender, EventArgs e)
        {
            createTestForm createTest = new createTestForm();
            createTest.Show();
            this.Close();
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            //if (TestResults.GetResults().Count == 0)
            //{
            //    MessageBox.Show(
            //        "Вы ещё не прошли ни одного теста",
            //        "Ошибка",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //    return;
            //}

            FormResults formResults = new FormResults(user);
            formResults.Show();
            this.Close();
        }

        private void buttonEditTest_Click(object sender, EventArgs e)
        {
            string? subject;
            if (comboBoxSubjects.SelectedItem != null)
            {
                subject = comboBoxSubjects.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show(
                    "Выберите нужный предмет",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            string level = "";

            for (int i = 0; i < panelLevels.Controls.Count; i++)
            {
                RadioButton radio = (RadioButton)panelLevels.Controls[i];
                if (radio.Checked == true)
                {
                    level = radio.Text;
                }
            }

            if (level == "")
            {
                MessageBox.Show(
                    "Выберите нужный уровень",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            List<TreeNode> subjects = TreeNode.tests; //Получаем массив из всех деревьев
            TreeNode child = new TreeNode("");

            try
            {
                foreach (TreeNode node in subjects)
                {
                    if (node.ID == subject)
                    {
                        child = node.GetChild(level);// Получаем блок вопросов по ключу
                                                    // уровня сложности по выбранному предмету
                    }
                }

                if (child == null)
                {
                    MessageBox.Show(
                        "Выбранного теста не существует",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                FormEditTest formEditTest = new FormEditTest(level, subject);
                formEditTest.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Выбранного теста не существует",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}