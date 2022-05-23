using BPack.Common.Pocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPack.CommonMes.Controls.FileManager
{
    public class FileManagerPocket : PocketBase
    {
        public FileManagerPocket()
        {
            InitPocket("FileManager");
        }

        public FileManagerFileGroupModel SelectFileManagerFileGroupModels(FileManagerModelArgs args)
        {
            return PocketQuery<FileManagerFileGroupModel>("Sys.FileManager.FileGroup.Select", new
            {
                FILE_GROUP_ID = args.Select_Main_File_Group_ID
            }).FirstOrDefault();
        }

        public List<FileManagerFileModel> SelectFileManagerFileModels(FileManagerModelArgs args)
        {
            return PocketQuery<FileManagerFileModel>("Sys.FileManager.File.Select", new
            {
                FILE_GROUP_ID = args.Select_Main_File_Group_ID
            });
        }

        public string CreateFileGroupID()
        {
            return PocketQuery<string>("Sys.FileManager.File.Create", null).SingleOrDefault().ToString();
        }

        public void SaveFileManagerFileModelModels(List<FileManagerFileModel> updateFilesModels)
        {
            PocketExecute("Sys.FileManager.File.BP", updateFilesModels);
        }

    }
}
