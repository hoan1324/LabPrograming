using LAB1.Models.Interface;

namespace LAB1.Models
{
    public class UploadFileService : IUploadFileService
    {
        public async Task<byte[]> UploadFile(IFormFile file)
        {
            byte[] data;
            if (file != null && file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    await file.CopyToAsync(memoryStream);
                    data = memoryStream.ToArray();

                }
                return data;
            }
            return Array.Empty<byte>();
        }
    }
}
