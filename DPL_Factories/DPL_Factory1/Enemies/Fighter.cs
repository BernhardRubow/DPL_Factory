using System;

namespace DPL_Factory1.Enemies
{
    public class Fighter : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("The Fighter fires its huge gatling gun.");
        }

        public void Die()
        {
            Console.WriteLine("The fighter implodes to small pieces.");
        }
    }
}