namespace FoodiApp.Models.Interfaces
{
    public interface IUpload
    {
        public Task<Document> UploadFile(IFormFile file);   
    }
}
