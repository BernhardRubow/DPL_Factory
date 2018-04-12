using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPL_Factory3.Enemies.Klingon
{
    public class VorCha : Enemy
    {
        public VorCha(params string[] list)
        {
            base.weapons = list;
        }
    }
}
