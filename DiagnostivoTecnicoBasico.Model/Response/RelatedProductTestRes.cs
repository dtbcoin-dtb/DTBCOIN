using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class RelatedProductTestRes
    {
        public string name { get; set; }
        public List<TestDiagnosis> testDiagnosis { get; set; }
        public Product product { get; set; }
        public List<RealizingResourceTest> realizingResourceTest { get; set; }
    }
}
