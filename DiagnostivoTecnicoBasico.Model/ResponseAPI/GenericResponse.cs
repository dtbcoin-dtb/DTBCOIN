using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.ResponseAPI
{
    public class GenericResponse<T> where T : class
    {
        public int StatusCode { get; set; }
        public string CustomMessage { get; set; }
        public string ExceptionMessage { get; set; }
        public List<T> ResponseData { get; set; }
    }
}
