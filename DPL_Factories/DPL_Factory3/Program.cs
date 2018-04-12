using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DPL_Factory3.Enemies;

namespace DPL_Factory3
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnemyFactory enemyFactory = LoadFactory();

            PrintHeader("LIGHT FIGHTER");
            var lightEnemy = enemyFactory.CreateLightEnemy();
            lightEnemy.Attack();
            lightEnemy.Die();

            PrintHeader("Medium FIGHTER");
            var mediumEnemy = enemyFactory.CreateMediumEnemy();
            mediumEnemy.Attack();
            mediumEnemy.Die();

            PrintHeader("Heavy FIGHTER");
            var heavyEnemy = enemyFactory.CreateHeavyEnemy();
            heavyEnemy.Attack();
            heavyEnemy.Die();

            Console.ReadLine();
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

        // simple helper
        private static void PrintHeader(string header)
        {
            Console.WriteLine("\n"+header);
        }
    }
}
