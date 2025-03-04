namespace WinFormsApp1
{
    partial class FormRegistration
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonNext = new Button();
            textBoxFullName = new TextBox();
            labelFullName = new Label();
            labelGroup = new Label();
            textBoxGroup = new TextBox();
            SuspendLayout();
            // 
            // buttonNext
            // 
            buttonNext.BackColor = Color.FromArgb(150, 73, 244);
            buttonNext.FlatAppearance.BorderColor = Color.FromArgb(150, 73, 244);
            buttonNext.FlatStyle = FlatStyle.Flat;
            buttonNext.Font = new Font("Segoe UI", 16F);
            buttonNext.ForeColor = Color.White;
            buttonNext.Location = new Point(310, 316);
            buttonNext.Margin = new Padding(10);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(173, 49);
            buttonNext.TabIndex = 2;
            buttonNext.Text = "Далее";
            buttonNext.UseVisualStyleBackColor = false;
            buttonNext.Click += button1_Click;
            // 
            // textBoxFullName
            // 
            textBoxFullName.BackColor = Color.FromArgb(25, 27, 39);
            textBoxFullName.Font = new Font("Segoe UI", 16F);
            textBoxFullName.ForeColor = Color.White;
            textBoxFullName.Location = new Point(291, 166);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.PlaceholderText = "ФИО";
            textBoxFullName.Size = new Size(210, 36);
            textBoxFullName.TabIndex = 0;
            textBoxFullName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Segoe UI", 16F);
            labelFullName.ForeColor = Color.White;
            labelFullName.Location = new Point(294, 120);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(204, 30);
            labelFullName.TabIndex = 3;
            labelFullName.Text = "Введите свое ФИО";
            // 
            // labelGroup
            // 
            labelGroup.AutoSize = true;
            labelGroup.Font = new Font("Segoe UI", 16F);
            labelGroup.ForeColor = Color.White;
            labelGroup.Location = new Point(311, 218);
            labelGroup.Name = "labelGroup";
            labelGroup.Size = new Size(171, 30);
            labelGroup.TabIndex = 4;
            labelGroup.Text = "Введите группу";
            // 
            // textBoxGroup
            // 
            textBoxGroup.BackColor = Color.FromArgb(25, 27, 39);
            textBoxGroup.Font = new Font("Segoe UI", 16F);
            textBoxGroup.ForeColor = SystemColors.Window;
            textBoxGroup.Location = new Point(346, 264);
            textBoxGroup.Name = "textBoxGroup";
            textBoxGroup.PlaceholderText = "Группа";
            textBoxGroup.RightToLeft = RightToLeft.No;
            textBoxGroup.Size = new Size(100, 36);
            textBoxGroup.TabIndex = 1;
            textBoxGroup.TextAlign = HorizontalAlignment.Center;
            // 
            // FormRegistration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 27, 39);
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxGroup);
            Controls.Add(labelGroup);
            Controls.Add(labelFullName);
            Controls.Add(textBoxFullName);
            Controls.Add(buttonNext);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormRegistration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ввод информации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonNext;
        private TextBox textBoxFullName;
        private Label labelFullName;
        private Label labelGroup;
        private TextBox textBoxGroup;
    }
}
