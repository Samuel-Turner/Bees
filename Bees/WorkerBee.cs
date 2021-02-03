using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    class WorkerBee : Bee
    {
        public WorkerBee()
        {
            Health = 100;
            IsDead = false;
            HealthLimit = 70;
        } 
    }
}
