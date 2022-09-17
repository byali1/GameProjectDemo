using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        //Fake
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return false;
        }
    }
}
