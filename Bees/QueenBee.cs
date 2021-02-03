using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    public class QueenBee : Bee
    {
        public QueenBee()
        {
            Health = 100;
            IsDead = false;
            HealthLimit = 20;
        }
    }
}
