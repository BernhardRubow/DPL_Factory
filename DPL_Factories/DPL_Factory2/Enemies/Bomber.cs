using System;

namespace DPL_Factory2.Enemies
{
    public class Bomber : IEnemy
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

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