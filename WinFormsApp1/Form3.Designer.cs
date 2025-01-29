using System.Windows.Forms;
using System.Drawing;

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
            SuspendLayout();
            // 
            // mainInfoLabel
            // 
            mainInfoLabel.AutoSize = true;
            mainInfoLabel.Font = new Font("Segoe UI", 16F);
            mainInfoLabel.ForeColor = Color.White;
            mainInfoLabel.Location = new Point(580, 49);
            mainInfoLabel.Name = "mainInfoLabel";
            mainInfoLabel.Size = new Size(207, 30);
            mainInfoLabel.TabIndex = 2;
            mainInfoLabel.Text = "Название, уровень";
            mainInfoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // resultButton
            // 
            resultButton.BackColor = Color.FromArgb(150, 73, 244);
            resultButton.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            resultButton.FlatStyle = FlatStyle.Flat;
            resultButton.Font = new Font("Segoe UI", 14F);
            resultButton.ForeColor = Color.White;
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
            testingTab.Font = new Font("Segoe UI", 9F);
            testingTab.Location = new Point(-5, -2);
            testingTab.Name = "testingTab";
            testingTab.SelectedIndex = 0;
            testingTab.Size = new Size(577, 464);
            testingTab.TabIndex = 1;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 27, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(resultButton);
            Controls.Add(mainInfoLabel);
            Controls.Add(testingTab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тест";
            FormClosing += Form3_FormClosing;
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label mainInfoLabel;
        private Button resultButton;
        private TabControl testingTab;
        private Button button1;
    }
}