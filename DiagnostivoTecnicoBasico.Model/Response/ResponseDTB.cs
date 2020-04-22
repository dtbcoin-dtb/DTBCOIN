using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class ResponseDTB
    {
        public string id { get; set; }
        public string href { get; set; }
        public DateTime endDateTime { get; set; }
        public string mode { get; set; }
        public string name { get; set; }
        public DateTime startDateTime { get; set; }
        public string state { get; set; }
        public List<Characteristic> characteristic { get; set; }
        public TestSpecification testSpecification { get; set; }
        public Customer customer { get; set; }
        public Place place { get; set; }
        public List<RelatedProductTestRes> relatedProductTest { get; set; }
    }
}
