using Microsoft.AspNetCore.Http;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yolcu360.Service.Helpers
{
    public static class BaseUrl
    {

        public static string GetUrl(string entity)
        {
            return $"https://localhost:7079/Uploads/{entity}/";
        }
    }
}
