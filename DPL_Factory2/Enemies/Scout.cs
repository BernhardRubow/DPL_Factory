using System;

namespace DPL_Factory2.Enemies
{
    public class Scout : IEnemy
    {
        public string Name { get; private set; }

        public void SetName(string name)
        {
            Name = name;
        }

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