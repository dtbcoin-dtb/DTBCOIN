using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Request
{
    public class RelatedProductTestReq
    {
        public string name { get; set; }
        public ProductReq product { get; set; }
        public List<RealizingResourceTestReq> realizingResourceTest { get; set; }
    }
}
