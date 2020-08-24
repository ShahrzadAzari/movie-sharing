using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Requests
{
    public class Files
    {
        private HttpClient _Http;
        private Tewr.Blazor.FileReader.IFileReaderService _fileReader;
        public Files(HttpClient Http , Tewr.Blazor.FileReader.IFileReaderService fileReader)
        {
            _Http = Http;
            _fileReader = fileReader;
        }
        public ElementReference inputReference;
        public string fileName = string.Empty;
        public Stream fileStream = null;

        public async Task OpenFileAsync()
        {
            // Read the files
            var file = (await _fileReader.CreateReference(inputReference).EnumerateFilesAsync()).FirstOrDefault();
            if (file == null)
                return;
            // Get the info of that files 
            var fileInfo = await file.ReadFileInfoAsync();
            fileName = fileInfo.Name;
            using (var ms = await file.CreateMemoryStreamAsync((int)fileInfo.Size))
            {
                fileStream = new MemoryStream(ms.ToArray());
            }
        }
        
        public async Task<HttpResponseMessage> UploadFileAsync()
        {
            // Create the content 
            var content = new MultipartFormDataContent();
            if(fileStream != null)
            {
                content.Headers.ContentDisposition = new System.Net.Http.Headers.ContentDispositionHeaderValue("form-data");
                content.Add(new StreamContent(fileStream, (int)fileStream.Length), "image", fileName);
                string url = @"http://localhost:5000/api/Images";
                var response = await _Http.PostAsync(url, content);
                return response;
            }
            else
            {
                return null;
            }
        }
    }
}