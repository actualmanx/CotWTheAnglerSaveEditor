using System;
using System.Collections.Generic;
using System.Text;

namespace SaveEditor.Core
{
    public static class PatternScanner
    {
        public static int Find(byte[] data, byte?[] pattern)
        {
            for (int i = 0; i < data.Length - pattern.Length; i++)
            {
                bool match = true;

                for (int j = 0; j < pattern.Length; j++)
                {
                    if (pattern[j].HasValue && data[i + j] != pattern[j].Value)
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                    return i;
            }

            return -1;
        }
    }
}