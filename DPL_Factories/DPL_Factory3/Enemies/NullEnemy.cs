﻿namespace DPL_Factory3.Enemies
{
    public class NullEnemy : IEnemy
    {
        public string Name { get; }

        public void SetName(string name)
        {
            
        }

        public void Attack()
        {
            // do nothing
        }

        public void Die()
        {
            // do nothing
        }
    }
}