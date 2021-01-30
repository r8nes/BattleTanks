using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Komposition_And_More
{
    public class Panzer
    {
        private string model;
        private Gun gun;
        private List<Armor> armors;
        private List<Ammo> ammos;
        private int health;
        private int baseAmmo = Config._baseStorage;
        public Ammo LoadedAmmo { get; set; }
        public Armor SelectedArmor { get; set; }

        private void AddArmors(int armorWidth)
        {
            armors.Add(new HArmor(armorWidth));
            armors.Add(new FArmor(armorWidth));
            armors.Add(new MArmor(armorWidth));
        }

        private void LoadAmmos()
        {
            for (int i = 0; i < baseAmmo; i++)
            {
                ammos.Add(new HECatridge(gun));
                ammos.Add(new HEATCatridge(gun));
                ammos.Add(new APCatridge(gun));
            }
        }

        public Panzer(string name, Gun gun, int armorWidth, int health)
        {
            model = name;
            this.gun = gun;
            this.health = health;
            armors = new List<Armor>();
            ammos = new List<Ammo>();
            AddArmors(armorWidth);
            LoadAmmos();
            LoadedAmmo = null;
            SelectedArmor = armors[0];
        }
        public void SelectArmor(string type)
        {
            for (int i = 0; i < armors.Count; i++)
            {
                if (armors[i].type == type)
                {
                    SelectedArmor = armors[i];
                    break; }
            }
        }
        public void LoadGun(string type)
        {
            for (int i = 0; i < ammos.Count; i++)
            {
                if (ammos[i].type == type)
                {
                    LoadedAmmo = ammos[i];
                    Console.WriteLine("заряжено!");
                    return;
                }
                
            }
            Console.WriteLine($"сорян, командир, " + type + " закончились!");
        }

        public Ammo Shoot() {
            if (LoadedAmmo != null) { 
                Ammo firedAmmo = (Ammo)LoadedAmmo.Clone();
                ammos.Remove(LoadedAmmo);
                Random rnd = new Random();
                int dice = rnd.Next(0, 100);
                bool hit = gun.isOnTarget(dice);
                if (hit)
                {
                    Console.WriteLine("Попадание!");  
                    return firedAmmo;
                }
                else {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Промах!");
                    Console.ResetColor();
                    return null;
                }
            }
                else
                Console.WriteLine("не заряжено");
            return null;
        }
        public void HandleHit(Ammo projectile) {
            if (SelectedArmor.IsPenetraited(projectile))
            {
                this.health -= projectile.GetDamage();
            }
            else 
                Console.WriteLine("Броня не пробита");
        }

        public int GetHealth() {
            return health; 
       }

        public override string ToString()
        {
            return 
                $"Танк " + model + "\n" + "Здоровье текущщее = " + health +
                ";\n" + "Заряженный снаряд: " + LoadedAmmo.type + "; Выбранная броня: " + SelectedArmor.type + ".\n";
        }
    }
}
