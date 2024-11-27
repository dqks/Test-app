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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ComboBox();
            addTestButton = new Button();
            testToolTip = new ToolTip(components);
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            panel1 = new Panel();
            panel1.SuspendLayout();
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
            nextButton.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(303, 19);
            label1.Name = "label1";
            label1.Size = new Size(210, 21);
            label1.TabIndex = 2;
            label1.Text = "Выберите нужный предмет:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(327, 167);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 6;
            label2.Text = "Выберите уровень:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(303, 397);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.White;
            listBox1.Font = new Font("Segoe UI", 12F);
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "ООП", "C#", "C++", "JavaScript" });
            listBox1.Location = new Point(327, 95);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(146, 29);
            listBox1.TabIndex = 0;
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
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Segoe UI", 12F);
            radioButton1.Location = new Point(24, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 25);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "1 уровень";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Segoe UI", 12F);
            radioButton2.Location = new Point(24, 39);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 25);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "2 уровень";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Segoe UI", 12F);
            radioButton3.Location = new Point(24, 66);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 25);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "3 уровень";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(327, 208);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 100);
            panel1.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(addTestButton);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nextButton);
            Name = "Form2";
            Text = "Выбор параметров теста";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button nextButton;
        //private ListBox listBox1;
        private Label label1;
        private CheckedListBox checkedListBox1;
        private Label label2;
        private Label label3;
        private ComboBox listBox1;
        private Button addTestButton;
        private ToolTip testToolTip;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Panel panel1;
    }
}