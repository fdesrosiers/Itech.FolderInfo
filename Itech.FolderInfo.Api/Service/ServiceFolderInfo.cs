using Itech.Common.FolderInfo;
using Itech.Common.FolderInfo.Entities;
using Itech.FolderInfo.Api.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itech.FolderInfo.Api.Service
{
    public class ServiceFolderInfo : IServiceFolderInfo
    {
		private IFolderDetailReader reader;
		public ServiceFolderInfo(IFolderDetailReader reader)
		{
			this.reader = reader;
		}

		public FolderDetail GetFolderDetail(string path)
        {
			try
			{
				return reader.GetFolderDetail(path);
			}
			catch (ArgumentException ex)
			{
				throw new ParameterServiceException(ex.Message);
			} 
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
