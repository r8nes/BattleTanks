using System;


namespace OOP_Komposition_And_More
{
     public abstract class Armor
    {
        public int thickness;
        public string type;

        public Armor(int thickness, string type) {
            this.thickness = thickness;
            this.type = type;
        }

        public virtual bool IsPenetraited(Ammo projectile) {
            return projectile.GetDamage() > thickness;
        }
    }
}
