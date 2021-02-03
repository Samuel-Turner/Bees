using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    interface IBee
    {
        float Health { get; set; }
        bool IsDead { get; set; }
        float HealthLimit { get; set; }
        void Damage(int damageDealt);
        void CheckDead();
    }
}
