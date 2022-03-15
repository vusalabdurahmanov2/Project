using System;
using System.Collections.Generic;
using System.Text;

namespace Gun.model
{

    class Weapon
    {   public int WeaponBullet;//daragin gulle tutumu
        public int CurrentBullet;//daragdaki gulle sayisi
        public double GunMagazine;//daragin bosalma saniyesi
        public Weapon(int WeaponBullet, int CurrentBullet, double GunMagazine)
        {
            if (WeaponBullet > 0) this.WeaponBullet = WeaponBullet; this.WeaponBullet = WeaponBullet;
            while (WeaponBullet <= 0)
            {
                Console.Write("Daragin gulle tutumunu dogru daxil edin:");
                WeaponBullet = Convert.ToInt32(Console.ReadLine());
            }
            while (WeaponBullet< CurrentBullet)
            {
                Console.WriteLine("cari gulle sayi daragdaki gulle tutumdan cox ola bilmez");
                Console.Write("Daragin gulle tutumunu dogru daxil edin:");
                WeaponBullet = Convert.ToInt32(Console.ReadLine());
                Console.Write("Daragin gulle sayisni dogru daxil edin:");
                CurrentBullet = Convert.ToInt32(Console.ReadLine());
            }
            this.CurrentBullet = CurrentBullet;
            if (GunMagazine>0) this.GunMagazine = GunMagazine;
            while(GunMagazine <= 0)
            {
                Console.Write("Daragin bosalmas saniyesini dogru daxil edin:");
                GunMagazine = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void  IsNegative()
        {

        }
        public void Shoot()
        {
            if (CurrentBullet > 0)
            {
                CurrentBullet -= 1;
                Console.WriteLine("BOOOM!!");
            }
            else
            {
                Console.WriteLine("You Must Reload Gun");
            }
        }
        public void Fire()
        {
            double BulletEmptyTime = 0;
            double OneBulletShotTime = GunMagazine / CurrentBullet;//1 gullenin boslam saniye
            while (CurrentBullet > 0)
            {  
                CurrentBullet -= 1;
                BulletEmptyTime = BulletEmptyTime + OneBulletShotTime;
            }
            Console.WriteLine($"time:{BulletEmptyTime}");
        }
        public int GetRemainBulletCount()
        {
            return WeaponBullet- CurrentBullet;
        }
        public void Reload()
        {
            Console.WriteLine(WeaponBullet - CurrentBullet);
            Console.WriteLine($"{WeaponBullet - CurrentBullet} Gulle dolduruldu");
            CurrentBullet = WeaponBullet;
        }
    }
}
