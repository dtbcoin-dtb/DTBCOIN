using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class RelatedServiceTest
    {
        public string name { get; set; }
        public List<RelatedEntity> relatedEntity { get; set; }
        public List<TestDiagnosis> testDiagnosis { get; set; }
    }
}
