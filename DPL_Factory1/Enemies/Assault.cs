using System;

namespace DPL_Factory1.Enemies
{
    public class Assault : IEnemy
    {
        public void Attack()
        {
            Console.WriteLine("The assault fighter fires his deadly tachyon twin lasers");
        }

        public void Die()
        {
            Console.WriteLine("The assault fighter explodes.");
        }
    }
}