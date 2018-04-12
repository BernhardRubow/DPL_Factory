using System;

namespace DPL_Factory2.Enemies
{
    public class Fighter : IEnemy
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

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