using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Komposition_And_More
{
    class FArmor : Armor
    {
        public FArmor(int thickness) : base(thickness, "металлическая") { }
        public override bool IsPenetraited(Ammo projectile)
        {
            if (projectile is HEATCatridge)
                return projectile.GetPenetration() > thickness * Config._FArmour_VS_HEAT;
            else if (projectile is HECatridge)
                return projectile.GetPenetration() > thickness * Config._FArmour_VS_HE;
            else
                return projectile.GetPenetration() > thickness * Config._FArmour_VS_AP;
        }
    }
}
