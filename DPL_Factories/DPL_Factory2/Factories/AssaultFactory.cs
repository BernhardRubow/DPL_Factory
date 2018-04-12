using DPL_Factory2.Enemies;

namespace DPL_Factory2.Factories
{
    public class AssaultFactory : IEnemyFactory
    {
        public IEnemy CreateEnemy()
        {
            return new Assault("Klingon Assault Fighter");
        }
    }
}