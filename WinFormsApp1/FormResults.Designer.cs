namespace WinFormsApp1
{
    partial class FormResults
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
            panelHeader = new Panel();
            labelPrecentsHeader = new Label();
            labelGradeHeader = new Label();
            labelSubjectHeader = new Label();
            labelHeader = new Label();
            panelDelimeter = new Panel();
            panelResult1 = new Panel();
            labelPrecents1 = new Label();
            labelGrade1 = new Label();
            labelSubjectLevel1 = new Label();
            panelHeader.SuspendLayout();
            panelResult1.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(150, 73, 244);
            panelHeader.Controls.Add(labelPrecentsHeader);
            panelHeader.Controls.Add(labelGradeHeader);
            panelHeader.Controls.Add(labelSubjectHeader);
            panelHeader.Controls.Add(labelHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(10, 10);
            panelHeader.Margin = new Padding(10);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(10);
            panelHeader.Size = new Size(780, 112);
            panelHeader.TabIndex = 0;
            // 
            // labelPrecentsHeader
            // 
            labelPrecentsHeader.BackColor = Color.Indigo;
            labelPrecentsHeader.Dock = DockStyle.Right;
            labelPrecentsHeader.Font = new Font("Segoe UI", 16F);
            labelPrecentsHeader.ForeColor = Color.White;
            labelPrecentsHeader.Location = new Point(647, 47);
            labelPrecentsHeader.Name = "labelPrecentsHeader";
            labelPrecentsHeader.Size = new Size(123, 55);
            labelPrecentsHeader.TabIndex = 3;
            labelPrecentsHeader.Text = "Проценты";
            labelPrecentsHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGradeHeader
            // 
            labelGradeHeader.BackColor = Color.Indigo;
            labelGradeHeader.Dock = DockStyle.Fill;
            labelGradeHeader.Font = new Font("Segoe UI", 16F);
            labelGradeHeader.ForeColor = Color.White;
            labelGradeHeader.Location = new Point(424, 47);
            labelGradeHeader.Name = "labelGradeHeader";
            labelGradeHeader.Size = new Size(346, 55);
            labelGradeHeader.TabIndex = 2;
            labelGradeHeader.Text = "Оценка";
            labelGradeHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSubjectHeader
            // 
            labelSubjectHeader.BackColor = Color.Indigo;
            labelSubjectHeader.Dock = DockStyle.Left;
            labelSubjectHeader.Font = new Font("Segoe UI", 16F);
            labelSubjectHeader.ForeColor = Color.White;
            labelSubjectHeader.Location = new Point(10, 47);
            labelSubjectHeader.Name = "labelSubjectHeader";
            labelSubjectHeader.Size = new Size(414, 55);
            labelSubjectHeader.TabIndex = 1;
            labelSubjectHeader.Text = "Предмет, уровень";
            labelSubjectHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelHeader
            // 
            labelHeader.Dock = DockStyle.Top;
            labelHeader.Font = new Font("Segoe UI", 16F);
            labelHeader.ForeColor = Color.White;
            labelHeader.Location = new Point(10, 10);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(760, 37);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Результаты тестов";
            labelHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDelimeter
            // 
            panelDelimeter.Dock = DockStyle.Top;
            panelDelimeter.Location = new Point(10, 67);
            panelDelimeter.Name = "panelDelimeter";
            panelDelimeter.Size = new Size(780, 18);
            panelDelimeter.TabIndex = 1;
            // 
            // panelResult1
            // 
            panelResult1.BackColor = Color.FromArgb(150, 73, 244);
            panelResult1.Controls.Add(labelPrecents1);
            panelResult1.Controls.Add(labelGrade1);
            panelResult1.Controls.Add(labelSubjectLevel1);
            panelResult1.Dock = DockStyle.Top;
            panelResult1.Location = new Point(10, 85);
            panelResult1.Margin = new Padding(10);
            panelResult1.Name = "panelResult1";
            panelResult1.Padding = new Padding(10);
            panelResult1.Size = new Size(780, 83);
            panelResult1.TabIndex = 2;
            // 
            // labelPrecents1
            // 
            labelPrecents1.Dock = DockStyle.Right;
            labelPrecents1.Font = new Font("Segoe UI", 16F);
            labelPrecents1.ForeColor = Color.White;
            labelPrecents1.Location = new Point(654, 10);
            labelPrecents1.Name = "labelPrecents1";
            labelPrecents1.Size = new Size(116, 63);
            labelPrecents1.TabIndex = 2;
            labelPrecents1.Text = "label3";
            labelPrecents1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelGrade1
            // 
            labelGrade1.Dock = DockStyle.Fill;
            labelGrade1.Font = new Font("Segoe UI", 16F);
            labelGrade1.ForeColor = Color.White;
            labelGrade1.Location = new Point(310, 10);
            labelGrade1.Name = "labelGrade1";
            labelGrade1.Size = new Size(460, 63);
            labelGrade1.TabIndex = 1;
            labelGrade1.Text = "label2";
            labelGrade1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSubjectLevel1
            // 
            labelSubjectLevel1.Dock = DockStyle.Left;
            labelSubjectLevel1.Font = new Font("Segoe UI", 16F);
            labelSubjectLevel1.ForeColor = Color.White;
            labelSubjectLevel1.Location = new Point(10, 10);
            labelSubjectLevel1.Name = "labelSubjectLevel1";
            labelSubjectLevel1.Size = new Size(300, 63);
            labelSubjectLevel1.TabIndex = 0;
            labelSubjectLevel1.Text = "label1";
            labelSubjectLevel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(25, 27, 39);
            ClientSize = new Size(800, 450);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormResults";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Результаты тестов";
            FormClosing += FormResults_FormClosing;
            Load += FormResults_Load;
            panelHeader.ResumeLayout(false);
            panelResult1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private Panel panelDelimeter;
        private Panel panelResult1;
        private Label labelHeader;
        private Label labelPrecents1;
        private Label labelGrade1;
        private Label labelSubjectLevel1;
        private Label labelPrecentsHeader;
        private Label labelGradeHeader;
        private Label labelSubjectHeader;
    }
}