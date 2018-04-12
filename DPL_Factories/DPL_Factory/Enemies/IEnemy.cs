using System;

namespace DPL_Factory.Enemies
{
    public interface IEnemy
    {
        void Attack();
        void Die();
    }

    public class XyxaraAssault : IEnemy
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

    public class XyxaraBomber : IEnemy
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

    public class XyxaraScout : IEnemy
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

    public class GalaxFighter : IEnemy
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

    public class NullEnemy : IEnemy
    {
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