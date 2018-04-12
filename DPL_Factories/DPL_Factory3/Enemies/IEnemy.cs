namespace DPL_Factory3.Enemies
{
    public interface IEnemy
    {
        string Name { get; }
        void SetName(string name);
        void Attack();
        void Die();
    }
}