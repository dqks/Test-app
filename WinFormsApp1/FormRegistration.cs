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
            //textBoxFullName.Text = "Максим Штин";
            //textBoxGroup = "ИС-22";
            if (!Regex.IsMatch(textBoxFullName.Text, @"^[А-Я]{1}[а-я]+ [А-Я]{1}[а-я]+([А-Я]{1}[а-я]+$)?"))
			{
				MessageBox.Show(
					"Введите верное ФИО",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			if (!Regex.IsMatch(textBoxGroup.Text, @"^[А-Я]+\-\d{2}$"))
			{
				MessageBox.Show(
					"Введите верное название группы",
					"Ошибка",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
			List<User>? users;
			//Десерализация, получаем из файла список всех пользователей
			using (FileStream fs = new FileStream(@"C:\Users\user\Desktop\Курсовая работа\Приложение\WinFormsApp1\Users.xml", FileMode.OpenOrCreate))
			{
				users = xmlSerializer.Deserialize(fs) as List<User>;
			}

			User user = null;

			//Ищем, были ли зарегистрирован пользователь до этого, если был
			//То присваиваем работаем с ним
			foreach (User u in users)
			{
				if (textBoxFullName.Text == u.name && textBoxGroup.Text == u.group)
				{
					user = u;
					break;
				}
			}

			//Если пользователь не был найден, то вносим его в список
			if (user == null)
			{
				user = new User(textBoxFullName.Text, textBoxGroup.Text);
				users.Add(user);
                //Сохраняем пользователя
                using (FileStream fs = new FileStream(@"C:\Users\user\Desktop\Курсовая работа\Приложение\WinFormsApp1\Users.xml", FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, users);
                }
            }

			//TreeNode.makeTreeNode();
			//TreeNode.SerializeToXml(TreeNode.tests, @"C:\Users\user\Desktop\Курсовая работа\Приложение\WinFormsApp1\Tests.xml");

			TreeNode.tests = TreeNode.DeserializeFromXml(@"C:\Users\user\Desktop\Курсовая работа\Приложение\WinFormsApp1\Tests.xml");


            FormTestSettings form2 = new FormTestSettings(user);
			form2.Show();
			this.Hide();
		}
	}
}

/*
Реализовать корректную авторизацию, с использованием ролей

Администратор:
Все открыто

Пользователь:
Невозможно создать тест
Невозможно редатировать тест
(Скрытие этих кнопок)

Взаимодействие с Users:

Нужно дессериализовывать постоянно список в User.xml, дополнять его новым 
(а возможно и не дополнять а брать элемент, если пользователь уже был в записях) элементом, и сериализовывать 
обратно в файл
Нужно выполнять проверку пуст ли файл, если пуст, то сначала записать в него значение
а если не пустой, то дописывать

 */