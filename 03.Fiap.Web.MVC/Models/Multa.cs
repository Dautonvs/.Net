using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _03.Fiap.Web.MVC.Models
{
    public class Multa
    {
        public string Nivel { get; set; }
        public DateTime Data { get; set; }

        public string  Endereco { get; set; }

        public bool Notificado { get; set; }

        public decimal Valor { get; set; }

        public string Placa { get; set; }


    }
}