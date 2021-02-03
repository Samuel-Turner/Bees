using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    public class Bee
    {
        public double Health { get; set; }
        public bool IsDead { get; set; }
        public double HealthLimit { get; set; }
        public void Damage(int damageDealt) 
        {
            if ((!IsDead) && (damageDealt < 100) && (damageDealt > 0))
            {
                Health -= damageDealt * (Health/100);
                CheckDead();
            }
        }
        private void CheckDead() 
        {
            if (Health < HealthLimit)
            {
                IsDead = true;
            }
        }
        public Bee() 
        {
            Health = 100;
            IsDead = false;
        }
    }
}
