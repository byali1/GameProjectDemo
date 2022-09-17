using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;
using GameProjectDemo.MernisServiceReference;

namespace GameProjectDemo.Adapters
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            try
            {
                KPSPublicSoapClient client = new KPSPublicSoapClient();
                return client.TCKimlikNoDogrula(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(),
                    gamer.DateOfBirth.Year);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
