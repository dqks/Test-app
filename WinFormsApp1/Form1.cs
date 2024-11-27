using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "������ ����";
            textBox2.Text = "��-22";
            if (!Regex.IsMatch(textBox1.Text, @"^[�-�]{1}[�-�]+ [�-�]{1}[�-�]+([�-�]{1}[�-�]+$)?"))
            {
                label3.Text = "������� ������ ���";
                return;
            }

            if (!Regex.IsMatch(textBox2.Text, @"^[�-�]+\-\d{2}$"))
            {
                label3.Text = "������� ������ �������� ������";
                return;
            }



            label3.Text = "";
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
