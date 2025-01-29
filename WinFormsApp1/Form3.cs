using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.TabPage;


namespace WinFormsApp1
{
	public partial class Form3 : Form
	{
		private string subject;
		private string level;
		private TreeNode child;
		private ArrayList rightAnswers = new ArrayList();
		private bool isClosedByUser = true;
		public Form3()
		{
			InitializeComponent();
		}


		private void Form3_FormClosing(Object sender, FormClosingEventArgs e)
		{
			if (isClosedByUser == false)
			{
				Form2 form2 = new Form2();
				form2.Show();
			} else
			{
				switch (MessageBox.Show(this,
					"Вы действительно хотите закрыть форму?\nВесь пройденный прогресс не будет сохранен",
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

		public Form3(string subject, string level, TreeNode child)
		{
			InitializeComponent();
			this.subject = subject;
			this.level = level;
			this.child = child;
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			mainInfoLabel.Text = subject + ", " + level;

   //         List<TreeNode> subjects = TreeNode.tests; //Получаем массив из всех деревьев
   //         TreeNode child = new TreeNode("");

   //         try
   //         {
   //             foreach (TreeNode node in subjects)
   //             {
   //                 if (node.ID == subject)
   //                 {
   //                     child = node.GetChild(level);// Получаем блок вопросов по ключу
   //                                                  // уровня сложности по выбранному предмету
   //                 }
   //             }
   //         }
			//catch
			//{
			//	return;
			//}


            IEnumerator<TreeNode> questions = child.GetEnumerator(); //получаем все вопросы
			TreeNode answers;

			int questionNum = 1;
			int startAnswerPos = 88;
			int distanceBetweenAnswers = 45;
			while (questions.MoveNext()) // двигаемся по всем вопросам
			{
				//Создание вкладки вопроса
				TabPage newTabPage = new TabPage();
                newTabPage.BackColor = Color.FromArgb(25, 27, 39);
				newTabPage.Text = questionNum++ + " вопрос";

				//Создание кнопки "Далее"
				Button backButton = new Button();
				backButton.Click += backButton_Click;
				backButton.Text = "Назад";
				backButton.Font = new Font("Segoe UI", 12F);
				backButton.Location = new Point(45, 335);
				backButton.Size = new Size(93, 34);
                backButton.BackColor = Color.FromArgb(150, 73, 244);
                backButton.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
                backButton.FlatStyle = FlatStyle.Flat;
				backButton.ForeColor = Color.White;
                newTabPage.Controls.Add(backButton);

                //Создание кнопки "Назад"
                Button nextButton = new Button();
				nextButton.Click += nextButton_Click;
				nextButton.Text = "Далее";
				nextButton.Font = new Font("Segoe UI", 12F);
				nextButton.Location = new Point(184, 335);
				nextButton.Size = new Size(93, 34);
                nextButton.BackColor = Color.FromArgb(150, 73, 244);
                nextButton.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
                nextButton.FlatStyle = FlatStyle.Flat;
                nextButton.ForeColor = Color.White;
                newTabPage.Controls.Add(nextButton);

				//Создание текста вопроса
				System.Windows.Forms.Label questionLabel = new System.Windows.Forms.Label();
				questionLabel.Text = questions.Current.ID.Replace("RADIO", "").Replace("CHECKBOX", "");
				questionLabel.Font = new Font("Segoe UI", 10F);
				questionLabel.Location = new Point(45, 31);
				questionLabel.Size = new Size(498, 50);
                questionLabel.ForeColor = Color.White;
                newTabPage.Controls.Add(questionLabel);

				//Задаем вопросы

				answers = child.GetChild(questions.Current.ID); // получаем деревья ответов
				IEnumerator<TreeNode> variants = answers.GetEnumerator(); //получаем все варианты ответа к вопросам
				while (variants.MoveNext()) //двигаемся по вариантам ответа к вопросу и добавляем их
				{
					var answerVariant = new Control();
					if (questions.Current.ID.Contains("RADIO"))
					{
						answerVariant = new RadioButton();
					}
					else if (questions.Current.ID.Contains("CHECKBOX"))
					{
						answerVariant = new CheckBox();
					}

					if (variants.Current.ID.Contains("TRUE"))
					{
						rightAnswers.Add(variants.Current.ID.Replace("TRUE", ""));
					}

					answerVariant.Font = new Font("Segoe UI", 10F);
					answerVariant.Location = new Point(45, startAnswerPos);
					answerVariant.Size = new Size(498, 50);
                    answerVariant.ForeColor =Color.White;
                    answerVariant.Text = variants.Current.ID.Replace("TRUE", "");
					newTabPage.Controls.Add(answerVariant);

					startAnswerPos += distanceBetweenAnswers;
				}

				startAnswerPos = 88;
				distanceBetweenAnswers = 45;
				testingTab.TabPages.Add(newTabPage);
			}
		}

		private void nextButton_Click(object sender, EventArgs e)
		{
			int index = testingTab.SelectedIndex;

			if (index + 1 < testingTab.TabCount)
			{
				index++;
			}

			testingTab.SelectedIndex = index;
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			int index = testingTab.SelectedIndex;

			if (index - 1 >= 0)
			{
				index--;
			}

			testingTab.SelectedIndex = index;
		}

		private void resultButton_Click(object sender, EventArgs e)
		{
			//Получаем все страницы вопросов
			var tabs = testingTab.GetAllNestedControls().OfType<TabPage>();
			bool isChecked;
			foreach (var tab in tabs)
			{
				var questionsRadioButton = tab.GetAllNestedControls().OfType<RadioButton>().ToList();
                var questionsCheckBox = tab.GetAllNestedControls().OfType<CheckBox>().ToList();
                isChecked = false;
                if (questionsRadioButton.Count > 0)
				{
                    foreach (var question in questionsRadioButton)
                    {
                        if (question.Checked)
                        {
                            isChecked = true;
                        }
                    }

                } else if (questionsCheckBox.Count > 0)
				{

                    foreach (var question in questionsCheckBox)
                    {
                        if (question.Checked)
                        {
                            isChecked = true;
                        }
                    }

                }

                if (isChecked == false)
                {
                    MessageBox.Show(
                        "Вы не ответили на все вопросы\nОтветьте на них, и вы сможете закончить тестирование",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
            }

			int countСheckedRightAnswers = 0;

			var radioButtons = testingTab.GetAllNestedControls().OfType<RadioButton>().ToList();
			var checkBoxes = testingTab.GetAllNestedControls().OfType<CheckBox>().ToList();

			foreach (RadioButton radioButton in radioButtons)
			{
				foreach (string rightAnswer in rightAnswers)
				{
					if (radioButton.Text == rightAnswer && radioButton.Checked)
					{
						countСheckedRightAnswers++;
					}
				}
			}

			foreach (CheckBox checkBox in checkBoxes)
			{
				foreach (string rightAnswer in rightAnswers)
				{
					if (checkBox.Text == rightAnswer && checkBox.Checked)
					{
						countСheckedRightAnswers++;
					}
				}
			}


            double result = Math.Round(countСheckedRightAnswers * 100.0 / rightAnswers.Count);
			int grade = 0;

			if (result < 50)
			{
				grade = 2;
			} else if (result >= 50 && result <= 74)
			{
				grade = 3;
			} else if (result >= 75 && result <= 89)
			{
				grade = 4;
			} else if (result >= 90 && result <= 100)
			{
				grade = 5;
			}

            MessageBox.Show(
				"Процент правильных ответов - " + result + "%" + "\nВаша оценка " + grade,
				"Результат",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information);
            isClosedByUser = false;
            this.Close();
        }
    }
}