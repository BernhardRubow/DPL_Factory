namespace DPL_Factory3.Enemies
{
    public interface IEnemyFactory
    {
        IEnemy CreateLightEnemy();
        IEnemy CreateMediumEnemy();
        IEnemy CreateHeavyEnemy();
    }
}