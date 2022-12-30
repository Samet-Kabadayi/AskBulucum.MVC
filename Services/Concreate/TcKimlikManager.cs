using Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Services.Concreate
{
    public class TcKimlikManager : ITcKimlikService
    {
        public async Task<bool>  IsPErson(string FirstName, string LastName, long Tc, int BirthDay)
        {
            var client = new MernisTcDogrula.KPSPublicSoapClient(MernisTcDogrula.KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            var response = await client.TCKimlikNoDogrulaAsync(Tc,FirstName,LastName,BirthDay);

            var result = response.Body.TCKimlikNoDogrulaResult;
            return result;
        }      

        
    }
  
}
