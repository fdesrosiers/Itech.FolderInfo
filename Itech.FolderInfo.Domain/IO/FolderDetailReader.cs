using Itech.Common.FolderInfo.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Itech.Common.FolderInfo.IO
{
    public class FolderDetailReader : IFolderDetailReader
    {
        public string FolderPath { get; private set; }

        public FolderDetail GetFolderDetail(string path)
        {
            if (!Directory.Exists(path))
            {
                throw new ArgumentException("Target directory doesn't exist");
            }
            FolderPath = path;

            FolderDetail detail = new FolderDetail(FolderPath);

            string[] files = Directory.GetFiles(FolderPath,"*", SearchOption.AllDirectories);
            detail.Files = InitFilesDetail(files);

            DirectoryInfo[] folders = new DirectoryInfo(FolderPath).GetDirectories("*", SearchOption.AllDirectories);
            detail.Folders = InitFoldersDetail(folders);

            return detail;
        }

        private List<Entities.File> InitFilesDetail(string[] files)
        {
            List<Entities.File> detailFiles = new List<Entities.File>();

            foreach (var currentFile in files)
            {
                FileInfo fileTemp = new FileInfo(currentFile);

                detailFiles.Add(new Entities.File(fileTemp.Length,fileTemp.LastWriteTimeUtc,fileTemp.Name));
            }
            detailFiles=detailFiles.OrderByDescending(file => file.Size).ToList();
            return detailFiles;
        }

        private List<Entities.Folder> InitFoldersDetail(DirectoryInfo[] folders)
        {
            List<Entities.Folder> detailFolders = new List<Entities.Folder>();

            foreach (var currentFolder in folders)
            {
                long size = currentFolder.GetFiles().ToList().Sum(file => file.Length);
                detailFolders.Add(new Entities.Folder(size, currentFolder.LastWriteTimeUtc, currentFolder.Name));
            }
            detailFolders = detailFolders.OrderByDescending(file => file.Size).ToList();
            return detailFolders;
        }
    }
}
