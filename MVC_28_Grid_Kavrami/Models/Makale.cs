using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_28_Grid_Kavrami.Models
{
    public class Makale
    {
        public int id { get; set; }
        public string baslik { get; set; }
        public string yazar_ismi { get; set; }
        public DateTime yayinlama_tarihi { get; set; }
        public string kategorisi { get; set; }
        public string konusu { get; set; }
        public string kaynakca { get; set; }
    }
}