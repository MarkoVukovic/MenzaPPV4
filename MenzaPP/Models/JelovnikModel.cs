using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MenzaPP.Models
{
    public class JelovnikModel
    {
        public int id { get; set; }
        public DateTime datum { get; set; }
        public string jelovnikContent { get; set; }
        public int idMenza { get; set; }

    }
}