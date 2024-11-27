namespace WinFormsApp1
{
    partial class createTestForm
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
            tabPage1 = new TabPage();
            panel1 = new Panel();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            resultButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            testingTab.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // testingTab
            // 
            testingTab.Controls.Add(tabPage1);
            testingTab.Location = new Point(1, -2);
            testingTab.Name = "testingTab";
            testingTab.SelectedIndex = 0;
            testingTab.Size = new Size(572, 455);
            testingTab.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(564, 427);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "1 вопрос";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(614, 221);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 100);
            panel1.TabIndex = 3;
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
            // resultButton
            // 
            resultButton.BackColor = Color.White;
            resultButton.Font = new Font("Segoe UI", 14F);
            resultButton.Location = new Point(581, 354);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(212, 56);
            resultButton.TabIndex = 4;
            resultButton.Text = "Завершить создание";
            resultButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(601, 22);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 5;
            label1.Text = "Введите название:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F);
            textBox1.Location = new Point(614, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(146, 32);
            textBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(642, 153);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 7;
            label2.Text = "Уровень:";
            // 
            // createTestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(resultButton);
            Controls.Add(panel1);
            Controls.Add(testingTab);
            Name = "createTestForm";
            Text = "Form4";
            testingTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl testingTab;
        private TabPage tabPage1;
        private Panel panel1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button resultButton;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}