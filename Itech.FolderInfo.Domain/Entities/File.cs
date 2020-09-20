using System;
using System.Collections.Generic;
using System.Text;

namespace Itech.Common.FolderInfo.Entities
{
    public class File
    {
        public long Size { get; private set; }
        public DateTime LastModify { get; private set; }
        public string Name { get; private set; }

        public File(long size, DateTime lastModify, string name)
        {
            Size = size;
            LastModify = lastModify;
            Name = name;
        }
        public override string ToString()
        {
            StringBuilder value = new StringBuilder();
            value.AppendLine(String.Format("Detail of the file: {0}", Name));
            value.AppendLine(String.Format("Size: {0}", Size));
            value.AppendLine(String.Format("Last Modify: {0}", LastModify));
            return value.ToString();
        }
    }
}
