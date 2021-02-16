using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace InventariosEquipos.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile);
    }
}