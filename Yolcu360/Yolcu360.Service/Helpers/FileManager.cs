using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Helpers
{
    public static class FileManager
    {
        public static string UploadFile(string webRoot,string folder, IFormFile file)
        {
            string fileName=Guid.NewGuid().ToString() + ((file.FileName.Length>60)?file.FileName.Substring(file.FileName.Length-60):file.FileName);
            var mainPath=Path.Combine(webRoot,folder, fileName);
            using (var stream=new FileStream(mainPath,FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return fileName;
        }
        public static void DeleteFile(string webRoot, string folder, string fileName)
        {
            var mainPath=Path.Combine(webRoot,folder, fileName);
            if (File.Exists(mainPath))
            {
                File.Delete(mainPath);
            }
        }
        public static void DeleteFiles(string webRoot, string folder, List<string> fileNames)
        {
            foreach (var item in fileNames)
            {
                var mainPath = Path.Combine(webRoot, folder, item);
                if (File.Exists(mainPath))
                {
                    File.Delete(mainPath);
                }
            }
        }
    }
}
