using System;
using System.Collections.Generic;
using System.Text;

namespace SaveEditor.Core
{
    public class SaveFile
    {
        public string Path { get; }
        public byte[] Data { get; private set; }

        public SaveFile(string path)
        {
            Path = path;
            Data = File.ReadAllBytes(path);
        }

        public int ReadInt32(int offset)
        {
            return BitConverter.ToInt32(Data, offset);
        }

        public void WriteInt32(int offset, int value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            Array.Copy(bytes, 0, Data, offset, 4);
        }

        public void Save()
        {
            File.WriteAllBytes(Path, Data);
        }
    }
}