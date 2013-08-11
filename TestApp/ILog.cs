﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;

namespace SkypeFx
{
    interface ILog
    {
        void Info(string format, params object[] args);
        void Error(string format, params object[] args);
    }

    class DebugLogger : ILog
    {
        public void Info(string format, params object[] args)
        {
            Debug.Write("INFO: ");
            Debug.WriteLine(string.Format(format, args));
        }

        public void Error(string format, params object[] args)
        {
            Debug.Write("ERROR: ");
            Debug.WriteLine(string.Format(format, args));
        }
    }

    class RichTextLogger : ILog
    {
        RichTextBox richTextBox;

        public RichTextLogger(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        delegate void LogMethod(string format, params object[] args);

        public void Info(string format, params object[] args)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new LogMethod(Info), format, args);
            }
            else
            {
                richTextBox.ForeColor = Color.Blue;
                richTextBox.AppendText(string.Format("{0:HH:MM:ss} ", DateTime.Now));
                richTextBox.AppendText(string.Format(format, args));
                richTextBox.AppendText(Environment.NewLine);
            }
        }

        public void Error(string format, params object[] args)
        {
            if (richTextBox.InvokeRequired)
            {
                richTextBox.BeginInvoke(new LogMethod(Error), format, args);
            }
            else
            {
                richTextBox.ForeColor = Color.Red;
                richTextBox.AppendText(string.Format("{0:HH:MM:ss} ", DateTime.Now));
                richTextBox.AppendText(string.Format(format, args));
                richTextBox.AppendText(Environment.NewLine);
            }
        }
    }
}
