using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIM2019.Models
{
    public class Veiculos
    {
        [Key]
        public int Codigo { get; set; }

        public string Modelo { get; set; }

        public string Marca { get; set; }

        public string Placa { get; set; }

        public float Km { get; set; }

    }
}