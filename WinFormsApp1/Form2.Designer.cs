namespace WinFormsApp1
{
    partial class Form2
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
            labelError = new Label();
            comboBoxSubjects = new ComboBox();
            addTestButton = new Button();
            testToolTip = new ToolTip(components);
            radioButtonFirstLevel = new RadioButton();
            radioButtonSecondLevel = new RadioButton();
            radioButtonThirdLevel = new RadioButton();
            panelLevels = new Panel();
            panelLevels.SuspendLayout();
            SuspendLayout();
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.White;
            nextButton.Font = new Font("Segoe UI", 12F);
            nextButton.Location = new Point(323, 339);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(155, 40);
            nextButton.TabIndex = 4;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // labelChooseSubject
            // 
            labelChooseSubject.AutoSize = true;
            labelChooseSubject.Font = new Font("Segoe UI", 12F);
            labelChooseSubject.Location = new Point(303, 19);
            labelChooseSubject.Name = "labelChooseSubject";
            labelChooseSubject.Size = new Size(210, 21);
            labelChooseSubject.TabIndex = 2;
            labelChooseSubject.Text = "Выберите нужный предмет:";
            // 
            // labelChooseLevel
            // 
            labelChooseLevel.AutoSize = true;
            labelChooseLevel.Font = new Font("Segoe UI", 12F);
            labelChooseLevel.Location = new Point(327, 167);
            labelChooseLevel.Name = "labelChooseLevel";
            labelChooseLevel.Size = new Size(146, 21);
            labelChooseLevel.TabIndex = 6;
            labelChooseLevel.Text = "Выберите уровень:";
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 12F);
            labelError.Location = new Point(303, 397);
            labelError.Name = "labelError";
            labelError.Size = new Size(0, 21);
            labelError.TabIndex = 7;
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.BackColor = Color.White;
            comboBoxSubjects.Font = new Font("Segoe UI", 12F);
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new Point(327, 95);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(146, 29);
            comboBoxSubjects.TabIndex = 0;
            // 
            // addTestButton
            // 
            addTestButton.BackColor = Color.White;
            addTestButton.Font = new Font("Segoe UI", 14F);
            addTestButton.Location = new Point(749, 12);
            addTestButton.Name = "addTestButton";
            addTestButton.Size = new Size(39, 38);
            addTestButton.TabIndex = 8;
            addTestButton.Text = "➕";
            testToolTip.SetToolTip(addTestButton, "Создать новый тест");
            addTestButton.UseVisualStyleBackColor = false;
            addTestButton.Click += addTestButton_Click;
            // 
            // radioButtonFirstLevel
            // 
            radioButtonFirstLevel.AutoSize = true;
            radioButtonFirstLevel.Font = new Font("Segoe UI", 12F);
            radioButtonFirstLevel.Location = new Point(24, 12);
            radioButtonFirstLevel.Name = "radioButtonFirstLevel";
            radioButtonFirstLevel.Size = new Size(100, 25);
            radioButtonFirstLevel.TabIndex = 1;
            radioButtonFirstLevel.TabStop = true;
            radioButtonFirstLevel.Text = "1 уровень";
            radioButtonFirstLevel.UseVisualStyleBackColor = true;
            // 
            // radioButtonSecondLevel
            // 
            radioButtonSecondLevel.AutoSize = true;
            radioButtonSecondLevel.Font = new Font("Segoe UI", 12F);
            radioButtonSecondLevel.Location = new Point(24, 39);
            radioButtonSecondLevel.Name = "radioButtonSecondLevel";
            radioButtonSecondLevel.Size = new Size(100, 25);
            radioButtonSecondLevel.TabIndex = 2;
            radioButtonSecondLevel.TabStop = true;
            radioButtonSecondLevel.Text = "2 уровень";
            radioButtonSecondLevel.UseVisualStyleBackColor = true;
            // 
            // radioButtonThirdLevel
            // 
            radioButtonThirdLevel.AutoSize = true;
            radioButtonThirdLevel.Font = new Font("Segoe UI", 12F);
            radioButtonThirdLevel.Location = new Point(24, 66);
            radioButtonThirdLevel.Name = "radioButtonThirdLevel";
            radioButtonThirdLevel.Size = new Size(100, 25);
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
            panelLevels.Location = new Point(327, 208);
            panelLevels.Name = "panelLevels";
            panelLevels.Size = new Size(146, 100);
            panelLevels.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(addTestButton);
            Controls.Add(comboBoxSubjects);
            Controls.Add(panelLevels);
            Controls.Add(labelError);
            Controls.Add(labelChooseLevel);
            Controls.Add(labelChooseSubject);
            Controls.Add(nextButton);
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
        private Label labelError;
        private ComboBox comboBoxSubjects;
        private Button addTestButton;
        private ToolTip testToolTip;
        private RadioButton radioButtonFirstLevel;
        private RadioButton radioButtonSecondLevel;
        private RadioButton radioButtonThirdLevel;
        private Panel panelLevels;
    }
}