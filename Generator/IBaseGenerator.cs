﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    public interface IBaseGenerator
    {
        public Type GeneratingType { get; }
        public object Generate();
    }
}
