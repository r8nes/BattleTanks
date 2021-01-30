using System;


namespace OOP_Komposition_And_More
{
    class MArmor : Armor
    {
        public MArmor(int thickness) : base(thickness, "многослойный") { }
        public override bool IsPenetraited(Ammo projectile)
        {
            if (projectile is APCatridge)
                return projectile.GetPenetration() > thickness * Config._MArmour_VS_AP;
            else if (projectile is HEATCatridge)
                return projectile.GetPenetration() > thickness * Config._MArmour_VS_HEAT;
            else
                return projectile.GetPenetration() > thickness * Config._MArmour_VS_HE;
        }
    }
}
