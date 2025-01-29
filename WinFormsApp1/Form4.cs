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

namespace WinFormsApp1
{
	public partial class createTestForm : Form
	{

		TreeNode testWrapper;
		bool exists = false;

        private bool isClosedByUser = true;
		int questionNumber = 2;
		public createTestForm()
		{
			InitializeComponent();

		}

		private void createTestForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (isClosedByUser == false)
			{
				Form2 form2 = new Form2(testWrapper);
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
			checkBoxIsTrueFirst.Location = new Point(398, 92);
			checkBoxIsTrueFirst.Name = "checkBoxIsTrueFirst";
			checkBoxIsTrueFirst.Size = new Size(15, 14);
			checkBoxIsTrueFirst.TabIndex = 9;
			checkBoxIsTrueFirst.UseVisualStyleBackColor = true;

			tabPage.Controls.Add(checkBoxIsTrueFirst);

			checkBoxIsTrueSecond.AutoSize = true;
			checkBoxIsTrueSecond.Font = new Font("Segoe UI", 12F);
			checkBoxIsTrueSecond.Location = new Point(398, 138);
			checkBoxIsTrueSecond.Name = "checkBoxIsTrueSecond";
			checkBoxIsTrueSecond.Size = new Size(15, 14);
			checkBoxIsTrueSecond.TabIndex = 10;
			checkBoxIsTrueSecond.UseVisualStyleBackColor = true;

			tabPage.Controls.Add(checkBoxIsTrueSecond);

			checkBoxIsTrueThird.AutoSize = true;
			checkBoxIsTrueThird.Font = new Font("Segoe UI", 12F);
			checkBoxIsTrueThird.Location = new Point(398, 182);
			checkBoxIsTrueThird.Name = "checkBoxIsTrueThird";
			checkBoxIsTrueThird.Size = new Size(15, 14);
			checkBoxIsTrueThird.TabIndex = 11;
			checkBoxIsTrueThird.UseVisualStyleBackColor = true;

			tabPage.Controls.Add(checkBoxIsTrueThird);

			checkBoxIsTrueFourth.AutoSize = true;
			checkBoxIsTrueFourth.Font = new Font("Segoe UI", 12F);
			checkBoxIsTrueFourth.Location = new Point(398, 224);
			checkBoxIsTrueFourth.Name = "checkBoxIsTrueFourth";
			checkBoxIsTrueFourth.Size = new Size(15, 14);
			checkBoxIsTrueFourth.TabIndex = 12;
			checkBoxIsTrueFourth.UseVisualStyleBackColor = true;

			tabPage.Controls.Add(checkBoxIsTrueFourth);

			checkBoxIsTrueFifth.AutoSize = true;
			checkBoxIsTrueFifth.Font = new Font("Segoe UI", 12F);
			checkBoxIsTrueFifth.Location = new Point(398, 263);
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
			textBoxQuestionName.Size = new Size(303, 29);
			textBoxQuestionName.TabIndex = 16;

			tabPage.Controls.Add(textBoxQuestionName);

			textBoxFirstQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFirstQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFirstQuestion.ForeColor = Color.White;
            textBoxFirstQuestion.Location = new Point(7, 85);
			textBoxFirstQuestion.Name = "textBoxFirstQuestion";
			textBoxFirstQuestion.PlaceholderText = "Первый вариант ответа";
			textBoxFirstQuestion.Size = new Size(374, 29);
			textBoxFirstQuestion.TabIndex = 4;

			tabPage.Controls.Add(textBoxFirstQuestion);

			textBoxSecondQuestion.Font = new Font("Segoe UI", 12F);
            textBoxSecondQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxSecondQuestion.ForeColor = Color.White;
            textBoxSecondQuestion.Location = new Point(7, 131);
			textBoxSecondQuestion.Name = "textBoxSecondQuestion";
			textBoxSecondQuestion.PlaceholderText = "Второй вариант ответа";
			textBoxSecondQuestion.Size = new Size(374, 29);
			textBoxSecondQuestion.TabIndex = 5;

			tabPage.Controls.Add(textBoxSecondQuestion);

			textBoxThirdQuestion.Font = new Font("Segoe UI", 12F);
            textBoxThirdQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxThirdQuestion.ForeColor = Color.White;
            textBoxThirdQuestion.Location = new Point(7, 175);
			textBoxThirdQuestion.Name = "textBoxThirdQuestion";
			textBoxThirdQuestion.PlaceholderText = "Третий вариант ответа";
			textBoxThirdQuestion.Size = new Size(374, 29);
			textBoxThirdQuestion.TabIndex = 6;

			tabPage.Controls.Add(textBoxThirdQuestion);

			textBoxFourthQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFourthQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFourthQuestion.ForeColor = Color.White;
            textBoxFourthQuestion.Location = new Point(7, 217);
			textBoxFourthQuestion.Name = "textBoxFourthQuestion";
			textBoxFourthQuestion.PlaceholderText = "Четвертый вариант ответа";
			textBoxFourthQuestion.Size = new Size(374, 29);
			textBoxFourthQuestion.TabIndex = 7;

			tabPage.Controls.Add(textBoxFourthQuestion);

			textBoxFifthQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFifthQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFifthQuestion.ForeColor = Color.White;
            textBoxFifthQuestion.Location = new Point(7, 256);
			textBoxFifthQuestion.Name = "textBoxFifthQuestion";
			textBoxFifthQuestion.PlaceholderText = "Пятый вариант ответа";
			textBoxFifthQuestion.Size = new Size(374, 29);
			textBoxFifthQuestion.TabIndex = 8;

			tabPage.Controls.Add(textBoxFifthQuestion);

			return tabPage;
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

		private void buttonCreate_Click(object sender, EventArgs e)
		{
            List<TreeNode> nodes = new List<TreeNode>();

			if (textBoxName.Text == "")
			{
				showError("Введите название теста");
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
				showError("Выберите уровень теста");
                return;
			}

            //Проверяем, создаем ли мы тест с названием которое уже существует,
            //Если существует, то дописываем его
            //Если нет то создаем новый


			//Не дает дописать тест
            foreach (var node in TreeNode.tests)
            {
                if (textBoxName.Text == node.ID && node.GetChild(level) == null)
                {
                    testWrapper = node;
                    exists = true;
                }
                else if (textBoxName.Text == node.ID && node.GetChild(level) != null)
                {
                    showError("Тест с таким именем и уровнем уже существует");
                    return;
                }
            }

            if (testWrapper == null)
			{
                testWrapper = new TreeNode(textBoxName.Text)
                {

                };
            }



            TreeNode levelWrapper = new TreeNode(level)
            { };

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
				} else
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

			TreeNode sameSubject = new TreeNode("");

            foreach (var node in TreeNode.tests)
            {
                if (textBoxName.Text == node.ID)
                {
					sameSubject = node;
                }
            }

			if (exists == false)
			{
                TreeNode.addTest(testWrapper);
            } else
			{
				TreeNode.tests.Remove(sameSubject);
                TreeNode.addTest(testWrapper);
            }

            isClosedByUser = false;
            this.Close();
        }
	}
}


