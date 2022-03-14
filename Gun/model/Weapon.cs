using System;
using System.Collections.Generic;
using System.Text;

namespace Gun.model
{

    class Weapon
    {
        public int WeaponBullet;//daragin gulle tutumu
        public int CurrentBullet;//daragdaki gulle sayisi
        public double CombOfTheWeaponEmpty;//daragin bosalma saniyesi
        public Weapon(int WeaponBullet, int CurrentBullet, double CombOfTheWeaponEmpty)
        {
            this.WeaponBullet = WeaponBullet;
            this.CurrentBullet = CurrentBullet;
            this.CombOfTheWeaponEmpty = CombOfTheWeaponEmpty;
        }
        public void Shoot()
        {
            if (CurrentBullet > 0)
            {
                CurrentBullet -= 1;
                Console.WriteLine("BOOOM!!One Bullet Shoted");
            }
            else
            {
                Console.WriteLine("You Must Reload Gun");
            }
            

        }
        public void Fire()
        {
            double BulletEmptyTime = 0;
            double OneBulletShotTime = CombOfTheWeaponEmpty / CurrentBullet;//1 gullenin boslam saniye
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
