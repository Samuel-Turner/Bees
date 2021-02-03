using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    public interface IBee
    {
        double Health { get; set; }
        bool IsDead { get; set; }
        double HealthLimit { get; set; }
        void Damage(int damageDealt);
        void CheckDead();
        String Print();
    }
}
