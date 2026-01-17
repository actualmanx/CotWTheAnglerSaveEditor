using System;
using System.Collections.Generic;
using System.Text;

namespace SaveEditor.Core
{
    public class DebugLogger
    {
        private readonly RichTextBox _box;

        public DebugLogger(RichTextBox box)
        {
            _box = box;
        }

        public void Log(string text)
        {
            string msg = $"{DateTime.Now:HH:mm:ss} - {text}\n";
            _box.AppendText(msg);
            _box.ScrollToCaret();
        }

        public void LogRead(string label, byte[] data, int offset)
        {
            string b0 = data[offset + 0].ToString("X2");
            string b1 = data[offset + 1].ToString("X2");
            string b2 = data[offset + 2].ToString("X2");
            string b3 = data[offset + 3].ToString("X2");

            int value = BitConverter.ToInt32(data, offset);

            string msg =
                $"{DateTime.Now:HH:mm:ss} - {label}\n" +
                $"Offset: 0x{offset:X}\n" +
                $"Bytes: {b0} {b1} {b2} {b3}\n" +
                $"Value: {value}\n" +
                $"-----------------------------\n";

            _box.AppendText(msg);
            _box.ScrollToCaret();
        }
    }
}
