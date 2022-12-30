using Microsoft.Extensions.Configuration;
using NETCore.Encrypt.Extensions;
using Services.ExtraMetots.Abstract;

namespace Services.ExtraMetots.Concreate
{
    public class ConvertToPassword : IExtraMetot
    {
        private readonly IConfiguration _configuration;
        public ConvertToPassword(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string DoMD5HashedString(string password)
        {
            string md5Salt = _configuration.GetValue<string>("AppSettings:MD5Salt");
            string salted = password + md5Salt;
            string hashed = salted.MD5();
            return hashed;
        }    
    }
}
