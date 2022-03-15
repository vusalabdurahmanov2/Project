using System;
using Gun.model;
namespace Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Daragin gulle tutmunu daxil edin:");
            int WeaponBullet = Convert.ToInt32(Console.ReadLine());
            Console.Write("daragdaki gulle sayini daxil edin:");
            int CurrentBullet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Daragin bosalma saniyesi daxil edin:");
            int GunMagazine = Convert.ToInt32(Console.ReadLine());
            Weapon gun1 = new Weapon(WeaponBullet, CurrentBullet, GunMagazine);     
            int key = 0;
            do
            {
                Console.WriteLine("Methodlardan birini secin\n");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        gun1.Shoot();
                        break;
                    case 2:
                        gun1.Reload();
                        break;
                    case 3:
                        gun1.Fire();
                        break;
                    case 4:
                        Console.WriteLine("4cu metod");
                        break;
                    case 5:
                        Console.WriteLine("5ci  metod");
                        break;
                    case 6:
                        Console.WriteLine("Sagolun");
                        break;
                    case 0:
                        Console.WriteLine("0ci  metod");
                        break;
                    default:
                        Console.WriteLine("Yanis daxil etdiniz");
                        break;
                }
            }while (key != 6);
            
        }
    }
}

