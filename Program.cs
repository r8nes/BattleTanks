using System;


namespace OOP_Komposition_And_More
{
    class Program
    {

        static void Main(string[] args)
        {
            Panzer player1 = new Panzer("T-60", new Gun(122, 40), 90, 600);
            Panzer player2 = new Panzer("Тигр", new Gun(88, 50), 120, 650);

            string selectedStr;
            int selectedAmmo;
            int selectedArmor;
            

            while (true) {

                // Player 1

                Console.WriteLine("======== Игрок 1 ==========");
                selectedAmmo = -1;

                //ошибка тут
                while (player1.LoadedAmmo == null)
                {
                    while (selectedAmmo < 0 || selectedAmmo > 2) {
                        Console.WriteLine("Выбрать снаряд: ");
                        Console.WriteLine("0 - Фугасный");
                        Console.WriteLine("1 - Кумулятивный");
                        Console.WriteLine("2 -  Бронебойный");
                        selectedStr = Console.ReadLine();
                        int.TryParse(selectedStr, out selectedAmmo);
                    }
                    player1.LoadGun(Config.ammoTypes[selectedAmmo]);
                }
                Console.WriteLine();

                selectedArmor = -1;

                while (selectedArmor < 0 || selectedArmor > 2) {
                    Console.WriteLine("Выбрать броню: ");
                    Console.WriteLine("0 - Гомогенная");
                    Console.WriteLine("1 - Металлическая");
                    Console.WriteLine("2 - Многосоставная ");
                    selectedStr = Console.ReadLine();
                    int.TryParse(selectedStr, out selectedArmor);
                }
                player1.SelectArmor(Config.armorTypes[selectedArmor]);

                Console.WriteLine();
                Console.WriteLine("Игрок 1 - текущее состояние: ");
                Console.Write(player1.ToString());
                Console.WriteLine("Нажмите ENTER для выстрела");
                Console.ReadKey();

                Ammo flyingAmmo = (Ammo)player1.Shoot()?.Clone();
                if (flyingAmmo != null) {
                    player2.HandleHit(flyingAmmo);
                }
                if (player2.GetHealth() <= 0) {
                    Console.WriteLine($"Танк игрока 2 уничтожен");
                    break;
                }

                // Player 2 
                Console.WriteLine("======== Игрок 2 ==========");
                selectedAmmo = -1;
                while (player2.LoadedAmmo == null)
                {
                    while (selectedAmmo < 0 || selectedAmmo > 2)
                    {
                        Console.WriteLine("Выбрать снаряд: ");
                        Console.WriteLine("0 - Фугасный");
                        Console.WriteLine("1 - Кумулятивный");
                        Console.WriteLine("2 -  Бронебойный");
                        selectedStr = Console.ReadLine();
                        int.TryParse(selectedStr, out selectedAmmo);
                    }
                    player2.LoadGun(Config.ammoTypes[selectedAmmo]);
                }
                Console.WriteLine();
                selectedArmor = -1;
                while (selectedArmor < 0 || selectedArmor > 2)
                {
                    Console.WriteLine("Выбрать броню: ");
                    Console.WriteLine("0 - Гомогенная");
                    Console.WriteLine("1 - Стальная");
                    Console.WriteLine("2 - Многосоставная ");
                    selectedStr = Console.ReadLine();
                    int.TryParse(selectedStr, out selectedArmor);
                }
                player2.SelectArmor(Config.armorTypes[selectedArmor]);

                Console.WriteLine();
                Console.WriteLine("Игрок 2 - текущее состояние: ");
                Console.Write(player2.ToString());
                Console.WriteLine("Нажмите ENTER для выстрела");
                Console.ReadKey();

                flyingAmmo = (Ammo)player2.Shoot()?.Clone();
                if (flyingAmmo != null)
                {
                    player1.HandleHit(flyingAmmo);
                }
                if (player1.GetHealth() <= 0)
                {
                    Console.WriteLine($"Танк игрока 1 уничтожен");
                    break;
                }
            }
        }
    }
}
