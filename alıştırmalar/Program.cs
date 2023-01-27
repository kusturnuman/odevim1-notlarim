using System;

namespace alıştırmalar
{
    class Program
    {
        static void Main(string[] args)
        {
           
             int sec, sayi;
             string o, oy;
             int a;
             Random rastgele = new Random();
             a = rastgele.Next(1, 100);
             Console.WriteLine("=> OYUN = EĞLENCE [HOŞGELDİNİZ]\n------------------------------------------");
             try
             {
                 do
                 {
                     Console.WriteLine("Oyunu kaç kişilik oynamak istersiniz?\n=>Bir Kişilik => 1\n=>İki Kişilik => 2");
                     Console.Write("Seçilen: ");
                     sec = Convert.ToInt32(Console.ReadLine());
                     Console.WriteLine("-------------------------------");
                     if (sec == 1)
                     {
                         Console.WriteLine("Oyunu Tek Kişilik Oynayacaksınız.\n--------------------------------");
                         Console.Write("İsminizi Giriniz: ");
                         o = Console.ReadLine();
                         Console.WriteLine("**\nOYUNUN AMACI:1-100 Arasında Sayı Girin ve benim aklımda tuttuğum sayıyı bulun.\n**\nNOT:Oyunu tekrar oynadığınız zaman aklımdaki sayı değişecektir.\n**");
                         do
                         {
                             Console.Write("'{0}' Bir Sayı Gir: ", o);
                             sayi = Convert.ToInt32(Console.ReadLine());
                             if (sayi < 1 || sayi > 100)
                             {
                                 Console.Write("=>HATA!!,1-100 Arasında Sayı Girmelisiniz.\n");
                             }
                             else if (sayi < a)
                             {
                                 Console.WriteLine("***Daha büyük bir sayı giriniz.***");
                             }
                             else if (sayi > a)
                             {
                                 Console.WriteLine("***Daha küçük bir sayı giriniz.***");
                             }
                             else if (sayi == a)
                             {
                                 Console.WriteLine("*****************************\n=>TEBRİKLER!! Bildin.'{0}'\n*****************************\n", o);
                             }
                         } while (sayi != a);
                     }
                     else if (sec == 2)
                     {
                         Console.WriteLine("Oyunu İki Kişilik Oynayacaksınız.\n--------------------------------");
                         Console.Write("OYUNCU-1 İsminizi Giriniz: ");
                         o = Console.ReadLine();
                         Console.Write("OYUNCU-2 İsminizi Giriniz: ");
                         oy = Console.ReadLine();
                         Console.WriteLine("**\nOYUNUN AMACI:1-100 Arasında Sayı Girin ve bilgisayarın tuttuğu sayıyı bulmaya çalışın.\n**\nNOT:Oyunu tekrar oynadığınız zaman bilgisayarın tuttuğ sayı değişecektir.\n**");
                         do
                         {
                             Console.Write("'{0}' Bir Sayı Gir: ", o);
                             sayi = Convert.ToInt32(Console.ReadLine());
                             if (sayi < 1 || sayi > 100)
                             {
                                 Console.Write("=>HATA!!,1-100 Arasında Sayı Girmelisiniz.[Sıranı Kaybettin]\n");
                             }
                             else if (sayi < a)
                             {
                                 Console.WriteLine("***Daha büyük bir sayı girmeliydin.***");
                             }
                             else if (sayi > a)
                             {
                                 Console.WriteLine("***Daha küçük bir sayı girmeliydin.***");
                             }
                             else if (sayi == a)
                             {
                                 Console.WriteLine("*****************************\n=>TEBRİKLER!! Bildin.'{0}'\n*****************************", o);
                                 Console.ReadKey();
                             }
                             Console.Write("'{0}' Bir Sayı Gir: ", oy);
                             sayi = Convert.ToInt32(Console.ReadLine());
                             if (sayi < 1 || sayi > 100)
                             {
                                 Console.Write("=>HATA!!,1-100 Arasında Sayı Girmelisiniz.[Sıranı Kaybettin]\n");
                             }
                             else if (sayi < a)
                             {
                                 Console.WriteLine("***Daha büyük bir sayı girmeliydin.***");
                             }
                             else if (sayi > a)
                             {
                                 Console.WriteLine("***Daha küçük bir sayı girmeliydin.***");
                             }
                             else if (sayi == a)
                             {
                                 Console.WriteLine("*****************************\n=>TEBRİKLER!! Bildin.'{0}'\n*****************************\n", oy);
                                 Console.ReadKey();
                             }
                         } while (sayi != a);
                     }
                     else if (sec != 1 || sec != 2)
                     {
                         Console.WriteLine("=>>>HATA!! [1 veya 2 kişilik oynayabilirsiniz]\n--------------------------------");
                     }
                 } while (sec != 1 || sec != 2);
             }
             catch { Console.WriteLine("*************************************\n=>HATA:Lütfen Sadece Sayısal Değer Giriniz.!!\n>>Programı Lütfen Tekrar Açın\n**************************************"); }
             Console.ReadKey();
           
           









            /*
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("C# Harf, Rakam, Özel Karakter Sayıcı ");
            Console.WriteLine("--------------------------------------------------------");
            Console.Write("Metni Girin :");
            string str = Console.ReadLine();

            int totalCharacter = 0, totalLetterChar = 0, totalDigitChar = 0, totalSpecialChar = 0;

            char[] strArray = str.ToCharArray();
            foreach (var item in strArray)
            {
                if (char.IsDigit(item))
                    totalDigitChar++;
                if (char.IsLetter(item))
                    totalLetterChar++;
                if (!char.IsLetterOrDigit(item))
                    totalSpecialChar++;
                totalCharacter++;
            }

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Girilen Metin : " + str);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Toplam Karakter Sayısı : " + totalCharacter);
            Console.WriteLine("Toplam Harf Sayısı : " + totalLetterChar);
            Console.WriteLine("Toplam Rakam Sayısı : " + totalDigitChar);
            Console.WriteLine("Toplam Özel Karakter Sayısı : " + totalSpecialChar);
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey();
            */










           /*
            //10 sayının tek mi çift mi olduğunu veren kod
            int[] sayigir = new int[10];
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.Write("Sayıyı giriniz..:");
                sayigir[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Çift Sayılar");
            Console.WriteLine("------------");

            for (i = 0; i <= 9; i++)
            {
                if (sayigir[i] % 2 == 0)
                {
                    Console.WriteLine(sayigir[i]);
                }
            } 
            Console.WriteLine("Tek Sayılar");
            Console.WriteLine("-----------");
            for (i = 0; i <= 9; i++)
            {
                if (sayigir[i] % 2 == 1)
                {
                    Console.WriteLine(sayigir[i]);
                } 
            }
            Console.ReadKey();
            */







            /*
            //ilk 50 asal sayının kodu
            int sayi = 2;
            int sayac = 0;
            int sayac2 = 0;
            int sayac3 = 0;
            Console.WriteLine("İlk 50 Asal Sayı");
            Console.WriteLine("==================");
            while (true)
            {

                sayac = 0;
                if (sayac2 == 50)
                {
                    break;
                }
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        sayac++;
                        break;
                    }

                }
                if (sayac == 0)
                {
                    sayac3++;
                    Console.Write(sayi + "\t");
                    if (sayac3 % 10 == 0)
                    {
                        Console.WriteLine();
                    }
                    sayac2++;
                }
                sayi++;
            }

            Console.ReadKey();
             */







            /*
            //hesap makinesi
            int sayi1_giris, sayi2_giris;

            double sonuc;

            string islem;

           Console.WriteLine("Bir sayı girin:");
            sayi1_giris = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("İkinci sayıyı girin:");
            sayi2_giris = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("İşlem seçin(*,/,+,-)");
            islem = Console.ReadLine();

            if (islem == "*")
            {
                sonuc = sayi1_giris * sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == "/")
            {
                sonuc = sayi1_giris / sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == "+")
            {
                sonuc = sayi1_giris + sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            if (islem == "-")
            {
                sonuc = sayi1_giris - sayi2_giris;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            */









            /*
            //vücut kitle endeksi
            double boy, kilo, indeks = 0;
            Console.Write("Boyunuzu m cinsinden Giriniz (Ör:1.65)  : ");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Kilonuzu Giriniz : ");
            kilo = Convert.ToDouble(Console.ReadLine());
            indeks = kilo / (boy * boy);
            Console.WriteLine("================================================");
            Console.WriteLine("Vücut Kitle İndexiniz : {0}", indeks);
            if (indeks < 18)
            {
                Console.WriteLine("Zayıf");
            }
            else if (indeks >= 18 && indeks < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (indeks >= 25 && indeks < 30)
            {
                Console.WriteLine("Kilolu");
            }
            else if (indeks >= 30 && indeks < 35)
            {
                Console.WriteLine("Obez");
            }
            else
            {
                Console.WriteLine("Ciddi Obez");
            }
            Console.ReadKey();
            *
            */







            /*
            // ders geçme kalma hesaplama
            int vize, final, ort;
            Console.Write("Vize notunu giriniz: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Final notunu giriniz: ");
            final = Convert.ToInt32(Console.ReadLine());
            ort = Convert.ToInt32(vize * 0.3 + final * 0.7);
            Console.WriteLine();
            Console.WriteLine("Ortalamanız = {0}", ort);
            Console.WriteLine();
            if (ort < 50 || final < 60)
                Console.WriteLine("Kaldınız.");
            else
                Console.WriteLine("Geçtiniz.");

            Console.ReadKey();
            */







            
            // bilgi yarışması
            /*
            for (; ; )
            {
                int p = 0;
                string s1;
                Console.Write("1. Soru-)Fatih Sultan Mehmet’in babası kimdir ?");
                s1 = Console.ReadLine();
                string c1;
                Console.WriteLine("Şıklar = a-1.Mehmet" + " b-Yıldırım Beyazıt" + " c-2.Murat" + " d-Kanuni");
                Console.Write("Cevabınız: ");
                c1 = Console.ReadLine();
                if (c1 == "c")
                {
                    p = p + 20;
                    Console.WriteLine("Tebrikler doğru cevap 20p kazandınız.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                }
                else
                {
                    p = p + 0;
                    Console.WriteLine("Yanlış cevap verdiniz 0p.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                    Console.WriteLine("Doğru Cevap 2.Murat olacaktı");
                }
                string s2;
                Console.Write("2. Soru-) Kıbrıs Barış Harekatı kaç yılında gerçekleşmiştir ?");
                s2 = Console.ReadLine();
                string c2;
                Console.WriteLine("Şıklar = a-1973" + " b-1970" + " c-1975" + " d-1974");
                Console.Write("Cevabınız: ");
                c2 = Console.ReadLine();
                if (c2 == "d")
                {
                    p = p + 20;
                    Console.WriteLine("Tebrikler doğru cevap 20p kazandınız.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                }
                else
                {
                    p = p + 0;
                    Console.WriteLine("Yanlış cevap verdiniz 0p.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                    Console.WriteLine("Doğru Cevap 1974 olacaktı");
                }
                string s3;
                Console.Write("3.Soru-) Tarihçilerin Kutbu olarak bilinen dünyaca ünlü tarihçimiz kimdir ?");
                s3 = Console.ReadLine();
                string c3;
                Console.WriteLine("Şıklar = a-Mehmet Fuat Köprülü" + " b-Halil İnalcık" + " c-İlber Ortaylı" + " d-Mehmet Genç");
                Console.Write("Cevabınız: ");
                c3 = Console.ReadLine();
                if (c3 == "b")
                {
                    p = p + 20;
                    Console.WriteLine("Tebrikler doğru cevap 20p kazandınız.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                }
                else
                {
                    p = p + 0;
                    Console.WriteLine("Yanlış cevap verdiniz 0p.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                    Console.WriteLine("Doğru Cevap Halil İnalcık");
                }
                string s4;
                Console.Write("4.Soru-) Fas'ın başkenti hangi şehirdir ?");
                s4 = Console.ReadLine();
                string c4;
                Console.WriteLine("Şıklar = a-Rabat" + " b-Kahire" + " c-Kanablanka" + " d-Beyrut");
                Console.Write("Cevabınız: ");
                c4 = Console.ReadLine();
                if (c4 == "a")
                {
                    p = p + 20;
                    Console.WriteLine("Tebrikler doğru cevap 20p kazandınız.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                }
                else
                {
                    p = p + 0;
                    Console.WriteLine("Yanlış cevap verdiniz 0p.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                    Console.WriteLine("Doğru Cevap Rabat olacaktı");
                }
                string s5;
                Console.Write("5.Soru-) İstiklal Marşımız hangi yıl yazılmıştır ?");
                s5 = Console.ReadLine();
                string c5;
                Console.WriteLine("Şıklar = a-1919" + " b-1920" + " c-1921" + " d-1922");
                Console.Write("Cevabınız: ");
                c5 = Console.ReadLine();
                if (c5 == "c")
                {
                    p = p + 20;
                    Console.WriteLine("Tebrikler doğru cevap 20p kazandınız.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                }
                else
                {
                    p = p + 0;
                    Console.WriteLine("Yanlış cevap verdiniz 0p.");
                    Console.WriteLine("Şu anki toplam puanınız: " + p);
                    Console.WriteLine("Doğru Ceavp 1921 olacaktı bunu bilemediysen yazıklar olsun");
                }

                Console.ReadKey();
            }
            */









            /*  
            //Haftanın günlerini bir dizi içerisine atayarak ekranda gösterin.
            string[] günler = { "Pazartesi", "Salı", "Çarşamba", "Perşembe", "Cuuma", "Cumartesi", "Pazar" };
            for (int i = 0; i < günler.Length; i++)
            {
                Console.WriteLine(günler[i]);
            }
            */







            /* 
           //Klavyeden girilen 10 adet sayıyı bir diziye atarak küçükten büyüğe sıralayın ve ekranda gösterin.
           int[] sayi = new int[10];
           for (int i = 0; i < sayi.Length; i++)
           {
               Console.Write("Klavyeden {0}. sayıyı girin:", i + 1);
               sayi[i] = Convert.ToInt32(Console.ReadLine());
           }

           Array.Sort(sayi);

           for (int i = 0; i < sayi.Length; i++)
           {
               Console.WriteLine(sayi[i]);
           }
           */








            /*  
            //Bir dizi içerisindeki tüm sayıları toplayarak ortalamasını bulun.
            int[] sayilar = { 1, 20, 59, 35, 46, 55 };
            double toplam = 0, ort = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam + sayilar[i];
            }
            ort = toplam / sayilar.Length;
            Console.WriteLine("Ortalama: " + ort);
            */





            /*
            //Alfabedeki tüm harfleri diziye atan ve sırayla yan yana yazdıran programı yapın.
            char[] alfabe = new char[26];
            int sira = 0;
            for (char i = 'a'; i <= 'z'; i++)
                {
                   alfabe[sira] = i;
                   Console.Write(alfabe[sira]);
                   sira++;
                }
            */










            /*
            //Klavyeden girilen 10 adet sayıdan 100’den büyük olanları bir diziye atan programı yapın.
            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {
                Console.Write("Klavyeden {0}. sayıyı girin:", i + 1);
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi > 100)
                    dizi[i] = sayi;
                
            }
            for (int i = 0; i < 10; i++)
            {
                if (dizi[i] != 0)
                {
                    Console.WriteLine(dizi[i]);
                }
            }
            */








            /*  //Rastgele üretilen 5 adet sayıyı büyükten küçüğe doğru alt alta gösterin.
            int[] dizi = new int[5];
            Random rastgele = new Random();

            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = rastgele.Next(0, 100);
                Console.Write(dizi[i]+" ");
            }
            Console.WriteLine();
            Array.Sort(dizi);
            Array.Reverse(dizi);
            for (int i = 0; i < dizi.Length; i++)
            {
                Console.WriteLine(dizi[i]);
            }
            */







            /* 
            //20 elemanlı dizi içine rastgele 1 - 100 arası sayılar gireceğiz.Senaryomuz şu şekilde olacak. 20 kişilik bir sınıfın almış olduğu sınav notları ve bu notlarla ilgili aşağıdaki işlemlerin gerçekleştirilmesi.

            // 1 - Geçen sayısını bulunuz. (Notu 50 ve üstü)

            // 2 - Kalan sayısını bulunuz. (Notu 50′ den düşük.

            // 3 - Notu 5 olan öğrenci sayısını bulunuz. (Notu 85 ve üstü)

            // 4 - Notu 3 olan öğrenci sayısını bulunuz. (Notu 60 - 70 arası)

            // 5 - En yüksek notu bulunuz.

            // 6 - En düşük notu bulunuz.

            // 7 - En düşük puan alan öğrencinin 2.sınavda alması gereken puanı bulunuz.

            // 8 - Sınıf ortalamasını bulunuz.

            // 9 - Sınıf ortalaması altında not alan öğrenci sayısını bulunuz.

            // 10 - Sınıf ortalamasının altında kalan puanların ortalamasını bulunuz.

            int gecenSayisi = 0, kalanSayisi = 0, besAlanSayisi = 0, sinifOrtalamasi = 0;
            int ortalamaAltiSayisi = 0, ucalanSayisi = 0, enYuksek, enDusuk;
            int enDusukKacAlmali, sinifOrtAltindakiOrt = 0, toplam = 0, toplam2 = 0;
            Random rnd = new Random();
            int[] sayilar = new int[20];

            Console.WriteLine("Yazılı Sonuçları");
            Console.WriteLine();
            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = rnd.Next(1, 100);
                Console.Write(sayilar[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("============================================================");

            for (int i = 0; i < 20; i++)
            {
                toplam += sayilar[i];
                if (sayilar[i] >= 50)
                {
                    gecenSayisi++;
                }
                if (sayilar[i] < 50)
                {
                    kalanSayisi++;
                }
                if (sayilar[i] >= 85)
                {
                    besAlanSayisi++;
                }
                if (sayilar[i] >= 60 && sayilar[i] < 70)
                {
                    ucalanSayisi++;
                }

            }
            sinifOrtalamasi = toplam / 20;

            for (int i = 0; i < 20; i++)
            {
                if (sayilar[i] < sinifOrtalamasi)
                {
                    toplam2 += sayilar[i];
                    ortalamaAltiSayisi++;
                }
            }

            sinifOrtAltindakiOrt = toplam2 / ortalamaAltiSayisi;

            Array.Sort(sayilar);
            enYuksek = sayilar[19];
            enDusuk = sayilar[0];
            enDusukKacAlmali = 100 - enDusuk;
            Console.WriteLine("Geçen Sayısı : " + gecenSayisi);
            Console.WriteLine("Kalan Sayısı : " + kalanSayisi);
            Console.WriteLine("5 Alan Sayısı : " + besAlanSayisi);
            Console.WriteLine("3 Alan Sayısı : " + ucalanSayisi);
            Console.WriteLine("En Yüksek Not : " + enYuksek);
            Console.WriteLine("En Düşük Not : " + enDusuk);
            Console.WriteLine("En Düşük Not Alan 2. Sınavda Kaç Almalı : " + enDusukKacAlmali);
            Console.WriteLine("Sınıf Genel Ortalaması : " + sinifOrtalamasi);
            Console.WriteLine("Sınıf Ortalaması Altındaki Not Sayısı : " + ortalamaAltiSayisi);
            Console.WriteLine("Sınıf Ortalaması Altında Kalan Kişileri Ortalaması : " + sinifOrtAltindakiOrt);
            Console.ReadKey();
            */










            /*  
            //20 elemanlı diziye rasgele - 100 ile + 100 arası sayılar atan ve daha sonra dizinin elemanlarını, pozitif sayı adetini, negatif sayı adetini ve işaretsiz sayı adetini ekranda gösteren örnek:

            int pozitif = 0;
            int negatif = 0;
            int notr = 0;
            Random rnd = new Random();

            int[] sayilar = new int[20];

            for (int i = 0; i < 20; i++)
            {
                sayilar[i] = rnd.Next(-100, 100);
            }

            foreach (int sayi in sayilar)
            {
                Console.WriteLine(sayi);
                if (sayi > 0)
                {
                    pozitif++;
                }
                else if (sayi < 0)
                {
                    negatif++;
                }
                else
                {
                    notr++;
                }
            }
            Console.WriteLine("Pozitif Sayı Adeti>>> " + pozitif);
            Console.WriteLine("Negatif Sayı Adeti>>> " + negatif);
            Console.WriteLine("İşaretsiz Sayı Adeti>>> " + notr);
            Console.ReadKey();
            */














            
        }
    }
}
