using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DPL_Factory2.Enemies;

namespace DPL_Factory2
{
    /**
     * Usage of the factory method pattern 
     */
    class Program
    {
        static void Main(string[] args)
        {
            IEnemyFactory enemyFactory = LoadFactory();

            IEnemy enemy = enemyFactory.CreateEnemy();

            enemy.Attack();
            enemy.Die();
        }

        /**
         * The factory to be used is configured in the application
         * settings
         */
        static IEnemyFactory LoadFactory()
        {
            string factoryName = Properties.Settings.Default.EnemyFactory;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as IEnemyFactory;
        }
    }
}
