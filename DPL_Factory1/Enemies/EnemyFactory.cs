using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DPL_Factory1.Enemies
{
    public class EnemyFactory
    {
        // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private Dictionary<string, Type> enemies;


        public EnemyFactory()
        {
            LoadEnemyTypesThatCanBeProduced();
        }

        public IEnemy CreateInstance(string enemyName)
        {
            // using null object design pattern
            var t = enemies.ContainsKey(enemyName) 
                ? enemies[enemyName]
                : typeof(NullEnemy);

            // return a new instance like using 'new'
            return Activator.CreateInstance(t) as IEnemy;
        }

        /**
         * Store all available enemy types in this programm
         * in a dictionary by using reflection
         */
        public void LoadEnemyTypesThatCanBeProduced()
        {
            enemies = new Dictionary<string, Type>();

            Type[] enemyTypesInAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in enemyTypesInAssembly)
            {
                if (type.GetInterface(typeof(IEnemy).ToString()) != null)
                {
                    enemies.Add(type.Name.ToLower(), type);
                }
            }
        }
    }
}
