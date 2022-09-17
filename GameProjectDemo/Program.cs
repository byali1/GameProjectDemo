using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProjectDemo.Abstract;
using GameProjectDemo.Adapters;
using GameProjectDemo.Concrete;
using GameProjectDemo.Entities;

namespace GameProjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseGamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(new Gamer
            {
                FirstName = "Ali Ilgın",
                LastName = "Kıdır",
                DateOfBirth = new DateTime(2001, 1, 1),
                NationalityId = "geçerli tc no",
                Id = 1

            });
            Console.ReadLine();


        }
    }
}
