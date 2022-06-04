using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.Common.Service.EncodeDecode
{
    public interface IEncodeDecode
    {
        Task<string> EncodeStringToBase64(string value);
        Task<string> DecodeBase64ToString(string value);
    }
}
