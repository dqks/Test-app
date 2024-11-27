using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class ControlExtensions
{
    public static IEnumerable<Control> GetAllNestedControls(this Control root)
    {
        var stack = new Stack<Control>();
        stack.Push(root);

        do
        {
            var control = stack.Pop();

            foreach (Control child in control.Controls)
            {
                yield return child;
                stack.Push(child);
            }
        }
        while (stack.Count > 0);
    }
}