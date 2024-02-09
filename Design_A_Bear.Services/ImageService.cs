using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_A_Bear.Services
{
    public class ImageService : IImageService
    {
        public string ConvertBase64ToImage(string Base64String)
        {
            return $"data:image/*;base64,{Base64String}";
        }
    }
}
