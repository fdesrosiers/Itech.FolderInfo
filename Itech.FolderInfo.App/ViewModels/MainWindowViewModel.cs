using System;
using System.Collections.Generic;
using System.Text;
using Itech.Common.FolderInfo.Entities;
using Itech.Common.FolderInfo.IO;
using Itech.FolderInfo.Api;
using Itech.FolderInfo.Api.Exceptions;
using Itech.FolderInfo.Api.Service;
using ReactiveUI;

namespace Itech.FolderInfo.App.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private IServiceFolderInfo serviceFolder;
        public MainWindowViewModel():base()
        {
            serviceFolder = new ServiceFolderInfo(new FolderDetailReader());
        }

        string folderPath="";
        public string FolderPath
        {
            get => folderPath;
            set => this.RaiseAndSetIfChanged(ref folderPath, value);
        }
        string errorMessage="";
        public string ErrorMessage
        {
            get => errorMessage;
            set => this.RaiseAndSetIfChanged(ref errorMessage, value);
        }

        string detailFolder = "";
        public string DetailFolder
        {
            get => detailFolder;
            set => this.RaiseAndSetIfChanged(ref detailFolder, value);
        }

        bool isError=false;
        public bool IsError
        {
            get => isError;
            set => this.RaiseAndSetIfChanged(ref isError, value);
        }
        public void OnClickDisplayDetail()
        {
            IsError = false;
            ErrorMessage = "";
            DetailFolder = "";

            if (FolderPath==String.Empty)
            {
                IsError = true;
                ErrorMessage = "You need to define a path";
            }

            try
            {
                FolderDetail result = serviceFolder.GetFolderDetail(FolderPath);
                DetailFolder = result.ToString();
            }
            catch (ParameterServiceException ex)
            {
                IsError = true;
                ErrorMessage = "You need to define a valid path";
            }
            catch (Exception ex)
            {
                IsError = true;
                ErrorMessage = ex.Message;
            }

        }
    }
}
