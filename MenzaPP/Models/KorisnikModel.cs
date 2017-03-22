using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MenzaPP.Models
{
    public class KorisnikModel
    {
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string brojIksice { get; set; }
        public string email { get; set; }
        public string grad { get; set; }
        int idFaks { get; set; }
        bool admin { get; set; }
    }
}