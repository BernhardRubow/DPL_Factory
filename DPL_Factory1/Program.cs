using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPL_Factory1.Enemies;

namespace DPL_Factory1
{
    /**
     * Simple factory example
     **/
    class Program
    {
        static void Main(string[] args)
        {
            string enemyName = args[0];

            EnemyFactory enemyFactory = new EnemyFactory();

            // now the main class 'program' isn't aware of
            // the enemy types anymore (good)
            // but its aware of the particular factory (bad)
            IEnemy enemy = enemyFactory.CreateInstance(enemyName.ToLower());

            enemy.Attack();
            enemy.Die();
        }
    }
}
