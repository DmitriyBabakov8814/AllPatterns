using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.AbstractFactory.Weapons
{
    internal class Gun : IWeapons
    {
        public void Atack()
        {
            Console.WriteLine("GunAtack");
        }
    }
}
