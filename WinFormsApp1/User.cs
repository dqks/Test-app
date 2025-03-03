using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class User
    {

        public static List<User> list = new List<User>();

        public string name;

        public string group;

        public bool isAdmin = false;

        public List<string> results = new List<string>();

        public List<string> GetResults ()
        {
            return this.results;
        }

        public User() {}

        public User (string name, string group)
        {
            this.name = name;
            this.group = group;
        }

        public void AddResult(string subject, string level, double precents, int grade)
        {
            string item = subject + "DEL" + level + "DEL" + precents + "DEL" + grade;
            results.Add(item);
        }
    }
}