/*
Минимум 5 вопросов из полей: 
	должны быть заполнены минимум 2 поля
	необязательно заполнять все 5 полей
	если они все не будут заполнены, то выводить ошибку 
	Колво вопросов в будет определяться по колву заполненных полей

На каждой вкладке должен быть выпадающий список:
	Первый элемент - надпись checkBox
	Второй элемент - надпись radioButton
	
Две кнопки:
	Перейти к след вопросу
	Перейти к пред вопросу

Напротив каждого поля checkbox
	Если выбран в списке checkbox то тикнутых вариантов может быть мининмум 1 и максимум все вопросы
	Если выбран radiobutton то максимум может быть тикнут 1 чекбокс
	Если что-то выше произойдет, то на следующий вопрос перейти будет нельзя

Создать проверку существует ли уже такое название теста

Нужно будет при нажимании кнопки Создать тест вызывать 2 форму с конструктором, через который мы опрокинем новый TreeNode,
и добавляет новую опцию 

Во вторрой форме обрабатывать исключение, при котором можно выбрать предмет с уровнем, который еще не существует 
(либо создать зависимость и выводить варианты уровня в зависимости от выбранного предмета)

Исключения:
Когда по тесту есть все уровни и мы создаем новый
Когда создаем тест с уже существующим названием и существующим уровнем
 */