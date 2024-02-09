using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_A_Bear.Services
{
    public interface IImageService
    {
        public string ConvertBase64ToImage(string Base64String);
    }
}
