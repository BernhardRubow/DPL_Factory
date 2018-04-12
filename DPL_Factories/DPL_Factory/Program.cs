using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DPL_Factory.Enemies;

namespace DPL_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            string enemyName = args[0];


            IEnemy enemy = GetEnemy(enemyName);
            enemy.Attack();
            enemy.Die();
            Console.ReadLine();
        }

        // class programm is aware of the different types of 
        // enemies. (bad idea)
        static IEnemy GetEnemy(string enemyName)
        {
            switch (enemyName)
            {
                case "XyxaraAssault":
                    return new XyxaraAssault();

                case "XyxaraBomber":
                    return new XyxaraBomber();

                case "XyxaraScout":
                    return new XyxaraScout();

                // violation of the open closed principle
                case "GalaxFighter":
                    return new GalaxFighter();

                default:
                    return null;
            }
        }
    }
}
