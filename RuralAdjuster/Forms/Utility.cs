using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace RuralAdjuster.Forms
{
    public static class Utility
    {
        public static Int32? VerifyNumberTextBox(Object sender, Color baseBackColor)
        {
            var newValueString = (sender as TextBox).Text;
            try
            {
                var newValue = Convert.ToInt32(newValueString);
                (sender as TextBox).BackColor = baseBackColor;
                return newValue;
            }
            catch (System.FormatException)
            {
                (sender as TextBox).BackColor = Color.Red;
                return null;
            }
        }

        public static Single? VerifyFloatTextBox(Object sender, Color baseBackColor)
        {
            var newValueString = (sender as TextBox).Text;
            try
            {
                var newValue = Convert.ToSingle(newValueString);
                (sender as TextBox).BackColor = baseBackColor;
                return newValue;
            }
            catch (System.FormatException)
            {
                (sender as TextBox).BackColor = Color.Red;
                return null;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }

    }
}
