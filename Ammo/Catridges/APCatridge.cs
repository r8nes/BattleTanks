using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Komposition_And_More
{
    class APCatridge : Ammo
    {
        public APCatridge(Gun gun) : base(gun, "подкалиберный") { }
        public override int GetDamage() {
            return (int)(base.GetDamage() * Config._APDamage);
        }
    }
}
