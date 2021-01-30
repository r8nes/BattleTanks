using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Komposition_And_More
{
    public abstract class Ammo : ICloneable
    {
        Gun gun;
        public string type;

        public Ammo(Gun someGun, string type)
        {
            gun = someGun;
            this.type = type;
        }
        public virtual int GetDamage()
        {
            return gun.getCaliber() * Config._defaultDamage;
        }

        public int GetPenetration()
        {
            return gun.getCaliber();
        }
        public object Clone() {
            return MemberwiseClone();
        }

        public override string ToString()
        {
            return $"Снаряд " + type + " к пушке калибра " + gun.getCaliber();
        }

    }
}
