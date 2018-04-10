using System;

namespace DPL_Factory1.Enemies
{
    public class Bomber : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("The bomber lauches a photon torpedo.");
        }

        public void Die()
        {
            Console.WriteLine("The bomber explodes in a gigantic nuclear fusion.");
        }
    }
}