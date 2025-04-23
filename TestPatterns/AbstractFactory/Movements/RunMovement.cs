using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.AbstractFactory.Movements
{
    internal class RunMovement : IMovement
    {
        public void Start()
        {
            Console.WriteLine("Run");
        }
    }
}
