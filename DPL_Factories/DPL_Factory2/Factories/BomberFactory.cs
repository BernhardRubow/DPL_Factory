﻿using DPL_Factory2.Enemies;

namespace DPL_Factory2.Factories
{
    public class BomberFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Bomber();
        }
    }
}