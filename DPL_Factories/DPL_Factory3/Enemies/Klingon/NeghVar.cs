using System;


namespace DPL_Factory3.Enemies.Klingon
{
    public class NeghVar : Enemy
    {
        public Action customDieAction;

        public NeghVar(params string[] list)
        {
            base.weapons = list;
        }

        public override void Die()
        {
            if (customDieAction == null)
                Console.WriteLine($"{base.Name} drown in never ending exposions");
            else
                customDieAction();
        }
    }
}