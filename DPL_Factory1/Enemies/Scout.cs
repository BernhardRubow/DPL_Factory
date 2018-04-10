using System;

namespace DPL_Factory1.Enemies
{
    public class Scout : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("The scout fires his weak pulse laser.");
        }

        public void Die()
        {
            Console.WriteLine("The scout breaks apart leaving nothing to remain of it.");
        }
    }
}