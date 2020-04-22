using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class Service
    {
        public string id { get; set; }
        public string href { get; set; }
        public string name { get; set; }
        public string baseType { get; set; }
        public string schemaLocation { get; set; }
        public string type { get; set; }
        public string referredType { get; set; }
    }
}
