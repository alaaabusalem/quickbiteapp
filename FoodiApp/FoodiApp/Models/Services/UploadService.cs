using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using FoodiApp.Models.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FoodiApp.Models.Services
{
    public class UploadService : IUpload
    {
        IConfiguration Configuration;

        public UploadService(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        public async Task<Document> UploadFile(IFormFile file)
        {
            BlobContainerClient container = new BlobContainerClient(Configuration.GetConnectionString("StorageAccount"), "images");
            await container.CreateIfNotExistsAsync();
            BlobClient blob = container.GetBlobClient(file.FileName);
            using var stream = file.OpenReadStream();

            BlobUploadOptions options = new BlobUploadOptions()
            {
                HttpHeaders = new BlobHttpHeaders() { ContentType = file.ContentType }
            };


            if (!blob.Exists())
            {
                await blob.UploadAsync(stream, options);
            }


            var doc = new Document()
            {
                Name = file.FileName,
                Size = file.Length,
                Type = file.ContentType,
                URL = blob.Uri.ToString()
            };



            return doc;
        }

    }
}

