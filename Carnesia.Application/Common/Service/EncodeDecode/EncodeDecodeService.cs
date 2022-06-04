using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Application.Common.Service.EncodeDecode
{
    public class EncodeDecodeService : IEncodeDecode
    {
        public async Task<string> DecodeBase64ToString(string value)
        {
            var base64EncodedBytes = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public async Task<string> EncodeStringToBase64(string value)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(plainTextBytes);
            
        }
    }
}
