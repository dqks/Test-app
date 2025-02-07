using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class FormEditTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testingTab = new TabControl();
            tabPageTesting = new TabPage();
            textBoxQuestionName = new TextBox();
            buttonNextQuestion = new Button();
            buttonPreviousQuestion = new Button();
            checkBoxIsTrueFirst = new CheckBox();
            checkBoxIsTrueSecond = new CheckBox();
            checkBoxIsTrueThird = new CheckBox();
            checkBoxIsTrueFourth = new CheckBox();
            checkBoxIsTrueFifth = new CheckBox();
            textBoxFirstQuestion = new TextBox();
            textBoxSecondQuestion = new TextBox();
            textBoxThirdQuestion = new TextBox();
            textBoxFourthQuestion = new TextBox();
            textBoxFifthQuestion = new TextBox();
            comboBoxChooseTypeOfAnswer = new ComboBox();
            buttonDeleteQuestion = new Button();
            buttonAddQuestion = new Button();
            buttonEdit = new Button();
            labelTestName = new Label();
            buttonDeleteTest = new Button();
            testingTab.SuspendLayout();
            tabPageTesting.SuspendLayout();
            SuspendLayout();
            // 
            // testingTab
            // 
            testingTab.Controls.Add(tabPageTesting);
            testingTab.Location = new Point(-7, -2);
            testingTab.Name = "testingTab";
            testingTab.SelectedIndex = 0;
            testingTab.Size = new Size(582, 460);
            testingTab.TabIndex = 2;
            // 
            // tabPageTesting
            // 
            tabPageTesting.BackColor = Color.FromArgb(25, 27, 39);
            tabPageTesting.Controls.Add(textBoxQuestionName);
            tabPageTesting.Controls.Add(buttonNextQuestion);
            tabPageTesting.Controls.Add(buttonPreviousQuestion);
            tabPageTesting.Controls.Add(checkBoxIsTrueFirst);
            tabPageTesting.Controls.Add(checkBoxIsTrueSecond);
            tabPageTesting.Controls.Add(checkBoxIsTrueThird);
            tabPageTesting.Controls.Add(checkBoxIsTrueFourth);
            tabPageTesting.Controls.Add(checkBoxIsTrueFifth);
            tabPageTesting.Controls.Add(textBoxFirstQuestion);
            tabPageTesting.Controls.Add(textBoxSecondQuestion);
            tabPageTesting.Controls.Add(textBoxThirdQuestion);
            tabPageTesting.Controls.Add(textBoxFourthQuestion);
            tabPageTesting.Controls.Add(textBoxFifthQuestion);
            tabPageTesting.Controls.Add(comboBoxChooseTypeOfAnswer);
            tabPageTesting.Controls.Add(buttonDeleteQuestion);
            tabPageTesting.Controls.Add(buttonAddQuestion);
            tabPageTesting.Location = new Point(4, 24);
            tabPageTesting.Name = "tabPageTesting";
            tabPageTesting.Size = new Size(574, 432);
            tabPageTesting.TabIndex = 0;
            tabPageTesting.Text = "1 вопрос";
            // 
            // textBoxQuestionName
            // 
            textBoxQuestionName.BackColor = Color.FromArgb(25, 27, 39);
            textBoxQuestionName.Font = new Font("Segoe UI", 12F);
            textBoxQuestionName.ForeColor = Color.White;
            textBoxQuestionName.Location = new Point(7, 12);
            textBoxQuestionName.Name = "textBoxQuestionName";
            textBoxQuestionName.PlaceholderText = "Вопрос";
            textBoxQuestionName.Size = new Size(365, 29);
            textBoxQuestionName.TabIndex = 16;
            // 
            // buttonNextQuestion
            // 
            buttonNextQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonNextQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonNextQuestion.FlatStyle = FlatStyle.Flat;
            buttonNextQuestion.Font = new Font("Segoe UI", 12F);
            buttonNextQuestion.ForeColor = Color.White;
            buttonNextQuestion.Location = new Point(190, 352);
            buttonNextQuestion.Name = "buttonNextQuestion";
            buttonNextQuestion.Size = new Size(162, 36);
            buttonNextQuestion.TabIndex = 15;
            buttonNextQuestion.Text = "Далее";
            buttonNextQuestion.UseVisualStyleBackColor = false;
            buttonNextQuestion.Click += buttonNextQuestion_Click;
            // 
            // buttonPreviousQuestion
            // 
            buttonPreviousQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonPreviousQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonPreviousQuestion.FlatStyle = FlatStyle.Flat;
            buttonPreviousQuestion.Font = new Font("Segoe UI", 12F);
            buttonPreviousQuestion.ForeColor = Color.White;
            buttonPreviousQuestion.Location = new Point(7, 352);
            buttonPreviousQuestion.Name = "buttonPreviousQuestion";
            buttonPreviousQuestion.Size = new Size(162, 36);
            buttonPreviousQuestion.TabIndex = 14;
            buttonPreviousQuestion.Text = "Назад";
            buttonPreviousQuestion.UseVisualStyleBackColor = false;
            buttonPreviousQuestion.Click += buttonPreviousQuestion_Click;
            // 
            // checkBoxIsTrueFirst
            // 
            checkBoxIsTrueFirst.AutoSize = true;
            checkBoxIsTrueFirst.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueFirst.ForeColor = Color.Black;
            checkBoxIsTrueFirst.Location = new Point(525, 92);
            checkBoxIsTrueFirst.Name = "checkBoxIsTrueFirst";
            checkBoxIsTrueFirst.Size = new Size(15, 14);
            checkBoxIsTrueFirst.TabIndex = 9;
            checkBoxIsTrueFirst.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsTrueSecond
            // 
            checkBoxIsTrueSecond.AutoSize = true;
            checkBoxIsTrueSecond.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueSecond.Location = new Point(525, 138);
            checkBoxIsTrueSecond.Name = "checkBoxIsTrueSecond";
            checkBoxIsTrueSecond.Size = new Size(15, 14);
            checkBoxIsTrueSecond.TabIndex = 10;
            checkBoxIsTrueSecond.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsTrueThird
            // 
            checkBoxIsTrueThird.AutoSize = true;
            checkBoxIsTrueThird.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueThird.Location = new Point(525, 182);
            checkBoxIsTrueThird.Name = "checkBoxIsTrueThird";
            checkBoxIsTrueThird.Size = new Size(15, 14);
            checkBoxIsTrueThird.TabIndex = 11;
            checkBoxIsTrueThird.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsTrueFourth
            // 
            checkBoxIsTrueFourth.AutoSize = true;
            checkBoxIsTrueFourth.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueFourth.Location = new Point(525, 224);
            checkBoxIsTrueFourth.Name = "checkBoxIsTrueFourth";
            checkBoxIsTrueFourth.Size = new Size(15, 14);
            checkBoxIsTrueFourth.TabIndex = 12;
            checkBoxIsTrueFourth.UseVisualStyleBackColor = true;
            // 
            // checkBoxIsTrueFifth
            // 
            checkBoxIsTrueFifth.AutoSize = true;
            checkBoxIsTrueFifth.Font = new Font("Segoe UI", 12F);
            checkBoxIsTrueFifth.Location = new Point(525, 263);
            checkBoxIsTrueFifth.Name = "checkBoxIsTrueFifth";
            checkBoxIsTrueFifth.Size = new Size(15, 14);
            checkBoxIsTrueFifth.TabIndex = 13;
            checkBoxIsTrueFifth.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstQuestion
            // 
            textBoxFirstQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFirstQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxFirstQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFirstQuestion.ForeColor = Color.White;
            textBoxFirstQuestion.Location = new Point(7, 85);
            textBoxFirstQuestion.Name = "textBoxFirstQuestion";
            textBoxFirstQuestion.PlaceholderText = "Первый вариант ответа";
            textBoxFirstQuestion.Size = new Size(496, 29);
            textBoxFirstQuestion.TabIndex = 4;
            // 
            // textBoxSecondQuestion
            // 
            textBoxSecondQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxSecondQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxSecondQuestion.Font = new Font("Segoe UI", 12F);
            textBoxSecondQuestion.ForeColor = Color.White;
            textBoxSecondQuestion.Location = new Point(7, 131);
            textBoxSecondQuestion.Name = "textBoxSecondQuestion";
            textBoxSecondQuestion.PlaceholderText = "Второй вариант ответа";
            textBoxSecondQuestion.Size = new Size(496, 29);
            textBoxSecondQuestion.TabIndex = 5;
            // 
            // textBoxThirdQuestion
            // 
            textBoxThirdQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxThirdQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxThirdQuestion.Font = new Font("Segoe UI", 12F);
            textBoxThirdQuestion.ForeColor = Color.White;
            textBoxThirdQuestion.Location = new Point(7, 175);
            textBoxThirdQuestion.Name = "textBoxThirdQuestion";
            textBoxThirdQuestion.PlaceholderText = "Третий вариант ответа";
            textBoxThirdQuestion.Size = new Size(496, 29);
            textBoxThirdQuestion.TabIndex = 6;
            // 
            // textBoxFourthQuestion
            // 
            textBoxFourthQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFourthQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxFourthQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFourthQuestion.ForeColor = Color.White;
            textBoxFourthQuestion.Location = new Point(7, 217);
            textBoxFourthQuestion.Name = "textBoxFourthQuestion";
            textBoxFourthQuestion.PlaceholderText = "Четвертый вариант ответа";
            textBoxFourthQuestion.Size = new Size(496, 29);
            textBoxFourthQuestion.TabIndex = 7;
            // 
            // textBoxFifthQuestion
            // 
            textBoxFifthQuestion.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFifthQuestion.BorderStyle = BorderStyle.FixedSingle;
            textBoxFifthQuestion.Font = new Font("Segoe UI", 12F);
            textBoxFifthQuestion.ForeColor = Color.White;
            textBoxFifthQuestion.Location = new Point(7, 256);
            textBoxFifthQuestion.Name = "textBoxFifthQuestion";
            textBoxFifthQuestion.PlaceholderText = "Пятый вариант ответа";
            textBoxFifthQuestion.Size = new Size(496, 29);
            textBoxFifthQuestion.TabIndex = 8;
            // 
            // comboBoxChooseTypeOfAnswer
            // 
            comboBoxChooseTypeOfAnswer.BackColor = Color.FromArgb(25, 27, 39);
            comboBoxChooseTypeOfAnswer.FlatStyle = FlatStyle.Flat;
            comboBoxChooseTypeOfAnswer.Font = new Font("Segoe UI", 12F);
            comboBoxChooseTypeOfAnswer.ForeColor = Color.White;
            comboBoxChooseTypeOfAnswer.FormattingEnabled = true;
            comboBoxChooseTypeOfAnswer.Items.AddRange(new object[] { "Радио кнопка", "Чекбокс" });
            comboBoxChooseTypeOfAnswer.Location = new Point(378, 12);
            comboBoxChooseTypeOfAnswer.Name = "comboBoxChooseTypeOfAnswer";
            comboBoxChooseTypeOfAnswer.RightToLeft = RightToLeft.No;
            comboBoxChooseTypeOfAnswer.Size = new Size(177, 29);
            comboBoxChooseTypeOfAnswer.TabIndex = 3;
            comboBoxChooseTypeOfAnswer.Text = "Выберите тип ответа";
            // 
            // buttonDeleteQuestion
            // 
            buttonDeleteQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonDeleteQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonDeleteQuestion.FlatStyle = FlatStyle.Flat;
            buttonDeleteQuestion.Font = new Font("Segoe UI", 12F);
            buttonDeleteQuestion.ForeColor = Color.White;
            buttonDeleteQuestion.Location = new Point(378, 374);
            buttonDeleteQuestion.Name = "buttonDeleteQuestion";
            buttonDeleteQuestion.Size = new Size(162, 36);
            buttonDeleteQuestion.TabIndex = 1;
            buttonDeleteQuestion.Text = "Удалить вопрос";
            buttonDeleteQuestion.UseVisualStyleBackColor = false;
            buttonDeleteQuestion.Click += buttonDeleteQuestion_Click;
            // 
            // buttonAddQuestion
            // 
            buttonAddQuestion.BackColor = Color.FromArgb(150, 73, 244);
            buttonAddQuestion.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonAddQuestion.FlatStyle = FlatStyle.Flat;
            buttonAddQuestion.Font = new Font("Segoe UI", 12F);
            buttonAddQuestion.ForeColor = Color.White;
            buttonAddQuestion.Location = new Point(378, 332);
            buttonAddQuestion.Name = "buttonAddQuestion";
            buttonAddQuestion.Size = new Size(162, 36);
            buttonAddQuestion.TabIndex = 0;
            buttonAddQuestion.Text = "Добавить вопрос";
            buttonAddQuestion.UseVisualStyleBackColor = false;
            buttonAddQuestion.Click += buttonAddQuestion_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.FromArgb(150, 73, 244);
            buttonEdit.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.Font = new Font("Segoe UI", 16F);
            buttonEdit.ForeColor = Color.White;
            buttonEdit.Location = new Point(582, 278);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(212, 82);
            buttonEdit.TabIndex = 4;
            buttonEdit.Text = "Завершить редактирование";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // labelTestName
            // 
            labelTestName.AutoSize = true;
            labelTestName.Font = new Font("Segoe UI", 16F);
            labelTestName.ForeColor = SystemColors.Control;
            labelTestName.Location = new Point(582, 22);
            labelTestName.Name = "labelTestName";
            labelTestName.Size = new Size(168, 30);
            labelTestName.TabIndex = 5;
            labelTestName.Text = "Название теста";
            // 
            // buttonDeleteTest
            // 
            buttonDeleteTest.BackColor = Color.FromArgb(150, 73, 244);
            buttonDeleteTest.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonDeleteTest.FlatStyle = FlatStyle.Flat;
            buttonDeleteTest.Font = new Font("Segoe UI", 16F);
            buttonDeleteTest.ForeColor = Color.White;
            buttonDeleteTest.Location = new Point(582, 376);
            buttonDeleteTest.Name = "buttonDeleteTest";
            buttonDeleteTest.Size = new Size(212, 56);
            buttonDeleteTest.TabIndex = 8;
            buttonDeleteTest.Text = "Удалить тест";
            buttonDeleteTest.UseVisualStyleBackColor = false;
            buttonDeleteTest.Click += buttonDeleteTest_Click;
            // 
            // FormEditTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 27, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteTest);
            Controls.Add(labelTestName);
            Controls.Add(buttonEdit);
            Controls.Add(testingTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormEditTest";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Редактирование теста";
            FormClosing += FormEditTest_FormClosing;
            Load += FormEditTest_Load;
            testingTab.ResumeLayout(false);
            tabPageTesting.ResumeLayout(false);
            tabPageTesting.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl testingTab;
        private TabPage tabPageTesting;
        private Button buttonEdit;
        private Label labelTestName;
        private Button buttonAddQuestion;
        private Button buttonDeleteQuestion;
        private ComboBox comboBoxChooseTypeOfAnswer;
        private TextBox textBoxFifthQuestion;
        private TextBox textBoxFourthQuestion;
        private TextBox textBoxThirdQuestion;
        private TextBox textBoxSecondQuestion;
        private TextBox textBoxFirstQuestion;
        private CheckBox checkBoxIsTrueFirst;
        private CheckBox checkBoxIsTrueFifth;
        private CheckBox checkBoxIsTrueFourth;
        private CheckBox checkBoxIsTrueThird;
        private CheckBox checkBoxIsTrueSecond;
        private Button buttonNextQuestion;
        private Button buttonPreviousQuestion;
        private TextBox textBoxQuestionName;
        private Button buttonDeleteTest;
    }
}