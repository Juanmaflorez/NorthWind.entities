﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.entities.Interface
{
    public interface IProductService
    {
        void Add(string user, string productName);
    }
}
