using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.AbstractFactory.Movements;
using TestPatterns.AbstractFactory.Weapons;

namespace TestPatterns.AbstractFactory.Factories
{
    internal interface IStylesFactory
    {
        IMovement CreateMovement();
        IWeapons CreateWeapons();
    }
}
