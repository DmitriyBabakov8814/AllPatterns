using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Facade
{
    internal class facadeEx
    {
        private SystemOne _systemOne;
        private SystemTwo _systemTwo;
        private SystemThree _systemThree;

        public facadeEx(SystemOne systemOne, SystemTwo systemTwo, SystemThree systemThree)
        {
            _systemOne = systemOne;
            _systemTwo = systemTwo;
            _systemThree = systemThree;
        }

        public void OperationOne()
        {
            _systemOne.S1Method();
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
        public void OperationTwo()
        {
            _systemTwo.S2Method();
            _systemThree.S3Method();
        }
    }
}
