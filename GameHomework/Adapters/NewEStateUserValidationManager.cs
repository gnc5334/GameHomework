using EStateServiceReference;
using GameHomework.Abstract;
using GameHomework.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using static EStateServiceReference.KPSPublicSoapClient;

namespace GameHomework.Concrete
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrula(Convert.ToInt64(user.IdentitiyNumber), user.FirstName.ToUpper(),
                user.LastName.ToUpper(), user.BirthYear);
        }
    }
}
