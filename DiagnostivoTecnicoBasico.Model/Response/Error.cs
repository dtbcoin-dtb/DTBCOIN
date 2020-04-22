using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class Error
    {
        public string code { get; set; }
        public string message { get; set; }
        public string reason { get; set; }
    }
}
