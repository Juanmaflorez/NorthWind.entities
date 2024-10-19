﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.entities.ValueObjects
{
    public class UserAction
    {
        public DateTime CreatedDateTime { get; } = DateTime.Now;

        public string User => User;

        public string Description => Description;
    }
}
