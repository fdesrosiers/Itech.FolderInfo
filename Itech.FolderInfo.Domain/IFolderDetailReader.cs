using Itech.Common.FolderInfo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itech.Common.FolderInfo
{
    public interface IFolderDetailReader
    {
        FolderDetail GetFolderDetail(string path);
    }
}
