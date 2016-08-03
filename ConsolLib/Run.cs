using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{


    public class Run
    {
        List<Okullar> okulListesi = new List<Okullar>();
        List<Ogretmenler> ogretmenListesi = new List<Ogretmenler>();
        List<Atananlar> atananListesi = new List<Atananlar>();
        public Run()
        {
            #region Okul Ekleme
            okulListesi.Add(new Okullar { Id = 1, okulAdi = "Cumhuriyet", okulSalon = 3, okulSinif = 4 });
            okulListesi.Add(new Okullar { Id = 2, okulAdi = "Mehmetcik", okulSalon = 2, okulSinif = 2 });
            okulListesi.Add(new Okullar { Id = 3, okulAdi = "Fatih", okulSalon = 2, okulSinif = 2 });
            okulListesi.Add(new Okullar { Id = 4, okulAdi = "Bismil", okulSalon = 3, okulSinif = 4 });
            #endregion
            
            // 30 Salon Başkanı, Gözetmen, Yedek Gözetmen   Atama
            // 24 Görevli Öğretmen, Yardımcı Görevli Öğretmen Atama
            
            #region Öğretmen Ekleme

            ogretmenListesi.Add(new Ogretmenler() { Id = 1, OkulId = 1, ogretmenAdi = "1Mehmet", ogretmenGorevYili = 1990 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 2, OkulId = 1, ogretmenAdi = "2Hasan", ogretmenGorevYili = 1991 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 3, OkulId = 4, ogretmenAdi = "3Ali", ogretmenGorevYili = 1992 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 4, OkulId = 4, ogretmenAdi = "4Barış", ogretmenGorevYili = 1993 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 5, OkulId = 4, ogretmenAdi = "5Barış", ogretmenGorevYili = 1994 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 6, OkulId = 4, ogretmenAdi = "6Cafer", ogretmenGorevYili = 1995 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 7, OkulId = 4, ogretmenAdi = "7Cafer", ogretmenGorevYili = 1996 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 8, OkulId = 3, ogretmenAdi = "8Cengiz", ogretmenGorevYili = 1997 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 9, OkulId = 3, ogretmenAdi = "9Ahmet", ogretmenGorevYili = 1998 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 10, OkulId = 3, ogretmenAdi = "11Murat", ogretmenGorevYili = 1999 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 11, OkulId = 3, ogretmenAdi = "12Murat", ogretmenGorevYili = 2000 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 12, OkulId = 4, ogretmenAdi = "13Cengiz", ogretmenGorevYili = 2001 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 13, OkulId = 2, ogretmenAdi = "14Ferah", ogretmenGorevYili = 2002 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 14, OkulId = 2, ogretmenAdi = "15Aziz", ogretmenGorevYili = 2003 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 15, OkulId = 2, ogretmenAdi = "16Ferah", ogretmenGorevYili = 2004 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 16, OkulId = 1, ogretmenAdi = "17Aziz", ogretmenGorevYili = 2005 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 17, OkulId = 2, ogretmenAdi = "17Savaş", ogretmenGorevYili = 2006 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 18, OkulId = 1, ogretmenAdi = "18Vedat", ogretmenGorevYili = 2007 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 19, OkulId = 1, ogretmenAdi = "19Vedat", ogretmenGorevYili = 2008 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 20, OkulId = 1, ogretmenAdi = "20Savaş", ogretmenGorevYili = 2009 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 21, OkulId = 1, ogretmenAdi = "21Vedat", ogretmenGorevYili = 2010 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 22, OkulId = 4, ogretmenAdi = "22Savaş", ogretmenGorevYili = 2011 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 23, OkulId = 1, ogretmenAdi = "23Vedat", ogretmenGorevYili = 2010 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 24, OkulId = 4, ogretmenAdi = "24Savaş", ogretmenGorevYili = 2011 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 25, OkulId = 1, ogretmenAdi = "25Mehmet", ogretmenGorevYili = 2013 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 26, OkulId = 1, ogretmenAdi = "26Hasan", ogretmenGorevYili = 2014 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 27, OkulId = 4, ogretmenAdi = "27Ali", ogretmenGorevYili = 2015 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 28, OkulId = 4, ogretmenAdi = "28Barış", ogretmenGorevYili = 2016 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 29, OkulId = 4, ogretmenAdi = "29Barış", ogretmenGorevYili = 2017 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 30, OkulId = 4, ogretmenAdi = "30Cafer", ogretmenGorevYili = 2018 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 31, OkulId = 4, ogretmenAdi = "31Cafer", ogretmenGorevYili = 2019 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 32, OkulId = 3, ogretmenAdi = "32Cengiz", ogretmenGorevYili = 2020 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 33, OkulId = 3, ogretmenAdi = "33Ahmet", ogretmenGorevYili = 2021 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 34, OkulId = 3, ogretmenAdi = "34Murat", ogretmenGorevYili = 2022 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 35, OkulId = 3, ogretmenAdi = "35Murat", ogretmenGorevYili = 2023 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 36, OkulId = 3, ogretmenAdi = "36Cengiz", ogretmenGorevYili = 2024 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 37, OkulId = 2, ogretmenAdi = "37Ferah", ogretmenGorevYili = 2025 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 38, OkulId = 2, ogretmenAdi = "38Aziz", ogretmenGorevYili = 2026 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 39, OkulId = 2, ogretmenAdi = "39Ferah", ogretmenGorevYili = 2027 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 40, OkulId = 1, ogretmenAdi = "40Aziz", ogretmenGorevYili = 2028 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 41, OkulId = 2, ogretmenAdi = "41Savaş", ogretmenGorevYili = 2029 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 42, OkulId = 1, ogretmenAdi = "42Vedat", ogretmenGorevYili = 2030 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 43, OkulId = 1, ogretmenAdi = "43Vedat", ogretmenGorevYili = 2031 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 44, OkulId = 1, ogretmenAdi = "44Savaş", ogretmenGorevYili = 2032 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 45, OkulId = 1, ogretmenAdi = "45Vedat", ogretmenGorevYili = 2033 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 46, OkulId = 3, ogretmenAdi = "46Savaş", ogretmenGorevYili = 2034 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 47, OkulId = 1, ogretmenAdi = "47Vedat", ogretmenGorevYili = 2035 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 48, OkulId = 4, ogretmenAdi = "48Savaş", ogretmenGorevYili = 2036 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 49, OkulId = 1, ogretmenAdi = "49Vedat", ogretmenGorevYili = 2037 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 50, OkulId = 2, ogretmenAdi = "50Vedat", ogretmenGorevYili = 2038 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 51, OkulId = 4, ogretmenAdi = "51Savaş", ogretmenGorevYili = 2039 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 52, OkulId = 4, ogretmenAdi = "52Vedat", ogretmenGorevYili = 2040 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 53, OkulId = 2, ogretmenAdi = "53Savaş", ogretmenGorevYili = 2041 });
            ogretmenListesi.Add(new Ogretmenler() { Id = 54, OkulId = 4, ogretmenAdi = "54Vedat", ogretmenGorevYili = 2042 });


            #endregion
        }

        public void Listeler()
        {
            Console.WriteLine("Okullar\nId \t Okul Adı \t Okul Salonu \t Okul Sınıfı");
            okulListesi.ToList().ForEach(x => Console.WriteLine(x.Id + " \t " + x.okulAdi + " \t " + x.okulSalon + " \t " + x.okulSinif));
            Console.WriteLine("Ogretmenler\nId \t Okul Id \t Ogretmen Adı \t Gorev Yili");
            ogretmenListesi.ToList().ForEach(x => Console.WriteLine(x.Id + " \t " + x.OkulId + " \t " + x.ogretmenAdi + " \t " + x.ogretmenGorevYili));

        }

        public void Atama()
        {
            List<Ogretmenler> tekrar = new List<Ogretmenler>();

            int ogretmenId = 0;                  // Ogretmen Yıllarını tutar
            bool tekrarKontrol = true;           
            bool after = false;

            #region Salon Başkanı
            
            okulListesi.ToList().ForEach(x =>
               {

                   int i = 0;
                   for (i = 0; i < x.okulSalon; i++)
                   {
                       ogretmenId = ogretmenListesi.Where(z => z.ogretmenGorevYili > ogretmenId).Min(z => z.ogretmenGorevYili);
                       var kontrol = ogretmenListesi.FirstOrDefault(s => s.ogretmenGorevYili == ogretmenId);
                       if (kontrol.OkulId != x.Id)
                       {
                           atananListesi.Add(new Atananlar { gorev = "Salon Başkanı", okulId = x.Id, ogretmenId = kontrol.Id });
                           if (after)
                           {
                               if (tekrar.Count != 0)
                               {
                                   int afteri = 0;
                                   tekrar.ToList().ForEach(z =>
                                   {
                                       if (z.OkulId != x.Id)
                                       {
                                           if ((x.okulSalon - 1) != afteri)
                                           {
                                               atananListesi.Add(new Atananlar() { gorev = "Salon Başkanı", okulId = x.Id, ogretmenId = z.Id });
                                               tekrar.Remove(tekrar.FirstOrDefault(s => s.Id == z.Id));
                                               afteri += 1;
                                           }
                                           i += 1;
                                       }
                                   });
                               }
                               after = false;
                           }

                       }
                       else
                       {
                           tekrar.Add(kontrol);

                           i -= 1;

                       }
                   }
                   after = true;

               });
            #endregion

            #region Gözetmen

            tekrarKontrol = true;
            after = false;

            okulListesi.ToList().ForEach(x =>
            {

                int i = 0;
                for (i = 0; i < x.okulSalon; i++)
                {
                    ogretmenId = ogretmenListesi.Where(z => z.ogretmenGorevYili > ogretmenId && z.ogretmenAdi != "Vedat").Min(z => z.ogretmenGorevYili);
                    var kontrol = ogretmenListesi.FirstOrDefault(s => s.ogretmenGorevYili == ogretmenId);
                    if (kontrol.OkulId != x.Id)
                    {
                        atananListesi.Add(new Atananlar { gorev = "Gözetmen", okulId = x.Id, ogretmenId = kontrol.Id });
                        if (after)
                        {
                            if (tekrar.Count != 0)
                            {
                                int afteri = 0;
                                tekrar.ToList().ForEach(z =>
                                {
                                    if (z.OkulId != x.Id)
                                    {
                                        if ((x.okulSalon - 1) != afteri)
                                        {
                                            atananListesi.Add(new Atananlar() { gorev = "Gözetmen", okulId = x.Id, ogretmenId = z.Id });
                                            tekrar.Remove(tekrar.FirstOrDefault(s => s.Id == z.Id));
                                            afteri += 1;
                                        }
                                        i += 1;
                                    }

                                });
                            }
                            after = false;
                        }

                    }
                    else
                    {
                        tekrar.Add(kontrol);

                        i -= 1;

                    }
                }
                after = true;

            });



            #endregion

            #region Yardımcı Gözetmen

            tekrarKontrol = true;
            after = false;

            okulListesi.ToList().ForEach(x =>
            {
                int i = 0;
                for (i = 0; i < x.okulSalon; i++)
                {
                    ogretmenId = ogretmenListesi.Where(z => z.ogretmenGorevYili > ogretmenId).Min(z => z.ogretmenGorevYili);
                    var kontrol = ogretmenListesi.FirstOrDefault(s => s.ogretmenGorevYili == ogretmenId);
                    if (kontrol.OkulId != x.Id)
                    {
                        atananListesi.Add(new Atananlar { gorev = "Gözetmen Yardımcısı", okulId = x.Id, ogretmenId = kontrol.Id });
                        if (after)
                        {
                            if (tekrar.Count != 0)
                            {
                                int afteri = 0;
                                tekrar.ToList().ForEach(z =>
                                {
                                    if (z.OkulId != x.Id)
                                    {
                                        if ((x.okulSalon - 1) != afteri)
                                        {
                                            atananListesi.Add(new Atananlar() { gorev = "Gözetmen Yardımcısı", okulId = x.Id, ogretmenId = z.Id });
                                            tekrar.Remove(tekrar.FirstOrDefault(s => s.Id == z.Id));
                                            afteri += 1;
                                        }
                                        i += 1;
                                    }
                                });
                            }
                            after = false;
                        }
                    }
                    else
                    {
                        tekrar.Add(kontrol);
                        i -= 1;
                    }
                }
                after = true;
            });

            #endregion

            #region Görevli Öğretmen

            tekrarKontrol = true;
            after = false;

            okulListesi.ToList().ForEach(x =>
            {
                int i = 0;
                for (i = 0; i < x.okulSinif; i++)
                {
                    ogretmenId = ogretmenListesi.Where(z => z.ogretmenGorevYili > ogretmenId).Min(z => z.ogretmenGorevYili);
                    var kontrol = ogretmenListesi.FirstOrDefault(s => s.ogretmenGorevYili == ogretmenId);
                    if (kontrol.OkulId != x.Id)
                    {
                        atananListesi.Add(new Atananlar { gorev = "Görevli Öğretmen", okulId = x.Id, ogretmenId = kontrol.Id });
                        if (after)
                        {
                            if (tekrar.Count != 0)
                            {
                                int afteri = 0;
                                tekrar.ToList().ForEach(z =>
                                {
                                    if (z.OkulId != x.Id)
                                    {
                                        if ((x.okulSalon - 1) != afteri)
                                        {
                                            atananListesi.Add(new Atananlar() { gorev = "Görevli Öğretmen", okulId = x.Id, ogretmenId = z.Id });
                                            tekrar.Remove(tekrar.FirstOrDefault(s => s.Id == z.Id));
                                            afteri += 1;
                                        }
                                        i += 1;
                                    }
                                });
                            }
                            after = false;
                        }
                    }
                    else
                    {
                        tekrar.Add(kontrol);
                        i -= 1;
                    }
                }
                after = true;
            });


            #endregion

            #region Yardımcı Görevli Öğretmen

            tekrarKontrol = true;
            after = false;

            okulListesi.ToList().ForEach(x =>
            {
                int i = 0;
                for (i = 0; i < x.okulSinif; i++)
                {
                    if (ogretmenId != ogretmenListesi.Max(z => z.ogretmenGorevYili))
                    {
                        ogretmenId = ogretmenListesi.Where(z => z.ogretmenGorevYili > ogretmenId).Min(z => z.ogretmenGorevYili);
                        var kontrol = ogretmenListesi.FirstOrDefault(s => s.ogretmenGorevYili == ogretmenId);
                        if (kontrol.OkulId != x.Id)
                        {
                            atananListesi.Add(new Atananlar { gorev = "Yardımcı Görevli Öğretmen", okulId = x.Id, ogretmenId = kontrol.Id });
                            if (after)
                            {
                                if (tekrar.Count != 0)
                                {
                                    int afteri = 0;
                                    tekrar.ToList().ForEach(z =>
                                    {
                                        if (z.OkulId != x.Id)
                                        {
                                            if ((x.okulSalon - 1) != afteri)
                                            {
                                                atananListesi.Add(new Atananlar() { gorev = "Yardımcı Görevli Öğretmen", okulId = x.Id, ogretmenId = z.Id });
                                                tekrar.Remove(tekrar.FirstOrDefault(s => s.Id == z.Id));
                                                afteri += 1;
                                            }
                                            i += 1;
                                        }
                                    });
                                }
                                after = false;
                            }
                        }
                        else
                        {
                            tekrar.Add(kontrol);
                            i -= 1;
                        }
                    }
                    else
                    {
                        if (tekrar.Count != 0)
                        {
                            int afteri = 0;
                            tekrar.ToList().ForEach(z =>
                            {
                                if ((x.okulSalon - 1) != afteri)
                                {
                                    atananListesi.Add(new Atananlar() { gorev = "Yardımcı Görevli Öğretmen", okulId = x.Id, ogretmenId = z.Id });
                                    tekrar.Remove(tekrar.FirstOrDefault(s => s.Id == z.Id));
                                    afteri += 1;
                                }
                                i += 1;
                            });
                        }
                        after = false;
                        Console.WriteLine("log :Hata " + ogretmenId);
                    }
                }
                after = true;
            });

            #endregion



            Console.WriteLine(atananListesi.Count.ToString());
            var son = ogretmenListesi.Max(x => x.ogretmenGorevYili);
            //okulListesi.ToList().ForEach(x =>
            //{
            //    if (son != ogretmenId)
            //    {
            //        for (int i = 0; i < x.okulSinif; i++)
            //        {
            //            ogretmenId = ogretmenListesi.Where(z => z.ogretmenGorevYili > ogretmenId).Min(z => z.ogretmenGorevYili);
            //            var kontrol = ogretmenListesi.FirstOrDefault(s => s.ogretmenGorevYili == ogretmenId);
            //            if (kontrol != null)
            //            {
            //                atananListesi.Add(new Atananlar { gorev = "", okulId = x.Id, ogretmenId = kontrol.Id });
            //            }
            //        }
            //    }
            //    else
            //    {
            //        return;
            //    }
            //});

        }

        public void AtananListesi()
        {
            Console.WriteLine("Atanan Öğretmenler");
            atananListesi.ToList().ForEach(x => Console.WriteLine(x.Id + "\t" + x.ogretmenId + "\t" + x.okulId + "\t" + x.gorev));

        }

        public void AtamaListKontrol()
        {

            Console.WriteLine("Full Atama Sonucları");

            atananListesi.ToList().ForEach(x =>
            {

                okulListesi.Where(z => z.Id == x.okulId).ToList().ForEach(z =>
                {
                    Console.Write(z.okulAdi +
                         " \t " + z.okulSalon +
                         " \t " + z.Id);
                    ogretmenListesi.Where(s => s.Id == x.ogretmenId)
                        .ToList()
                        .ForEach(s =>
                            {
                                Console.WriteLine("\t" + s.OkulId +
                                         " \t " + s.ogretmenAdi +
                                         " \t " + s.ogretmenGorevYili +
                                         "\t " + x.gorev);
                            });
                });

            });

        }

    }
}
