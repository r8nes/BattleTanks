using System;


namespace OOP_Komposition_And_More
{
    class HEATCatridge :Ammo
    {

        public HEATCatridge(Gun gun) : base(gun, "кумулятивный") { }

        public override int GetDamage()
        {
            return (int)(base.GetDamage()*Config._HEATDamage);
        }
    }
}
