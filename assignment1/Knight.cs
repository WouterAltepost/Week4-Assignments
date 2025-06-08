using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Knight : Character
    {
        public Knight()
        {
            weapon = new SwordBehaviour();
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
