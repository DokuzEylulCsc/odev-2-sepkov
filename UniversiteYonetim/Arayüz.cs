using System;
using System.Collections.Generic;
using System.Text;

namespace UniversiteYonetim
{
    class Arayüz
    {
        public Arayüz()
        {
            Başla();
        }
        private void Başla()
        {
            char girdi;
            Console.Clear();
            Console.WriteLine("-----Üniversite Yönetim Uygulaması V0.1-----");
            Console.WriteLine("1-) Üniversite alt işlemleri");
            Console.WriteLine("2-) Öğrenci alt işlemleri");
            Console.WriteLine("3-) Yapılan İşlemler");
            Console.WriteLine();
            Console.WriteLine("9-) Çıkış");
            girdi = Girdi.GirdiKarakter();
            switch (girdi)
            {
                case '1':
                    UniversiteArayüz();
                    Çıkış();
                    break;

                case '2':
                    OgrenciArayüz();
                    Çıkış();
                    break;

                case '3':
                    İşlemListesi();
                    Çıkış();
                    break;

                case '9':
                    Çıkış();
                    break;
                default:
                    Çıkış();
                    break;
            }
        }

        private void UniversiteArayüz()
        {
            char girdi;
            Console.Clear();
            Console.WriteLine("-----Üniversite Yönetim Uygulaması V0.1-----");
            Console.WriteLine("      >>>>>  Üniversite Yönetimi  <<<<<<");
            Console.WriteLine("1-) Fakülte alt işlemleri");
            Console.WriteLine("2-) Bölüm alt işlemleri");
            Console.WriteLine("3-) Ders alt işlemleri");
            Console.WriteLine("4-) Şube alt işlemleri");
            Console.WriteLine("5-) Öğretim Görevlisi alt işlemleri");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("9-) Ana Menü");
            girdi = Girdi.GirdiKarakter();
            switch (girdi)
            {
                case '1':
                    Fakülte fakülte = new Fakülte();
                    break;

                case '2':
                    Bölüm bölüm = new Bölüm();
                    break;

                case '3':
                    Ders ders = new Ders();
                    break;

                case '4':
                    Şube şube = new Şube();
                    break;

                case '5':
                    OgretimElemani ogretimElemani = new OgretimElemani();
                    break;

                case '9':
                    Başla();
                    break;

                default:
                    break;
            }
        }

        private void OgrenciArayüz()
        {
            char girdi;
            Console.Clear();
            Console.WriteLine("-----Üniversite Yönetim Uygulaması V0.1-----");
            Console.WriteLine("      >>>>>  Öğrenci Yönetimi  <<<<<<");
            Console.WriteLine("1-) Lisans alt işlemleri");
            Console.WriteLine("2-) Yüksek Lisans alt işlemleri");
            Console.WriteLine("3-) Doktora alt işlemleri");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("9-) Ana Menü");
            girdi = Girdi.GirdiKarakter();
            switch (girdi)
            {
                case '1':
                    Lisans lisans= new Lisans();
                    break;

                case '2':
                    YuksekLisans yuksekLisans = new YuksekLisans();
                    break;

                case '3':
                    Doktora doktora = new Doktora();
                    break;

                case '9':
                    Başla();
                    break;

                default:
                    break;
            }

        }

        private void İşlemListesi()
        {
            Console.Clear();
            Console.WriteLine("-----Üniversite Yönetim Uygulaması V0.1-----");
            Console.WriteLine("      >>>>>  İşlem Yönetimi  <<<<<<");
            Console.ReadLine();
        }

        public void Çıkış()
        {
            char girdi;
            Console.Clear();
            Console.WriteLine("Ana Menü için 1'e çıkış için herhangi bir tuşa basın");
            girdi = Girdi.GirdiKarakter();
            if (girdi == '1') Başla();
            else Environment.Exit(0);
        }
    }
}
