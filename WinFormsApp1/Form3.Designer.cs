using System.Windows.Forms;

namespace WinFormsApp1
{
    partial class Form3
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
            mainInfoLabel = new Label();
            resultButton = new Button();
            testingTab = new TabControl();
            gradeLabel = new Label();
            SuspendLayout();
            // 
            // mainInfoLabel
            // 
            mainInfoLabel.AutoSize = true;
            mainInfoLabel.Font = new Font("Segoe UI", 14F);
            mainInfoLabel.Location = new Point(589, 53);
            mainInfoLabel.Name = "mainInfoLabel";
            mainInfoLabel.Size = new Size(176, 25);
            mainInfoLabel.TabIndex = 2;
            mainInfoLabel.Text = "Название, уровень";
            mainInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultButton
            // 
            resultButton.BackColor = Color.White;
            resultButton.Font = new Font("Segoe UI", 14F);
            resultButton.Location = new Point(589, 338);
            resultButton.Name = "resultButton";
            resultButton.Size = new Size(199, 53);
            resultButton.TabIndex = 3;
            resultButton.Text = "Завершить тест";
            resultButton.UseVisualStyleBackColor = false;
            resultButton.Click += resultButton_Click;
            // 
            // testingTab
            // 
            testingTab.Location = new Point(0, -2);
            testingTab.Name = "testingTab";
            testingTab.SelectedIndex = 0;
            testingTab.Size = new Size(572, 455);
            testingTab.TabIndex = 1;
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Font = new Font("Segoe UI", 11F);
            gradeLabel.Location = new Point(661, 185);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(0, 20);
            gradeLabel.TabIndex = 4;
            gradeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(gradeLabel);
            Controls.Add(resultButton);
            Controls.Add(mainInfoLabel);
            Controls.Add(testingTab);
            Name = "Form3";
            Text = "Form3";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mainInfoLabel;
        private Button resultButton;
        private TabControl testingTab;
        private Label gradeLabel;
        private Button button1;
    }
}