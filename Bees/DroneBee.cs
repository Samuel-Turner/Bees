using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    class DroneBee : Bee
    {
        public DroneBee()
        {
            Health = 100;
            IsDead = false;
            HealthLimit = 50;
        }
    }
}
