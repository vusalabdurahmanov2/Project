using System;
using Gun.model;
namespace Gun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Daragin gulle tutmunu daxil edin:");
            int WeaponBullet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("daragdaki gulle sayini daxil edin:");
            int CurrentBullet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Daragin bosalma saniyesi daxil edin:");
            int CombOfTheWeaponEmpty = Convert.ToInt32(Console.ReadLine());
            Weapon gun1 = new Weapon(WeaponBullet, CurrentBullet, CombOfTheWeaponEmpty);
            gun1.Fire();
            gun1.Shoot();
        }
    }
}
