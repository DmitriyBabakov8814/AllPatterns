﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Observer
{
    internal interface IObserver
    {
        void Update(Object o);
    }
}
