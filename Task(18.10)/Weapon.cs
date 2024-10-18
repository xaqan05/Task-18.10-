using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18._10_
{
    public class Weapon
    {
        public string weaponName;

        private int _charger;
        private int _bulletNum;

        public bool changeMod;

        public int chargeBulletNum = 0;
        public int remainingBullet;

        public int Charger
        {
            get
            {
                return _charger;
            }
            set
            {
                if (value <= 41 && value > 0)
                {
                    _charger = value;
                    chargeBulletNum = value;
                }
            }
        }

        public int BulletNum
        {
            get
            {
                return _bulletNum;
            }
            set
            {
                if (value >= 0)
                {
                    _bulletNum = value;
                }
            }
        }

        public Weapon(string name, int charger, int bulletNum, bool weaponMode)
        {
            weaponName = name;
            _charger = charger;
            _bulletNum = bulletNum;
            changeMod = weaponMode;
        }

        public void Shoot()
        {
            if (chargeBulletNum == 0)
            {
                Console.Clear();
                Console.WriteLine("Silahi ilk once reload edin.");
            }
            else if (changeMod)
            {
                chargeBulletNum = 0;
                remainingBullet = chargeBulletNum;
                Console.WriteLine("Avtomatik modda oldugunuz ucun gulleniz bitdi.");
            }
            else
            {
                chargeBulletNum--;
                remainingBullet = Charger - chargeBulletNum;
                Console.WriteLine($"Tekli modda oldugu ucun 1 gulle istifade etdiniz.Daragda qalan gulle sayi: {chargeBulletNum}. {BulletNum} gulleniz movcuddur.");
            }
        }
        public void GetRemainBulletCount()
        {
            int requiredBullet = Charger - chargeBulletNum;

            Console.WriteLine($"Daragda qalan gulle sayi: {chargeBulletNum}, Dolmasi ucun lazim olan gulle sayi: {requiredBullet} ");
        }

        public void Reload()
        {
            int missingBullets = Charger - chargeBulletNum;

            if (BulletNum == 0)
            {
                Console.WriteLine("Reload etmek ucun yeterli gulle yoxdur.");
            }
            else if (BulletNum <= missingBullets)
            {
                chargeBulletNum += BulletNum;  
                Console.WriteLine($"Silah qismen reload oldu, daraqdaki gulle sayı: {chargeBulletNum}");
                BulletNum = 0;  
            }
            else if(chargeBulletNum == Charger)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Daraq doludur.");
            }
            else
            {
                chargeBulletNum = Charger;  
                BulletNum -= missingBullets;  
                Console.WriteLine($"Silah tam reload oldu.");
            }

            Console.WriteLine($"Elimizde qalan gulle: {BulletNum}");

        }

        public void addBullet(int bullet)
        {
            BulletNum += bullet;
        }
        public void ChangeFireMode()
        {
            changeMod = !changeMod;

            if (changeMod)
            {
                Console.WriteLine("Silah avtomatik moda kecid etdi");
            }
            else
            {
                Console.WriteLine("Silah tekli moda kecid etdi");
            }
        }

        public void ShowInfo()
        {
            if (changeMod)
            {
                Console.WriteLine($"Silahin adi: {weaponName}, Daraq tutumu: {Charger}, Daraqda olan gulle sayi: {chargeBulletNum}, Gulle sayi: {BulletNum} , Silah modu: Avtomatik");
            }
            else
            {
                Console.WriteLine($"Silahin adi: {weaponName}, Daraq tutumu: {Charger}, Daraqda olan gulle sayi: {chargeBulletNum}, Gulle sayi: {BulletNum} , Silah modu: Tekli");
            }
        }
    }
}
