using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itech.Common.FolderInfo.Entities
{
    public class FolderDetail
    {
        public FolderDetail(string path)
        {
            FolderPath = path;
        }
        public string FolderPath { get; set; }
        public List<Folder> Folders { get; set; }
        public List<File> Files { get; set; }
        public long TotalSize
        {
            get
            {
                return Folders.Sum(folder => folder.Size);
            }
        }

        public int NbFiles
        {
            get
            {
                return Files.Count();
            }
        }

        public override string ToString()
        {
            StringBuilder value = new StringBuilder();
            value.AppendLine(String.Format("Detail of the folder: {0}", FolderPath));
            value.AppendLine(String.Format("Total size: {0}", TotalSize));
            value.AppendLine(String.Format("Number of files: {0}", NbFiles));
            value.AppendLine();
            value.AppendLine("List of directories");
            value.AppendLine();
            foreach (var folder in Folders)
            {
                value.AppendLine(folder.ToString());
            }

            value.AppendLine();
            value.AppendLine("List of files");
            value.AppendLine();

            foreach (var file in Files)
            {
                value.AppendLine(file.ToString());
            }

            return value.ToString();
        }
    }
}
