using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    public partial class FormResults : Form
    {

        User user;

        public FormResults(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void FormResults_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form2 = new Form2(user);
            form2.Show();
        }

        private void FormResults_Load(object sender, EventArgs e)
        {
            int index = 1;

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<User>));
            List<User>? users;
            //Десерализация, получаем из файла список всех пользователей
            using (FileStream fs = new FileStream(@"C:\Users\user\Desktop\Курсовая работа\Приложение\WinFormsApp1\Users.xml", FileMode.OpenOrCreate))
            {
                users = xmlSerializer.Deserialize(fs) as List<User>;
            }

            User serializedUser = null;

            //Ищем, были ли зарегистрирован пользователь до этого, если был
            //То присваиваем работаем с ним
            foreach (User u in users)
            {
                if (user.name == u.name && user.group == u.group)
                {
                    serializedUser = u;
                    break;
                }
            }


            foreach (var result in serializedUser.GetResults())
            {

                string[] strings = result.ToString().Split("DEL");

                Panel panelResult = new Panel();
                Panel panelDelimeterNew = new Panel();
                Label labelPrecents = new Label();
                Label labelGrade = new Label();
                Label labelSubjectLevel = new Label();

                panelDelimeterNew.Dock = DockStyle.Top;
                panelDelimeterNew.Name = "panelDelimeter" + index;
                panelDelimeterNew.Size = new Size(780, 18);
                panelDelimeterNew.TabIndex = 1;

                panelResult.BackColor = Color.FromArgb(150, 73, 244);
                panelResult.Controls.Add(labelPrecents);
                panelResult.Controls.Add(labelGrade);
                panelResult.Controls.Add(labelSubjectLevel);
                panelResult.Dock = DockStyle.Top;
                panelResult.Margin = new Padding(10);
                panelResult.Name = "panelResult" + index;
                panelResult.Padding = new Padding(10);
                panelResult.Size = new Size(780, 83);
                panelResult.TabIndex = 2;

                labelPrecents.Dock = DockStyle.Right;
                labelPrecents.Font = new Font("Segoe UI", 16F);
                labelPrecents.ForeColor = Color.White;
                labelPrecents.Name = "labelPrecents" + index;
                labelPrecents.Size = new Size(116, 63);
                labelPrecents.TabIndex = 2;
                labelPrecents.Text = strings[2] + "%";
                labelPrecents.TextAlign = ContentAlignment.MiddleCenter;

                labelGrade.Dock = DockStyle.Fill;
                labelGrade.Font = new Font("Segoe UI", 16F);
                labelGrade.ForeColor = Color.White;
                labelGrade.Name = "labelGrade" + index;
                labelGrade.Size = new Size(689, 63);
                labelGrade.TabIndex = 1;
                labelGrade.Text = strings[3].ToString();
                labelGrade.TextAlign = ContentAlignment.MiddleCenter;

                labelSubjectLevel.Dock = DockStyle.Left;
                labelSubjectLevel.Font = new Font("Segoe UI", 16F);
                labelSubjectLevel.ForeColor = Color.White;
                labelSubjectLevel.Name = "labelSubjectLevel" + index;
                labelSubjectLevel.Size = new Size(400, 63);
                labelSubjectLevel.TabIndex = 0;
                labelSubjectLevel.Text = strings[0] + ", " + strings[1];
                labelSubjectLevel.TextAlign = ContentAlignment.MiddleLeft;

                Controls.Add(panelResult);
                Controls.Add(panelDelimeterNew);

                Controls.Add(panelHeader);

                index++;
            }
        }
    }
}
