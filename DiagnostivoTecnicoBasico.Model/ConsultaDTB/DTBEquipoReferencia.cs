using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ConsultaDTB
{
    public class DTBEquipoReferencia
    {
        public string MAC { get; set; }
        public string Serial { get; set; }
        public string NroLinea { get; set; }
        [JsonProperty("Tipo Equipo")]
        public string TipoEquipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }
}
