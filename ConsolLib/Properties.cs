using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
  
    public class Okullar
    {
        public int Id { get; set; }
        public string okulAdi { get; set; }
        public int okulSalon { get; set; }
        public int okulSinif { get; set; }
    }

    public class Ogretmenler
    {
        public int Id { get; set; }
        public int OkulId { get; set; } // Görev Okulu Okullar.Id
        public string ogretmenAdi { get; set; }
        public int ogretmenGorevYili { get; set; }
    }

    public class Atananlar
    {
        public int Id { get; set; }
        public int okulId { get; set; }
        public int ogretmenId { get; set; }
        public string gorev { get; set; }
    }
}
