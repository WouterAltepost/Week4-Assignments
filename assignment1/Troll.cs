using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Troll : Character
    {
        public Troll()
        {
            weapon = new AxeBehaviour();
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
