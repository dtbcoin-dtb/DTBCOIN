using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class Note
    {
        public string author { get; set; }
        public DateTime date { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public Error error { get; set; }
        public string schemaLocation { get; set; }
        public string baseType { get; set; }
    }
}
