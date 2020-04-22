using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Request
{
    public class RequestDTB
    {
        public string name { get; set; }
        public TestSpecificationReq testSpecification { get; set; }
        public CustomerReq customer { get; set; }
        public PlaceReq place { get; set; }
        public string mode { get; set; }
        public string startDateTime { get; set; }
        public List<CharacteristicReq> characteristic { get; set; }
        public List<RelatedProductTestReq> relatedProductTest { get; set; }
    }
}
