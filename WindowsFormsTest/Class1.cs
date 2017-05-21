using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public static class Class1
    {
        public static void AppendText(this RichTextBox rich, string text, Color color)
        {
            rich.SelectionStart = rich.TextLength;
            rich.SelectionLength = 0;

            rich.SelectionColor = color;
            rich.AppendText(text);
            rich.SelectionColor = rich.ForeColor;
        }
    }
}
