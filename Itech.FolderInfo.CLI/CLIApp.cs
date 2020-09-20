using Itech.Common.FolderInfo;
using Itech.Common.FolderInfo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Itech.CLI
{
    public class CLIApp
    {
        private readonly IFolderDetailReader reader;
        public CLIApp(IFolderDetailReader reader)
        {
            this.reader = reader;
        }

        public void Execute()
        {
            do
            {
                Console.WriteLine("\nDo you want to have the detail of a folder (Y/N)?");
                var answer = Console.ReadLine();

                if (answer.ToUpper() =="Y")
                {
                    try
                    {
                        Console.WriteLine("\nWhat is the folder you would like to inspect ?");
                        var path = Console.ReadLine();

                        FolderDetail detail = reader.GetFolderDetail(path);
                        Console.WriteLine(detail.ToString());
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Une erreur est survenue: {0}", ex.Message);
                    }
                }
                else if (answer.ToUpper() == "N")
                {
                    break;
                }

            } while (true);
        }
    }
}
