using System;
using System.Collections.Generic;
using System.Text;

namespace Itech.FolderInfo.Api.Exceptions
{
    public class ParameterServiceException: ArgumentException
    {
        public ParameterServiceException(string message) : base(message)
        {
            
        }
    }
}
