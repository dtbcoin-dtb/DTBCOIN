using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Request
{
    public class RealizingResourceTestReq
    {
        public string name { get; set; }
        public List<CharacteristicReq> characteristic { get; set; }
    }
}
