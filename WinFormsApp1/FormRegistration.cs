using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
	public partial class FormRegistration : Form
	{
		bool isAdministrator = false;

		public FormRegistration()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            //textBoxFullName.Text = "������ ����";
            //textBoxGroup = "��-22";
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

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
			List<User>? users;
			//�������������, �������� �� ����� ������ ���� �������������
			using (FileStream fs = new FileStream(@"C:\Users\user\Desktop\�������� ������\����������\WinFormsApp1\Users.xml", FileMode.OpenOrCreate))
			{
				users = xmlSerializer.Deserialize(fs) as List<User>;
			}

			User user = null;

			//����, ���� �� ��������������� ������������ �� �����, ���� ���
			//�� ����������� �������� � ���
			foreach (User u in users)
			{
				if (textBoxFullName.Text == u.name && textBoxGroup.Text == u.group)
				{
					user = u;
					break;
				}
			}

			//���� ������������ �� ��� ������, �� ������ ��� � ������
			if (user == null)
			{
				user = new User(textBoxFullName.Text, textBoxGroup.Text);
				users.Add(user);
                //��������� ������������
                using (FileStream fs = new FileStream(@"C:\Users\user\Desktop\�������� ������\����������\WinFormsApp1\Users.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, users);
                }
            }

			//TreeNode.makeTreeNode();
			//TreeNode.SerializeToXml(TreeNode.tests, @"C:\Users\user\Desktop\�������� ������\����������\WinFormsApp1\Tests.xml");

			TreeNode.tests = TreeNode.DeserializeFromXml(@"C:\Users\user\Desktop\�������� ������\����������\WinFormsApp1\Tests.xml");


            FormTestSettings form2 = new FormTestSettings(user);
			form2.Show();
			this.Hide();
		}
	}
}

/*
����������� ���������� �����������, � �������������� �����

�������������:
��� �������

������������:
���������� ������� ����
���������� ������������ ����
(������� ���� ������)

�������������� � Users:

����� ������������������ ��������� ������ � User.xml, ��������� ��� ����� 
(� �������� � �� ��������� � ����� �������, ���� ������������ ��� ��� � �������) ���������, � ��������������� 
������� � ����
����� ��������� �������� ���� �� ����, ���� ����, �� ������� �������� � ���� ��������
� ���� �� ������, �� ����������

 */