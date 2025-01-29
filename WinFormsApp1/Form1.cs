using System.Text.RegularExpressions;
using System.Windows.Forms;

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
                MessageBox.Show(
                    "������� ������ ���",
                    "������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBox2.Text, @"^[�-�]+\-\d{2}$"))
            {
                MessageBox.Show(
                    "������� ������ �������� ������",
                    "������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            TreeNode.makeTreeNode();

            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
