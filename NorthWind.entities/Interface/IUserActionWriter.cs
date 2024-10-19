using NorthWind.entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.entities.Interface
{
    public interface IUserActionWriter
    {
        void Write(UserAction action);
    }
}
