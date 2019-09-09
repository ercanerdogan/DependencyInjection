using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection
{
    interface IVehicle
    {
        string Accelerate();
        void Break();
        void leftSignal();
        void rightSignal();
        void Shift();

    }
}
