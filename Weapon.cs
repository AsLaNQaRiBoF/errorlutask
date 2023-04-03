using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    internal class Weapon
    {
        public int daraginGulleTutum;
        public int daragdakiGulleSayi;
        public int daraginBowalmaSaniyesi;
        public bool otomatikAtiwModu = true;

        public Weapon(int daraginGulleTutumu, int  daragdakigulleSayi, int daraginBowalmaSaniyesi, bool otomatikAtiwModu)




        {
            if (daraginGulleTutumu<=0 || daragdakiGulleSayi<=0 || daraginBowalmaSaniyesi<=0)
            {
                Console.WriteLine("Yanliw parametirler qeyd olunmuwdur");
            }
            this.daraginGulleTutum = daraginGulleTutumu;
            this.daragdakiGulleSayi = daragdakiGulleSayi;
            this.daraginBowalmaSaniyesi = daraginBowalmaSaniyesi;
            this.otomatikAtiwModu = otomatikAtiwModu;
        }
        public void information()
        {
            Console.WriteLine($"Daragin gulle tutumu:{daraginGulleTutumu}");
            Console.WriteLine($"Daragdaki gulle sayi:{daragdakiGulleSayi}");
            Console.WriteLine($"Daragin bowalma saniyesi:{daraginBowalmaSaniyesi}");
            Console.WriteLine($"Atiw modunun rejimi:{otomatikAtiwModu}");
        }
        public void Shoot()
        {
            if (otomatikAtiwModu == true)
            {
                if (daragdakiGulleSayi > 0)
                {
                    Console.WriteLine("Atew Edildi");
                    daragdakiGulleSayi--;
                }

                else
                {
                    Console.WriteLine("Siz otomatik moddasiz");
                }
            }
        }
        public void Fire()
        {
            if (otomatikAtiwModu== false)
            {
                if (daragdakiGulleSayi > 0)
                {
                    Console.WriteLine($"Daraginizdaki gulle sayi:{(daragdakiGulleSayi / daraginGulleTutumu) * daraginBowalmaSaniyesi}");
                    daragdakiGulleSayi = 0;

                }
                else
                {
                    Console.WriteLine("Daragda Gulle Yoxdur");
                }
            }
        }
        public void ChangeFireMode()
        {
            otomatikAtiwModu = !otomatikAtiwModu;
            if (otomatikAtiwModu == false)
            {
                Console.WriteLine("Otomatik atiw modu aktiv edildi");
            }
            else
            {
                Console.WriteLine("Tekli atiw modu aktiv edildi");
            }
        }
        public void GetRemainBulletCount()
        {
            Console.WriteLine($"{daraginGulleTutumu-daragdakiGulleSayi}");
        }
        public void Reload()
        {
            this.daragdakiGulleSayi = daraginGulleTutumu;
            Console.WriteLine("Darag tam dolduruldu");
        }
    }
}
