using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Application.Common.Service.Base64;
using Microsoft.AspNetCore.Components.Forms;


namespace Carnesia.Application.Common.Service.Base64
{
    public class Base64Service : IBase64
    {
        public async Task<string> ConvertToBase64(int ImageSize, int ImageWidth, int ImageHeight, InputFileChangeEventArgs ImageFile)
        {
            try
            {
                var ImageBase = "";
                var file = ImageFile.File;

                var buffer = new byte[file.Size];

                if (file.Size > ImageSize)
                {
                    throw new Exception($"Maximum image size is {ImageSize/1024}KB!");
                }

                await file.OpenReadStream().ReadAsync(buffer);
                ImageBase = Convert.ToBase64String(buffer);

                //byte[] image = Convert.FromBase64String(ImageBase);

                //using (var ms = new MemoryStream(image))
                //{
                //    Image img = Image.FromStream(ms);

                //    Console.WriteLine(img.Width);

                //    if (img.Width != ImageWidth || img.Height != ImageHeight)
                //    {
                //        throw new Exception($"Image height & width must be {ImageHeight} & {ImageWidth}!");
                //    }
                //}

                return ImageBase;
            }
            catch (Exception)
            {
                throw;
            }
            

            
        }
    }
}
