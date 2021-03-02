using GameStore.Adapter.Abstract;
using GameStore.Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Adapter.Concrete
{
    public class SubscriberMernisAdapter : ISubscriberCheckService
    {
        public bool Verification(Subscriber subscriber)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(
                Convert.ToInt64(subscriber.NationalityId),
                subscriber.FirstName.ToUpper(),
                subscriber.LastName.ToUpper(),
                subscriber.DateOfBirth.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
