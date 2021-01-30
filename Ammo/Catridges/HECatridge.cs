using System;


namespace OOP_Komposition_And_More
{
    class HECatridge : Ammo
    {
        public HECatridge(Gun gun) : base(gun, "фугасный") { }

        public override int GetDamage()
        {
            return (int)base.GetDamage();
        }
    }

}
