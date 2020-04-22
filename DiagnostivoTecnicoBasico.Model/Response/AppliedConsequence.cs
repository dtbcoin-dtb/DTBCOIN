using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class AppliedConsequence
    {
        public string appliedAction { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public bool repeatAction { get; set; }
        public string baseType { get; set; }
        public string schemaLocation { get; set; }
        public  string type { get; set; }
    }
}
