using Itech.Common.FolderInfo.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Itech.Common.FolderInfo.Entities;
using System.Reflection;
using System.IO;
using System.Linq;

namespace FolderInfo.Tests.IO
{
    [TestClass]
    public class FolderDetailTest
    {
        [TestMethod]
        public void FolderDetail_Should_Contain_The_Number_Of_Files()
        {
            string pathFolderTest = Path.Combine(Assembly.GetEntryAssembly().Location, @"..\..\..\..\..\FolderForTest");
            string pathTest = Path.GetFullPath(pathFolderTest);

            FolderDetailReader reader = new FolderDetailReader();

            FolderDetail result = reader.GetFolderDetail(pathTest);

            Assert.AreEqual(12, result.Files.Count);
        }

        [TestMethod]
        public void FolderDetail_Should_Contain_The_Number_Of_Child_Folders()
        {
            string pathFolderTest = Path.Combine(Assembly.GetEntryAssembly().Location, @"..\..\..\..\..\FolderForTest");
            string pathTest = Path.GetFullPath(pathFolderTest);

            FolderDetailReader reader = new FolderDetailReader();

            FolderDetail result = reader.GetFolderDetail(pathTest);

            Assert.AreEqual(5, result.Folders.Count);
        }

        [TestMethod]
        public void Folder_Should_OrderBy_Size()
        {
            string pathFolderTest = Path.Combine(Assembly.GetEntryAssembly().Location, @"..\..\..\..\..\FolderForTest");
            string pathTest = Path.GetFullPath(pathFolderTest);

            FolderDetailReader reader = new FolderDetailReader();

            FolderDetail result = reader.GetFolderDetail(pathTest);

            Assert.IsTrue((result.Folders[0].Size> result.Folders[1].Size),"The first is bigger than the second");
            Assert.IsTrue((result.Folders[1].Size > result.Folders[2].Size), "The second is bigger than the third");
            Assert.IsTrue((result.Folders[2].Size > result.Folders[3].Size), "The third is bigger than the fourth");
        }

        [TestMethod]
        public void Files_Should_OrderBy_Size()
        {
            string pathFolderTest = Path.Combine(Assembly.GetEntryAssembly().Location, @"..\..\..\..\..\FolderForTest");
            string pathTest = Path.GetFullPath(pathFolderTest);

            FolderDetailReader reader = new FolderDetailReader();

            FolderDetail result = reader.GetFolderDetail(pathTest);

            Assert.IsTrue((result.Files[0].Size > result.Files[1].Size), "The first is bigger than the second");
            Assert.IsTrue((result.Files[1].Size > result.Files[2].Size), "The second is bigger than the third");
            Assert.IsTrue((result.Files[2].Size > result.Files[3].Size), "The third is bigger than the fourth");
        }

        [TestMethod]
        public void FolderDetail_Should_Contain_The_Total_Size()
        {
            string pathFolderTest = Path.Combine(Assembly.GetEntryAssembly().Location, @"..\..\..\..\..\FolderForTest");
            string pathTest = Path.GetFullPath(pathFolderTest);

            FolderDetailReader reader = new FolderDetailReader();

            FolderDetail result = reader.GetFolderDetail(pathTest);

            long totalSize = result.Folders.Sum(folder => folder.Size);

            Assert.AreEqual(totalSize, result.TotalSize);
        }

        [TestMethod]
        public void FolderDetail_Should_Contain_The_Number_OF_Files()
        {
            string pathFolderTest = Path.Combine(Assembly.GetEntryAssembly().Location, @"..\..\..\..\..\FolderForTest");
            string pathTest = Path.GetFullPath(pathFolderTest);

            FolderDetailReader reader = new FolderDetailReader();

            FolderDetail result = reader.GetFolderDetail(pathTest);

            Assert.AreEqual(result.Files.Count, result.NbFiles);
        }
    }
}
