using System;
using System.Collections.Generic;
using System.Text;

namespace SaveEditor.Core
{
    public static class BackupManager
    {
        public static string CreateBackup(string originalPath)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string backupName = $"AnglerBackup_{DateTime.Now:yyyyMMdd_HHmmss}.sav";
            string backupPath = System.IO.Path.Combine(desktop, backupName);

            File.Copy(originalPath, backupPath, overwrite: false);
            return backupPath;
        }
    }
}