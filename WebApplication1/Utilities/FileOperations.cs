using Microsoft.AspNetCore.Http;

namespace WebApplication1.Utilities
{
    public static class FileOperations
    {
        public static string GuidName(string fileName)
        {
            return Guid.NewGuid().ToString() + "_" + fileName;
        }

        public static string UploadFile(IFormFile file)
        {
            string fileNameWithGUID = GuidName(file.FileName);
            FileStream fs = new FileStream("wwwroot/KapakResimleri/" + fileNameWithGUID, FileMode.Create);
            file.CopyTo(fs);
            fs.Close();
            return fileNameWithGUID;
        }
    }
}
