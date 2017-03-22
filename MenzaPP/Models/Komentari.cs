using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenzaPP.Models
{
    public class Komentari
    {
        public int id { get; set; }
        public string komentarContent{ get; set; }
        public int idMenza { get; set; }
        public int idKorisnik { get; set; }
        public DateTime vrijemeDatum { get; set; }
    }
}