using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTest
{
    public class Class2
    {
        public void CheckKeyword(RichTextBox control, List<string> words, int startIndex, Color color, Color defaultColor, Font font, Font defaultFont)
        {
            foreach (var word in words)
            {
                if (control.Text.Contains(word))
                {
                    int index = -1;
                    int selectStart = control.SelectionStart;

                    while ((index = control.Text.IndexOf(word, (index + 1))) != -1)
                    {
                        control.Select((index + startIndex), word.Length);
                        control.SelectionFont = font;
                        control.SelectionColor = color;
                        control.Select(selectStart, 0);
                        control.SelectionColor = Color.Black;
                    }
                }
                else
                {
                    int selectStart = control.SelectionStart;
                    control.SelectionFont = defaultFont;
                    control.SelectionColor = defaultColor;
                    control.Select(selectStart, 0);
                    control.SelectionColor = Color.Black;
                }
            }
        }
    }
}
