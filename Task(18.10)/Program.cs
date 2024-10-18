using System.Runtime.InteropServices;

namespace Task_18._10_
{
    internal class Program
    {
        static void Main(string[] args)
        {




            bool condition = false;

            string input;
            string input2;
            string name;
            int charger = 40;
            int bulletNum;
            bool fireMod = false;
            int addBullet;

            Weapon weapon = null;

            do
            {
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Silah daxil etmek ucun");
                Console.WriteLine("2 - Shoot metodu üçün");
                Console.WriteLine("3 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("4 - Reload metodu üçün");
                Console.WriteLine("5 - ChangeFireMode metodu üçün");
                Console.WriteLine("6 - Gulle elave etmek ucun");
                Console.WriteLine("7 - Proqramdan dayandırmaq üçün");

                Console.WriteLine(" ");

                Console.WriteLine("Zehmet olmasa yuxarida verilenlere esasen qiymet daxil edin:");
                input = Console.ReadLine();


                switch (input)
                {
                    case "1":

                        Console.Clear();
                        Console.Write("Zehmet olmasa silah adini daxil edin:");
                        name = Console.ReadLine();

                        Console.WriteLine(" ");
                        bool condition1;
                        do
                        {

                            Console.WriteLine("Zehmet olmasa daraqdaki tutumun daxil edin (Daraq tutumu 0 ve 40 arasi olmalidir.) :");
                            condition1 = int.TryParse(Console.ReadLine(), out charger);
                            if (charger > 40)
                            {
                                condition1 = false;
                                Console.WriteLine("Duzgun qiymet daxil etmediniz.");
                                Console.WriteLine(" ");

                            }

                        }
                        while (!condition1);

                        Console.WriteLine(" ");

                        do
                        {
                            Console.WriteLine("Zehmet olmasa gulle sayini daxil edin:");
                            condition1 = int.TryParse(Console.ReadLine(), out bulletNum);

                        } while (!condition1);

                        Console.WriteLine(" ");

                        do
                        {
                            Console.WriteLine("Zehmet olmasa silah modunu secin:");
                            Console.WriteLine("Avomatik mod ucun 1, tekli mod ucun 0 daxil edin:");
                            input2 = Console.ReadLine();
                            switch (input2)
                            {
                                case "1":
                                    fireMod = true;
                                    break;
                                case "0":
                                    fireMod = false;
                                    break;
                                default:
                                    Console.WriteLine("Zehmet olmasa duzgun secim edin.");
                                    break;
                            }

                        } while (input2 != "1" && input2 != "0");

                        weapon = new Weapon(name, charger, bulletNum, fireMod);
                        Console.WriteLine("Silah ugurlu bir sekilde yaradildi");

                        break;

                    case "0":

                        Console.Clear();
                        Console.WriteLine(" ");
                        if (weapon != null)
                        {
                            if (fireMod)
                            {
                                Console.WriteLine($"Silahin adi: {weapon.weaponName}, Daraq tutumu: {weapon.Charger}, Daraqda olan gulle sayi: {weapon.chargeBulletNum}, Gulle sayi: {weapon.BulletNum} , Silah modu: Avtomatik");
                            }
                            else
                            {
                                Console.WriteLine($"Silahin adi: {weapon.weaponName}, Daraq tutumu: {weapon.Charger}, Daraqda olan gulle sayi: {weapon.chargeBulletNum}, Gulle sayi: {weapon.BulletNum} , Silah modu: Tekli");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa ilk once silah yaradin.");
                        }
                        break;
                    case "2":
                        Console.Clear();

                        if (weapon != null)
                        {
                            weapon.Shoot();
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa ilk once silah yaradin.");
                        }
                        break;
                    case "3":
                        Console.Clear();

                        if (weapon != null)
                        {
                            weapon.GetRemainBulletCount();
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa ilk once silah yaradin.");
                        }
                        break;
                    case "4":
                        Console.Clear();

                        if (weapon != null)
                        {
                            weapon.Reload();
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa ilk once silah yaradin.");
                        }
                        break;
                    case "5":
                        Console.Clear();
                        if (weapon != null)
                        {
                            weapon.ChangeFireMode();
                        }
                        else
                        {
                            Console.WriteLine("Zehmet olmasa ilk once silah yaradin.");
                        }
                        break;
                    case "6":
                        bool condition2;
                        do
                        {


                            if (weapon != null)
                            {
                                Console.WriteLine("Zehmet olmasa elave etmek istediyiniz gulle sayini daxil edin:");
                                condition2 = int.TryParse(Console.ReadLine(), out addBullet);
                                if (addBullet > 0)
                                {
                                    weapon.addBullet(addBullet);
                                    Console.WriteLine($"{addBullet} gulle elave olundu.");
                                }
                            }
                            else
                            {
                                condition2 = true;
                                Console.WriteLine("Zehmet olmasa ilk once silah yaradin");
                            }

                        } while (!condition2);
                        break;
                    case "7":
                        Console.WriteLine("Proqramdan cixilir...");
                        condition = true;
                        break;
                    default:
                        Console.WriteLine("Zehmet olmasa duzgun secim edin.");
                        break;
                }

            } while (!condition);



        }
    }
}
