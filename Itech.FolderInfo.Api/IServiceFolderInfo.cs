using Itech.Common.FolderInfo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itech.FolderInfo.Api
{
    public interface IServiceFolderInfo
    {
        FolderDetail GetFolderDetail(string path);
    }
}
