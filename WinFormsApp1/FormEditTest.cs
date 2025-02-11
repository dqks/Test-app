using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class FormEditTest : Form
    {
        TreeNode testWrapper;
        bool exists = false;
        string level;
        string subject;
        private bool isClosedByUser = true;
        int questionNumber = 2;
        TreeNode initialTest;


        public FormEditTest(string level, string subject)
        {
            InitializeComponent();
            this.level = level;
            this.subject = subject;

            List<TreeNode> tests = TreeNode.tests;

            foreach (TreeNode test in tests)
            {
                if (test.ID == subject)
                {
                    initialTest = test;
                }
            }
        }
        private void FormEditTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isClosedByUser == false)
            {
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                switch (MessageBox.Show(this,
                    "Вы действительно хотите закрыть форму?\nВсе введённые данные не сохранятся",
                    "Подтверждение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    )
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;

                    default:
                        Form2 form2 = new Form2();
                        form2.Show();
                        break;
                }
            }
        }

        private void FormEditTest_Load(object sender, EventArgs e) // Загрузка данных в поля и чекбоксы
        {
            labelTestName.Text = subject + ", " + level;

            List<TreeNode> subjects = TreeNode.tests;
            TreeNode child = new TreeNode("");
            foreach (TreeNode node in subjects)
            {
                if (node.ID == subject)
                {
                    child = node.GetChild(level);// Получаем блок вопросов по ключу
                                                 // уровня сложности по выбранному предмету
                }
            }

            for (int i = 0; i < child.Count - 1; i++)
            {

                testingTab.Controls.Add(createTabPage());
            }

            IEnumerator<TreeNode> questions = child.GetEnumerator(); //получаем все вопросы
            TreeNode answers;
            int pageNumber = 0;
            int questionNumber = 0;
            //Label label3 = (Label)tabControl1.TabPages[2].Controls["label3"];
            while (questions.MoveNext()) // передвигаемся по вопросам
            {
                answers = child.GetChild(questions.Current.ID); // получаем деревья ответов
                IEnumerator<TreeNode> variants = answers.GetEnumerator(); //получаем все варианты ответа к вопросам
                questionNumber = 0;

                TextBox firstInput = (TextBox)testingTab.TabPages[pageNumber].Controls["textBoxFirstQuestion"];
                TextBox secondInput = (TextBox)testingTab.TabPages[pageNumber].Controls["textBoxSecondQuestion"];
                TextBox thirdInput = (TextBox)testingTab.TabPages[pageNumber].Controls["textBoxThirdQuestion"];
                TextBox fourthInput = (TextBox)testingTab.TabPages[pageNumber].Controls["textBoxFourthQuestion"];
                TextBox fifthInput = (TextBox)testingTab.TabPages[pageNumber].Controls["textBoxFifthQuestion"];
                TextBox questionName = (TextBox)testingTab.TabPages[pageNumber].Controls["textBoxQuestionName"];
                TextBox[] textBoxes = { firstInput, secondInput, thirdInput, fourthInput, fifthInput };

                CheckBox firstCheckBox = (CheckBox)testingTab.TabPages[pageNumber].Controls["checkBoxIsTrueFirst"];
                CheckBox secondCheckBox = (CheckBox)testingTab.TabPages[pageNumber].Controls["checkBoxIsTrueSecond"];
                CheckBox thirdCheckBox = (CheckBox)testingTab.TabPages[pageNumber].Controls["checkBoxIsTrueThird"];
                CheckBox fourthCheckBox = (CheckBox)testingTab.TabPages[pageNumber].Controls["checkBoxIsTrueFourth"];
                CheckBox fifthCheckBox = (CheckBox)testingTab.TabPages[pageNumber].Controls["checkBoxIsTrueFifth"];
                CheckBox[] checkBoxes = { firstCheckBox, secondCheckBox, thirdCheckBox, fourthCheckBox, fifthCheckBox };

                while (variants.MoveNext()) //двигаемся по вариантам ответа к вопросу и добавляем их
                {
                    ComboBox questionType = (ComboBox)testingTab.TabPages[pageNumber].Controls["comboBoxChooseTypeOfAnswer"];



                    if (questions.Current.ID.Contains("RADIO"))
                    {
                        questionType.SelectedIndex = 0;
                    }
                    else if (questions.Current.ID.Contains("CHECKBOX"))
                    {
                        questionType.SelectedIndex = 1;
                    }

                    questionName.Text = questions.Current.ID.Replace("RADIO", "").Replace("CHECKBOX", "");

                    textBoxes[questionNumber].Text = variants.Current.ID.Replace("TRUE", "");

                    if (variants.Current.ID.Contains("TRUE"))
                    {
                        checkBoxes[questionNumber].Checked = true;
                    }

                    if (variants.Current.ID.Contains("TRUE"))
                    {
                    }
                    questionNumber++;
                }
                pageNumber++;
            }

        }

        private void showError(string message)
        {
            MessageBox.Show(
                message,
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            TabPage newTab = createTabPage();
            testingTab.Controls.Add(newTab);
        }

        private void buttonDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (testingTab.TabPages.Count == 1)
            {
                showError("Невозможно удалить единственный вопрос");
                return;
            }

            testingTab.Controls.Remove(testingTab.SelectedTab);

            TabControl.TabPageCollection allTabs = testingTab.TabPages;

            questionNumber = 1;

            foreach (TabPage tab in allTabs)
            {
                tab.Text = questionNumber++ + " вопрос";
            }
        }



        private void buttonNextQuestion_Click(object sender, EventArgs e)
        {
            {
                int index = testingTab.SelectedIndex;

                if (index + 1 < testingTab.TabCount)
                {
                    index++;
                }

                testingTab.SelectedIndex = index;
            }
        }

        private void buttonPreviousQuestion_Click(object sender, EventArgs e)
        {
            int index = testingTab.SelectedIndex;

            if (index - 1 >= 0)
            {
                index--;
            }

            testingTab.SelectedIndex = index;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            List<TreeNode> nodes = new List<TreeNode>();

            testWrapper = new TreeNode(subject) {};
            
            TreeNode levelWrapper = new TreeNode(level) { };

            var allTabs = testingTab.GetAllNestedControls().OfType<TabPage>();

            foreach (TabPage tab in allTabs)
            {
                var tabInputs = tab.GetAllNestedControls().OfType<TextBox>().ToArray();

                if (tabInputs[0].Text == "")
                {
                    showError("В какой-то из вкладок не введен вопрос");
                    return;
                }
                int countFilledTextBoxes = 0;

                for (int i = 1; i < tabInputs.Length; i++)
                {
                    if (tabInputs[i].Text != "")
                    {
                        countFilledTextBoxes++;
                    }
                }

                if (countFilledTextBoxes < 2)
                {
                    showError("В какой-то из вкладок недостаточно вариантов ответа" +
                        "\nДолжно быть как минимум 2 варианта ответа");
                    return;
                }

                int countRightAnswers = 0;

                var tabComboBox = tab.GetAllNestedControls().OfType<ComboBox>().ToArray();
                var tabCheckBoxes = tab.GetAllNestedControls().OfType<CheckBox>().ToArray();

                if (tabComboBox[0].SelectedItem != null)
                {


                    if (tabComboBox[0].SelectedItem.ToString() == "Радио кнопка")
                    {

                        for (int i = 0, j = 1; i < tabCheckBoxes.Length; i++, j++)
                        {
                            if (tabCheckBoxes[i].Checked && tabInputs[j].Text != "")
                            {
                                countRightAnswers++;
                            }
                        }
                        if (countRightAnswers > 1)
                        {
                            showError("При варианте с радиокнопками не может быть больше 1 варианта ответа");
                            return;
                        }
                        else if (countRightAnswers <= 0)
                        {
                            showError("Выберите правильный вариант ответа");
                            return;
                        }
                    }
                    else if (tabComboBox[0].SelectedItem.ToString() == "Чекбокс")
                    {
                        for (int i = 0, j = 1; i < tabCheckBoxes.Length; i++, j++)
                        {
                            if (tabCheckBoxes[i].Checked && tabInputs[j].Text != "")
                            {
                                countRightAnswers++;
                            }
                        }
                        if (countRightAnswers <= 0)
                        {
                            showError("Выберите правильный/ые ответ/ы");
                            return;
                        }
                    }
                }
                else
                {
                    showError("Выберите тип ответа");
                    return;
                }

                countRightAnswers = 0;

                //Заполнение TreeBode вопросами и ответами

                string questionName = tabInputs[0].Text;
                if (tabComboBox[0].SelectedItem.ToString() == "Радио кнопка")
                {
                    questionName += "RADIO";
                }
                else if (tabComboBox[0].SelectedItem.ToString() == "Чекбокс")
                {
                    questionName += "CHECKBOX";
                }

                TreeNode node = new TreeNode(questionName)
                {

                };

                TreeNode question;


                string text;
                for (int i = 1, j = 0; i < tabInputs.Length; i++, j++)
                {
                    text = tabInputs[i].Text;
                    if (text != "")
                    {

                        if (tabCheckBoxes[j].Checked)
                        {
                            text += "TRUE";
                        }

                        question = new TreeNode(text);
                        try
                        {
                            node.Add(question);
                        }
                        catch
                        {
                            showError("Вопрос не должен иметь одинаковые варианты ответа");
                            return;
                        }
                    }
                }

                levelWrapper.Add(node);
            }

            testWrapper.Add(levelWrapper);

            List<TreeNode> tests = TreeNode.tests;

            TreeNode testToRemove = new TreeNode("");

            int testPosition = 0;

            foreach (TreeNode test in initialTest)
            {
                if (test.ID != level)
                {
                    testWrapper.Add(test);
                }
            }

            foreach (TreeNode node in TreeNode.tests)
            {
                if (node.ID == subject)
                {
                    testToRemove = node;
                    testPosition = tests.IndexOf(node);
                }

            }
            tests.Remove(testToRemove);

            tests.Insert(testPosition, testWrapper);

            TreeNode.tests = tests;

            isClosedByUser = false;
            this.Close();
        }

        private void buttonDeleteTest_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this,
            "Вы действительно хотите удалить уровень теста?",
            "Подтверждение",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question))
            {
                case DialogResult.No:
                    break;

                default:
                    isClosedByUser = false;

                    List<TreeNode> tests = TreeNode.tests;

                    TreeNode wrapper = new TreeNode(subject);

                    TreeNode testToRemove = new TreeNode("");

                    int testPosition = 0;

                    foreach (TreeNode test in initialTest)
                    {
                        if (test.ID != level)
                        {
                            wrapper.Add(test);
                        }
                    }




                    foreach (TreeNode node in TreeNode.tests)
                    {
                        if (node.ID == subject)
                        {
                            testToRemove = node;
                            testPosition = tests.IndexOf(node);
                        } 
                        
                    }

                    if (wrapper.Count == 0)
                    {
                        tests.Remove(testToRemove);

                        XmlSerializer serializer = new XmlSerializer(typeof(TreeNode));

                        using (FileStream fs = new FileStream("TestsXML.xml", FileMode.OpenOrCreate))
                        {
                            foreach (var node in TreeNode.tests)
                            {
                                serializer.Serialize(fs, node);
                            }
                        }

                        this.Close();
                        break;
                    } else
                    {
                        tests.Remove(testToRemove);

                        tests.Insert(testPosition, wrapper);

                        TreeNode.tests = tests;

                        XmlSerializer serializer = new XmlSerializer(typeof(List<TreeNode>));

                        using (FileStream fs = new FileStream("TestsXML.xml", FileMode.OpenOrCreate))
                        {
                            serializer.Serialize(fs, TreeNode.tests);
                        }

                        this.Close();
                        break;
                    }
            }
        }

        private TabPage createTabPage()
        {
            TabPage tabPage = new TabPage();

            tabPage.Text = questionNumber++ + " вопрос";
            tabPage.BackColor = Color.FromArgb(25, 27, 39);

            Button buttonDeleteQuestion = new Button();
            Button buttonAddQuestion = new Button();
            ComboBox comboBoxChooseTypeOfAnswer = new ComboBox();
            Button buttonNextQuestion = new Button();
            Button buttonPreviousQuestion = new Button();

            CheckBox checkBoxIsTrueFifth = new CheckBox();
            CheckBox checkBoxIsTrueFourth = new CheckBox();
            CheckBox checkBoxIsTrueThird = new CheckBox();
            CheckBox checkBoxIsTrueSecond = new CheckBox();
            CheckBox checkBoxIsTrueFirst = new CheckBox();

            TextBox textBoxFifthQuestion = new TextBox();
            TextBox textBoxFourthQuestion = new TextBox();
            TextBox textBoxThirdQuestion = new TextBox();
            TextBox textBoxSecondQuestion = new TextBox();
            TextBox textBoxFirstQuestion = new TextBox();
            TextBox textBoxQuestionName = new TextBox();

            buttonDeleteQuestion.Font = new Font("Segoe UI", 12F);
            buttonDeleteQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonDeleteQuestion.FlatStyle = FlatStyle.Flat;
            buttonDeleteQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonDeleteQuestion.Location = new Point(378, 374);
            buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            buttonDeleteQuestion.Size = new Size(162, 36);
            buttonDeleteQuestion.TabIndex = 1;
            buttonDeleteQuestion.ForeColor = Color.White;
            buttonDeleteQuestion.Text = "Удалить вопрос";
            buttonDeleteQuestion.UseVisualStyleBackColor = true;
            buttonDeleteQuestion.Click += buttonDeleteQuestion_Click;

            tabPage.Controls.Add(buttonDeleteQuestion);

            buttonAddQuestion.Font = new Font("Segoe UI", 12F);
            buttonAddQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonAddQuestion.FlatStyle = FlatStyle.Flat;
            buttonAddQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonAddQuestion.Location = new Point(378, 332);
            buttonAddQuestion.Name = "buttonAddQuestion";
            buttonAddQuestion.Size = new Size(162, 36);
            buttonAddQuestion.TabIndex = 0;
            buttonAddQuestion.ForeColor = Color.White;
            buttonAddQuestion.Text = "Добавить вопрос";
            buttonAddQuestion.UseVisualStyleBackColor = true;
            buttonAddQuestion.Click += buttonAddQuestion_Click;

            tabPage.Controls.Add(buttonAddQuestion);

            comboBoxChooseTypeOfAnswer.Font = new Font("Segoe UI", 12F);
            comboBoxChooseTypeOfAnswer.FlatStyle = FlatStyle.Flat;
            comboBoxChooseTypeOfAnswer.BackColor = Color.FromArgb(25, 27, 39);
            comboBoxChooseTypeOfAnswer.ForeColor = Color.White;
            comboBoxChooseTypeOfAnswer.FormattingEnabled = true;
            comboBoxChooseTypeOfAnswer.Items.AddRange(new object[] { "Радио кнопка", "Чекбокс" });
            comboBoxChooseTypeOfAnswer.Location = new Point(378, 12);
            comboBoxChooseTypeOfAnswer.Name = "comboBoxChooseTypeOfAnswer";
            comboBoxChooseTypeOfAnswer.RightToLeft = RightToLeft.No;
            comboBoxChooseTypeOfAnswer.Size = new Size(177, 29);
            comboBoxChooseTypeOfAnswer.TabIndex = 3;
            comboBoxChooseTypeOfAnswer.Text = "Выберите тип ответа";

            tabPage.Controls.Add(comboBoxChooseTypeOfAnswer);

            buttonNextQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonNextQuestion.FlatStyle = FlatStyle.Flat;
            buttonNextQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonNextQuestion.Font = new Font("Segoe UI", 12F);
            buttonNextQuestion.Location = new Point(190, 352);
            buttonNextQuestion.Name = "buttonNextQuestion";
            buttonNextQuestion.Size = new Size(162, 36);
            buttonNextQuestion.TabIndex = 15;
            buttonNextQuestion.Text = "Далее";
            buttonNextQuestion.ForeColor = Color.White;
            buttonNextQuestion.UseVisualStyleBackColor = false;
            buttonNextQuestion.Click += buttonNextQuestion_Click;

            tabPage.Controls.Add(buttonNextQuestion);

            buttonPreviousQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonPreviousQuestion.FlatStyle = FlatStyle.Flat;
            buttonPreviousQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonPreviousQuestion.Font = new Font("Segoe UI", 12F);
            buttonPreviousQuestion.Location = new Point(7, 352);
            buttonPreviousQuestion.Name = "buttonPreviousQuestion";
            buttonPreviousQuestion.Size = new Size(162, 36);
            buttonPreviousQuestion.TabIndex = 14;
            buttonPreviousQuestion.ForeColor = Color.White;
            buttonPreviousQuestion.Text = "Назад";
            buttonPreviousQuestion.UseVisualStyleBackColor = false;
            buttonPreviousQuestion.Click += buttonPreviousQuestion_Click;

            tabPage.Controls.Add(buttonPreviousQuestion);

            checkBoxIsTrueFirst.AutoSize = true;
            checkBoxIsTrueFirst.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueFirst.Location = new Point(525, 92);
            checkBoxIsTrueFirst.Name = "checkBoxIsTrueFirst";
            checkBoxIsTrueFirst.Size = new Size(15, 14);
            checkBoxIsTrueFirst.TabIndex = 9;
            checkBoxIsTrueFirst.UseVisualStyleBackColor = true;

            tabPage.Controls.Add(checkBoxIsTrueFirst);

            checkBoxIsTrueSecond.AutoSize = true;
            checkBoxIsTrueSecond.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueSecond.Location = new Point(525, 138);
            checkBoxIsTrueSecond.Name = "checkBoxIsTrueSecond";
            checkBoxIsTrueSecond.Size = new Size(15, 14);
            checkBoxIsTrueSecond.TabIndex = 10;
            checkBoxIsTrueSecond.UseVisualStyleBackColor = true;

            tabPage.Controls.Add(checkBoxIsTrueSecond);

            checkBoxIsTrueThird.AutoSize = true;
            checkBoxIsTrueThird.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueThird.Location = new Point(525, 182);
            checkBoxIsTrueThird.Name = "checkBoxIsTrueThird";
            checkBoxIsTrueThird.Size = new Size(15, 14);
            checkBoxIsTrueThird.TabIndex = 11;
            checkBoxIsTrueThird.UseVisualStyleBackColor = true;

            tabPage.Controls.Add(checkBoxIsTrueThird);

            checkBoxIsTrueFourth.AutoSize = true;
            checkBoxIsTrueFourth.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueFourth.Location = new Point(525, 224);
            checkBoxIsTrueFourth.Name = "checkBoxIsTrueFourth";
            checkBoxIsTrueFourth.Size = new Size(15, 14);
            checkBoxIsTrueFourth.TabIndex = 12;
            checkBoxIsTrueFourth.UseVisualStyleBackColor = true;

            tabPage.Controls.Add(checkBoxIsTrueFourth);

            checkBoxIsTrueFifth.AutoSize = true;
            checkBoxIsTrueFifth.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueFifth.Location = new Point(525, 263);
            checkBoxIsTrueFifth.Name = "checkBoxIsTrueFifth";
            checkBoxIsTrueFifth.Size = new Size(15, 14);
            checkBoxIsTrueFifth.TabIndex = 13;
            checkBoxIsTrueFifth.UseVisualStyleBackColor = true;

            tabPage.Controls.Add(checkBoxIsTrueFifth);

            textBoxQuestionName.Font = new Font("Segoe UI", 12F);
            textBoxQuestionName.BackColor = Color.FromArgb(25, 27, 39);
            textBoxQuestionName.ForeColor = Color.White;
            textBoxQuestionName.Location = new Point(7, 12);
            textBoxQuestionName.Name = "textBoxQuestionName";
            textBoxQuestionName.PlaceholderText = "Вопрос";
            textBoxQuestionName.Size = new Size(365, 29);
            textBoxQuestionName.TabIndex = 16;

            tabPage.Controls.Add(textBoxQuestionName);

            textBoxFirstQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFirstQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFirstQuestion.ForeColor = Color.White;
            textBoxFirstQuestion.Location = new Point(7, 85);
            textBoxFirstQuestion.Name = "textBoxFirstQuestion";
            textBoxFirstQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstQuestion.PlaceholderText = "Первый вариант ответа";
            textBoxFirstQuestion.Size = new Size(496, 29);
            textBoxFirstQuestion.TabIndex = 4;

            tabPage.Controls.Add(textBoxFirstQuestion);

            textBoxSecondQuestion.Font = new Font("Segoe UI", 12F);
            textBoxSecondQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxSecondQuestion.ForeColor = Color.White;
            textBoxSecondQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxSecondQuestion.Location = new Point(7, 131);
            textBoxSecondQuestion.Name = "textBoxSecondQuestion";
            textBoxSecondQuestion.PlaceholderText = "Второй вариант ответа";
            textBoxSecondQuestion.Size = new Size(496, 29);
            textBoxSecondQuestion.TabIndex = 5;

            tabPage.Controls.Add(textBoxSecondQuestion);

            textBoxThirdQuestion.Font = new Font("Segoe UI", 12F);
            textBoxThirdQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxThirdQuestion.ForeColor = Color.White;
            textBoxThirdQuestion.Location = new Point(7, 175);
            textBoxThirdQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxThirdQuestion.Name = "textBoxThirdQuestion";
            textBoxThirdQuestion.PlaceholderText = "Третий вариант ответа";
            textBoxThirdQuestion.Size = new Size(496, 29);
            textBoxThirdQuestion.TabIndex = 6;

            tabPage.Controls.Add(textBoxThirdQuestion);

            textBoxFourthQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFourthQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFourthQuestion.ForeColor = Color.White;
            textBoxFourthQuestion.Location = new Point(7, 217);
            textBoxFourthQuestion.Name = "textBoxFourthQuestion";
            textBoxFourthQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxFourthQuestion.PlaceholderText = "Четвертый вариант ответа";
            textBoxFourthQuestion.Size = new Size(496, 29);
            textBoxFourthQuestion.TabIndex = 7;

            tabPage.Controls.Add(textBoxFourthQuestion);

            textBoxFifthQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFifthQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFifthQuestion.ForeColor = Color.White;
            textBoxFifthQuestion.Location = new Point(7, 256);
            textBoxFifthQuestion.Name = "textBoxFifthQuestion";
            textBoxFifthQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxFifthQuestion.PlaceholderText = "Пятый вариант ответа";
            textBoxFifthQuestion.Size = new Size(496, 29);
            textBoxFifthQuestion.TabIndex = 8;

            tabPage.Controls.Add(textBoxFifthQuestion);

            return tabPage;
        }
    }
}