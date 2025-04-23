using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPatterns.AbstractFactory.Factories;
using TestPatterns.AbstractFactory.Movements;
using TestPatterns.AbstractFactory.Weapons;

namespace TestPatterns.AbstractFactory
{
    internal class CombatUnit
    {
        private IWeapons weapon;
        private IMovement movement;

        public CombatUnit(IStylesFactory styles)
        {
            weapon = styles.CreateWeapons();
            movement = styles.CreateMovement();
        }

        public void Move()
        {
            movement.Start();
        }

        public void Hit()
        {
            weapon.Atack();
        }
    }
}
