using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Komposition_And_More
{
    class HArmor : Armor
    {
        public HArmor(int thickness) : base(thickness, "гомогенная") { }
        public override bool IsPenetraited(Ammo projectile) {
            if (projectile is HECatridge)
                return projectile.GetPenetration() > thickness * Config._HArmour_VS_HE;
            else if (projectile is HEATCatridge)
                return projectile.GetPenetration() > thickness * Config._HArmour_VS_HEAT;
            else
                return projectile.GetPenetration() > thickness * Config._HArmour_VS_AP;
        }
    }
}
