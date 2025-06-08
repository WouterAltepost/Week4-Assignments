using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    public abstract class Character
    {
        protected IWeaponBehaviour weapon;

        public IWeaponBehaviour Weapon
        {
            set { weapon = value; }
        }

        public abstract void Fight();
    }
}
