using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public class Queen : Character
    {
        public Queen()
        {
            weapon = new KnifeBehaviour();
        }

        public override void Fight()
        {
            weapon.UseWeapon();
        }
    }
}
