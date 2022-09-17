using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Entities;

namespace GameProjectDemo.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " added");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " updated");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " deleted");
        }
    }
}
