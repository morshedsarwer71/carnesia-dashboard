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
                var file = ImageFile.File;

                var buffer = new byte[file.Size];

                if (file.Size > ImageSize)
                {
                    throw new Exception($"Maximum image size is {ImageSize/1024}KB!");
                }

                //using (Stream memStream = new MemoryStream(buffer))
                //{
                //    using (Image img = Image.FromStream(memStream))
                //    {
                //        if (img.Width != ImageWidth || img.Height != ImageHeight)
                //        {
                //            throw new Exception($"Image height & width must be {ImageHeight} & {ImageWidth}!");
                //        }
                //    }
                //}

                await file.OpenReadStream().ReadAsync(buffer);

                return $"data:image/webp;base64,{Convert.ToBase64String(buffer)}";
            }
            catch (Exception)
            {
                throw;
            }
            

            
        }
    }
}
