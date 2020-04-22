using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class TolerancePeriod
    {
        public int amount { get; set; }
        public string units { get; set; }
        public string baseType { get; set; }
        public string schemaLocation { get; set; }
        public string type { get; set; }
    }
}
