using System;

namespace DPL_Factory3.Enemies
{
    public class Enemy : IEnemy
    {
        protected string[] weapons;

        public string Name { get; private set; }
        public void SetName(string name)
        {
            Name = name;
        }

        public void Attack()
        {
            foreach (var w in weapons)
            {
                Console.WriteLine($"{Name} fires {w}");
            }
        }

        public virtual void Die()
        {
            Console.WriteLine($"{Name} explodes");
        }
    }
}