using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPL_Factory3.Enemies.Klingon
{
    public class KlingonFactory : IEnemyFactory
    {
        public IEnemy CreateLightEnemy()
        {
            var light = new BirdOfPrey("laser");
            light.SetName("Ch\'Tang");
            return light;
        }

        public IEnemy CreateMediumEnemy()
        {
            var medium = new VorCha("laser", "photon torpedos");
            medium.SetName("Vor\'Cha");
            return medium;
        }

        public IEnemy CreateHeavyEnemy()
        {
            var heavy = new NeghVar("laser", "photon torpedo", "red matter bomb");
            heavy.SetName("Neg\'Var");
            heavy.customDieAction = () =>
            {
                Console.WriteLine($"{heavy.Name}: The red matther detonates and creates a singularity");
            };
            return heavy;
        }
    }
}
