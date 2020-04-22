using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class ProductResponse
    {
        public string name { get; set; }
        public List<ServicioResponse> servicio { get; set; }
    }
}
