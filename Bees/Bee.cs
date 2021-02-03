using System;
using System.Collections.Generic;
using System.Text;

namespace Bees
{
    class Bee
    {
        protected float Health { get; set; }
        protected bool IsDead { get; set; }
        protected float HealthLimit { get; set; }
        public void Damage(int damageDealt) 
        {
            if ((!IsDead) && (damageDealt < 100) && (damageDealt > 0))
            {
                Health -= damageDealt * Health;
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
