using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace OyunSatis
{
    class CheckRealGamer : ICheckRealGamer
    {
        public bool CheckGamerInfo(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.IdNo), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
