using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormRegistration : Form
    {

        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxFullName.Text = "������ ����";
            textBoxGroup.Text = "��-22";
            if (!Regex.IsMatch(textBoxFullName.Text, @"^[�-�]{1}[�-�]+ [�-�]{1}[�-�]+([�-�]{1}[�-�]+$)?"))
            {
                MessageBox.Show(
                    "������� ������ ���",
                    "������",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            if (!Regex.IsMatch(textBoxGroup.Text, @"^[�-�]+\-\d{2}$"))
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


/*
 
�������������� �����

�������� ����������� ����� - ������ ������ ��������� ���� � ���������� ���������
 
 */