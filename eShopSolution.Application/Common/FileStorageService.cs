using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;

namespace eShopSolution.Application.Common
{
    public class FileStorageService : IStorageService
    {
        private readonly string _userContentFolder;
        private const string USER_CONTENT_FOLDER_NAME = "user_content";

        public FileStorageService(IWebHostEnvironment webHostEnviroment)
        { 
            _userContentFolder= Path.Combine(webHostEnviroment.WebRootPath, USER_CONTENT_FOLDER_NAME);
        }
        public string GetFileUrl(string fileName)
        {
            return $"/{USER_CONTENT_FOLDER_NAME}/{fileName}";
        }
        public async Task SaveFileAsync(Stream mediaBinanryStream, string fileName)
        {
            var filePath = Path.Combine(_userContentFolder, fileName);
            using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinanryStream.CopyToAsync(output);
        }
        public async Task DeleteFileAsync(string fileName)
        {
            var filePath= Path.Combine(_userContentFolder, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() =>File.Delete(filePath));
            }
        }
    }
}
