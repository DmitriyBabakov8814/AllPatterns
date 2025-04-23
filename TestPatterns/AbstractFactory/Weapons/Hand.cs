using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.AbstractFactory.Weapons
{
    internal class Hand : IWeapons
    {
        public void Atack()
        {
            Console.WriteLine("HandAtack");
        }
    }
}
