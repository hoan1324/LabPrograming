namespace LAB1.Models.Interface
{
    public interface IUploadFileService
    {
        Task<byte[]> UploadFile(IFormFile file);
    }
}
