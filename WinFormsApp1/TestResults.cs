using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal static class TestResults
    {

        private static List<string> Results = new List<string>();


        public static List<string> GetResults ()
        {
            return Results;
        }

        public static void AddResult (string subject, string level, double precents, int grade)
        {
            string item = subject + "DEL" + level + "DEL" + precents + "DEL" + grade;
            Results.Add(item);
        }


    }
}
