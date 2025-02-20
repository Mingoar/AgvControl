using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControl
{
    static class AppendTextExtension
    {
        public static void AppendTextColorful(this RichTextBox rtBox, string addtext, Color color= default(Color), bool IsaddNewLine = true)
        {
            if (IsaddNewLine && rtBox.Text != "")
            {
                rtBox.AppendText(Environment.NewLine);
                //addtext += Environment.NewLine;
            }
            rtBox.SelectionStart = rtBox.TextLength;
            rtBox.SelectionLength = 0;
            rtBox.SelectionColor = color;
            rtBox.AppendText(addtext);
            rtBox.SelectionColor = rtBox.ForeColor;
            rtBox.SelectionStart = rtBox.Text.Length; //Set the current caret position at the end
            rtBox.ScrollToCaret(); //Now scroll it automatically
        }
    }
}
