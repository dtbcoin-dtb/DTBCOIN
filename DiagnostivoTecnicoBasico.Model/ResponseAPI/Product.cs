using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class Product
    {
        public string name { get; set; }
        public List<Servicio> servicio { get; set; }
    }
}
