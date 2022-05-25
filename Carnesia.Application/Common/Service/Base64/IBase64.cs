using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.Common.Service.Base64
{
    public interface IBase64
    {
        Task<string> ConvertToBase64(int ImageSize, int ImageWidth, int ImageHeight, InputFileChangeEventArgs ImageFile);
    }
}
