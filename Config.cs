using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Komposition_And_More
{
   public static class Config
    {
        public static List<string> ammoTypes = new List<string> { "фугасный", "кумулятивный", "подкалиберный" };

        public static List<string> armorTypes = new List<string> { "гомогенная", "металлическая", "многослойная" };

        //трешхолд для пушки значени, когда снаряд попал в цель
        
        public static int _gunTrashold = 100;

        //дефолтный коэфициент для заброневого действия базового снаряда

        public static int _defaultDamage = 3;

        //коэффициенты урона для снарядов разных типов

        public static double _HEDamage = 1.0;
        public static double _HEATDamage = 0.6;
        public static double _APDamage = 0.3;

        //коэффициенты стойкости брони

        //для гомогенной:
       
        public static double _HArmour_VS_HE = 1.2;
        public static double _HArmour_VS_HEAT = 1.0;      
        public static double _HArmour_VS_AP = 0.7;

        //для металлической брони

        public static double _FArmour_VS_HE = 1.0;
        public static double _FArmour_VS_HEAT = 0.8;     
        public static double _FArmour_VS_AP = 1.2;

        //Для многослойной брони

        public static double _MArmour_VS_HE = 0.8;
        public static double _MArmour_VS_HEAT = 1.2;       
        public static double _MArmour_VS_AP = 1.0;

        //Значение колличества зарядов

        public static int _baseStorage = 10;
    }
}
