using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ConsultaDTB
{
    public class DTBResponseEntity
    {
        public string TipoDiagnostico { get; set; }
        public string SuscriberID { get; set; }
        public string AddressId { get; set; }
        public DTBProductoReferencia Productos { get; set; }
    }
}
