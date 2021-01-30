using System;

namespace OOP_Komposition_And_More
{
    public class Gun
    {
        private int caliber;
        private int barrelLength;

        public Gun(int cal, int lenth)
        {
            caliber = cal;
            barrelLength = lenth;
        }

        public int getCaliber()
        {
            return caliber;
        }

        public bool isOnTarget(int dice)
        {
            return (barrelLength + dice) > Config._gunTrashold;
        }

    }
}
