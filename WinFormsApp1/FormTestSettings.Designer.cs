namespace WinFormsApp1
{
    partial class FormTestSettings
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
            components = new System.ComponentModel.Container();
            nextButton = new Button();
            labelChooseSubject = new Label();
            labelChooseLevel = new Label();
            comboBoxSubjects = new ComboBox();
            addTestButton = new Button();
            testToolTip = new ToolTip(components);
            buttonResults = new Button();
            buttonEditTest = new Button();
            radioButtonFirstLevel = new RadioButton();
            radioButtonSecondLevel = new RadioButton();
            radioButtonThirdLevel = new RadioButton();
            panelLevels = new Panel();
            panelLevels.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.FromArgb(150, 73, 244);
            nextButton.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            nextButton.FlatStyle = FlatStyle.Flat;
            nextButton.Font = new Font("Segoe UI", 16F);
            nextButton.Location = new Point(325, 339);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(155, 51);
            nextButton.TabIndex = 4;
            nextButton.Text = "Далее";
            testToolTip.SetToolTip(nextButton, "Пройти тест");
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // labelChooseSubject
            // 
            labelChooseSubject.AutoSize = true;
            labelChooseSubject.Font = new Font("Segoe UI", 16F);
            labelChooseSubject.Location = new Point(253, 24);
            labelChooseSubject.Name = "labelChooseSubject";
            labelChooseSubject.Size = new Size(299, 30);
            labelChooseSubject.TabIndex = 2;
            labelChooseSubject.Text = "Выберите нужный предмет:";
            // 
            // labelChooseLevel
            // 
            labelChooseLevel.AutoSize = true;
            labelChooseLevel.Font = new Font("Segoe UI", 16F);
            labelChooseLevel.Location = new Point(297, 161);
            labelChooseLevel.Name = "labelChooseLevel";
            labelChooseLevel.Size = new Size(210, 30);
            labelChooseLevel.TabIndex = 6;
            labelChooseLevel.Text = "Выберите уровень:";
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.BackColor = Color.FromArgb(25, 27, 39);
            comboBoxSubjects.FlatStyle = FlatStyle.Flat;
            comboBoxSubjects.Font = new Font("Segoe UI", 16F);
            comboBoxSubjects.ForeColor = Color.White;
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new Point(329, 95);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(146, 38);
            comboBoxSubjects.TabIndex = 0;
            // 
            // addTestButton
            // 
            addTestButton.BackColor = Color.FromArgb(150, 73, 244);
            addTestButton.BackgroundImageLayout = ImageLayout.None;
            addTestButton.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            addTestButton.FlatStyle = FlatStyle.Flat;
            addTestButton.Font = new Font("Segoe UI", 16F);
            addTestButton.Location = new Point(719, 12);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(69, 54);
            addTestButton.TabIndex = 8;
            addTestButton.Text = "➕";
            testToolTip.SetToolTip(addTestButton, "Создать новый тест");
            addTestButton.UseVisualStyleBackColor = false;
            addTestButton.Click += addTestButton_Click;
            // 
            // buttonResults
            // 
            buttonResults.BackColor = Color.FromArgb(150, 73, 244);
            buttonResults.BackgroundImageLayout = ImageLayout.None;
            buttonResults.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonResults.FlatStyle = FlatStyle.Flat;
            buttonResults.Font = new Font("Segoe UI", 16F);
            buttonResults.Location = new Point(12, 12);
            buttonResults.Name = "buttonResults";
            buttonResults.Size = new Size(141, 54);
            buttonResults.TabIndex = 9;
            buttonResults.Text = "Результаты";
            testToolTip.SetToolTip(buttonResults, "Просмотреть результаты");
            buttonResults.UseVisualStyleBackColor = false;
            buttonResults.Click += buttonResults_Click;
            // 
            // buttonEditTest
            // 
            buttonEditTest.BackColor = Color.FromArgb(150, 73, 244);
            buttonEditTest.BackgroundImageLayout = ImageLayout.None;
            buttonEditTest.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonEditTest.FlatStyle = FlatStyle.Flat;
            buttonEditTest.Font = new Font("Segoe UI", 16F);
            buttonEditTest.Location = new Point(719, 79);
            buttonEditTest.Name = "buttonEditTest";
            buttonEditTest.Size = new Size(69, 54);
            buttonEditTest.TabIndex = 10;
            buttonEditTest.Text = "EDIT";
            testToolTip.SetToolTip(buttonEditTest, "Редактировать выбранный тест");
            buttonEditTest.UseVisualStyleBackColor = false;
            buttonEditTest.Click += buttonEditTest_Click;
            // 
            // radioButtonFirstLevel
            // 
            radioButtonFirstLevel.AutoSize = true;
            radioButtonFirstLevel.Font = new Font("Segoe UI", 16F);
            radioButtonFirstLevel.Location = new Point(7, 1);
            radioButtonFirstLevel.Name = "radioButtonFirstLevel";
            radioButtonFirstLevel.Size = new Size(134, 34);
            radioButtonFirstLevel.TabIndex = 1;
            radioButtonFirstLevel.TabStop = true;
            radioButtonFirstLevel.Text = "1 уровень";
            radioButtonFirstLevel.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecondLevel
            // 
            radioButtonSecondLevel.AutoSize = true;
            radioButtonSecondLevel.Font = new Font("Segoe UI", 16F);
            radioButtonSecondLevel.Location = new Point(7, 33);
            radioButtonSecondLevel.Name = "radioButtonSecondLevel";
            radioButtonSecondLevel.Size = new Size(134, 34);
            radioButtonSecondLevel.TabIndex = 2;
            radioButtonSecondLevel.TabStop = true;
            radioButtonSecondLevel.Text = "2 уровень";
            radioButtonSecondLevel.UseVisualStyleBackColor = true;
            // 
            // radioButtonThirdLevel
            // 
            radioButtonThirdLevel.AutoSize = true;
            radioButtonThirdLevel.Font = new Font("Segoe UI", 16F);
            radioButtonThirdLevel.Location = new Point(7, 67);
            radioButtonThirdLevel.Name = "radioButtonThirdLevel";
            radioButtonThirdLevel.Size = new Size(134, 34);
            radioButtonThirdLevel.TabIndex = 3;
            radioButtonThirdLevel.TabStop = true;
            radioButtonThirdLevel.Text = "3 уровень";
            radioButtonThirdLevel.UseVisualStyleBackColor = true;
            // 
            // panelLevels
            // 
            panelLevels.Controls.Add(radioButtonThirdLevel);
            panelLevels.Controls.Add(radioButtonSecondLevel);
            panelLevels.Controls.Add(radioButtonFirstLevel);
            panelLevels.Location = new Point(327, 203);
            panelLevels.Name = "panelLevels";
            panelLevels.Size = new Size(146, 114);
            panelLevels.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 27, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEditTest);
            Controls.Add(buttonResults);
            Controls.Add(addTestButton);
            Controls.Add(comboBoxSubjects);
            Controls.Add(panelLevels);
            Controls.Add(labelChooseLevel);
            Controls.Add(labelChooseSubject);
            Controls.Add(nextButton);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выбор параметров теста";
            panelLevels.ResumeLayout(false);
            panelLevels.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button nextButton;
        //private ListBox listBox1;
        private Label labelChooseSubject;
        private CheckedListBox checkedListBox1;
        private Label labelChooseLevel;
        private ComboBox comboBoxSubjects;
        private Button addTestButton;
        private ToolTip testToolTip;
        private RadioButton radioButtonFirstLevel;
        private RadioButton radioButtonSecondLevel;
        private RadioButton radioButtonThirdLevel;
        private Panel panelLevels;
        private Button buttonResults;
        private Button buttonEditTest;
    }
}