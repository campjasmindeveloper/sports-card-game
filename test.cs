using kartoyun.siniflar;
using kartoyun.soyut_sinif;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kartoyun
{    
    public class test
    {
        
        Random random = new Random();

        Bilgisayar bilgisayar = Bilgisayar.nesnever();
        Kullanici kullanici = Kullanici.nesnever();

        public List<Futbolcu> futbolcular = new List<Futbolcu>(); //Tüm kartların listesini tutar
        public List<Basketbolcu> basketbolcular = new List<Basketbolcu>();

       public int kalankart = 16; public int kartno = 0; public int pcsayi = -1; public int kontrol = -1;

        public void kartolustur()
        {
            Futbolcu messi = new Futbolcu("Lionel Messi", "Barcelona", 100, 75, 90);
            Futbolcu ronaldo = new Futbolcu("Cristiano Ronaldo", "Juventus", 95, 80, 90);
            Futbolcu javi = new Futbolcu("Javi Martinez", "Bayern Münih", 75, 70, 80);
            Futbolcu kylian = new Futbolcu("Kylian Mbappe", "Paris Saint Germain", 80, 90, 75);
            Futbolcu terry = new Futbolcu("John Terry", "Aston Villa", 70, 65, 75);
            Futbolcu neymar = new Futbolcu("Neymar Santos", "Paris Saint Germain", 95, 90, 90);
            Futbolcu salah = new Futbolcu("Muhammed Salah", "Liverpool", 80, 90, 90);
            Futbolcu suarez = new Futbolcu("Luiz Suarez", "Atletico Madrid", 80, 75, 80);

            Basketbolcu james = new Basketbolcu("Lebron James", "Los Angeles Lakers", 85,80,95);
            Basketbolcu Curry = new Basketbolcu("Stephen Curry", "Golden State Warriors", 85, 95, 90);
            Basketbolcu durant = new Basketbolcu("Kevin Durant", "Brooklyn Nets", 80, 90, 75);
            Basketbolcu harden = new Basketbolcu("James Harden", "Houston Rockets", 80, 80, 75);
            Basketbolcu westbrook = new Basketbolcu("Russell Westbrook", "Washington Wizards", 85, 100, 95);
            Basketbolcu lillard = new Basketbolcu("Damian Lillard", "Portland Trail Blazers", 90, 100, 75);
            Basketbolcu kyrie = new Basketbolcu("Kyrie Irving", "Brooklyn Nets", 85, 80, 95);
            Basketbolcu paul = new Basketbolcu("Chris Paul", "Oklohoma City Thunder", 90, 80, 75);

            futbolcular.Add(messi); futbolcular.Add(ronaldo); futbolcular.Add(javi); futbolcular.Add(kylian);
            futbolcular.Add(terry); futbolcular.Add(neymar); futbolcular.Add(salah); futbolcular.Add(suarez);

            basketbolcular.Add(james); basketbolcular.Add(Curry); basketbolcular.Add(durant); basketbolcular.Add(harden);
            basketbolcular.Add(westbrook); basketbolcular.Add(lillard); basketbolcular.Add(kyrie); basketbolcular.Add(paul);
        }

        public void kartdagit()
        {
            // kullanici kağıt dagit
            int sayi = random.Next(0, 8); bool durum;

            kullanici.kartlist_futbol.Add(futbolcular[sayi]);
            for (int i = 1; i < 4;)
            {
                durum = true;
                sayi = random.Next(0, 8);
                for (int j = 0; j < kullanici.kartlist_futbol.Count; j++)
                {
                    if (futbolcular[sayi] == kullanici.kartlist_futbol[j])
                    {
                        durum = false; break;
                    }
                }
                if (durum == true)
                {
                    kullanici.kartlist_futbol.Add(futbolcular[sayi]);
                    i++;
                }
            }
            sayi = random.Next(0, 8);
            kullanici.kartlist_basket.Add(basketbolcular[sayi]);
            for (int i = 1; i < 4;)
            {
                durum = true;
                sayi = random.Next(0, 8);
                for (int j = 0; j < kullanici.kartlist_basket.Count; j++)
                {
                    if (basketbolcular[sayi] == kullanici.kartlist_basket[j])
                    {
                        durum = false; break;
                    }
                }
                if (durum == true)
                {
                    kullanici.kartlist_basket.Add(basketbolcular[sayi]);
                    i++; 
                }
            }

            // Pc kart dagit
            
            for (int i = 0; i < futbolcular.Count; i++)
            {
                durum = true;
                for (int j = 0; j < kullanici.kartlist_futbol.Count; j++)
                {
                    if (futbolcular[i] == kullanici.kartlist_futbol[j])
                    {
                        durum = false;
                        break;
                    }
                }
                if (durum == true)
                {
                    bilgisayar.kartlist_futbol.Add(futbolcular[i]);
                }
            }

            for (int i = 0; i < basketbolcular.Count; i++)
            {
                durum = true;
                for (int j = 0; j < kullanici.kartlist_basket.Count; j++)
                {
                    if (basketbolcular[i] == kullanici.kartlist_basket[j])
                    {
                        durum = false;
                        break;
                    }
                }
                if (durum == true)
                {
                    bilgisayar.kartlist_basket.Add(basketbolcular[i]);
                }
            }            
        }
       
        public int oyunoyna(int index)// index pozisyon bilgisi değeri alıyor.. pozisyon değeri metodu
        {

            if (kartno == 0 || kartno == 1 || kartno == 2 || kartno == 3) // futbol
            {
                if (kullanici.kartlist_futbol[kartno].sporcu_PuanGoster(index) > bilgisayar.kartlist_futbol[pcsayi].sporcu_PuanGoster(index))
                {
                    kalankart -= 2;
                    kontrol = 1; kullanici._oyuncuSKOR += 10; kullanici.kartlist_futbol[kartno]._kartkullanildimi = true;
                    bilgisayar.kartlist_futbol[pcsayi]._kartkullanildimi = true; 
                }
                else if (kullanici.kartlist_futbol[kartno].sporcu_PuanGoster(index) < bilgisayar.kartlist_futbol[pcsayi].sporcu_PuanGoster(index))
                {
                    kalankart -= 2;
                    kontrol = 1; bilgisayar._oyuncuSKOR += 10; kullanici.kartlist_futbol[kartno]._kartkullanildimi = true;
                    bilgisayar.kartlist_futbol[pcsayi]._kartkullanildimi = true;
                }
                else
                {
                    kontrol = 0;
                }
            }
            if (kartno == 4 || kartno == 5 || kartno == 6 || kartno == 7) // basketbol
            {
                if (kullanici.kartlist_basket[kartno-4].sporcu_PuanGoster(index) > bilgisayar.kartlist_basket[pcsayi].sporcu_PuanGoster(index))
                {
                    kalankart -= 2;
                    kontrol = 1; kullanici._oyuncuSKOR += 10; kullanici.kartlist_basket[kartno-4]._kartkullanildimi = true;
                    bilgisayar.kartlist_basket[pcsayi]._kartkullanildimi = true;
                }
                else if (kullanici.kartlist_basket[kartno - 4].sporcu_PuanGoster(index) < bilgisayar.kartlist_basket[pcsayi].sporcu_PuanGoster(index))
                {
                    kalankart -= 2;
                    kontrol = 1; bilgisayar._oyuncuSKOR += 10; kullanici.kartlist_basket[kartno - 4]._kartkullanildimi = true;
                    bilgisayar.kartlist_basket[pcsayi]._kartkullanildimi = true;
                    
                }
                else
                {
                    kontrol = 0;
                }
            }

            return kontrol;
        }

    }
}
