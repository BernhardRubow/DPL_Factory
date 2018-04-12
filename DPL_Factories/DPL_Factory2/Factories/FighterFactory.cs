using DPL_Factory2.Enemies;

namespace DPL_Factory2.Factories
{
    public class FighterFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Fighter();
        }
    }
}
