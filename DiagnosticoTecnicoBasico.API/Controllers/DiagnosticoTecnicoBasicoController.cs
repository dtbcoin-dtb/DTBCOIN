using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DiagnosticoTecnicoBasico.Business;
using DiagnostivoTecnicoBasico.Model;
using DiagnostivoTecnicoBasico.Model.ResponseAPI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DiagnosticoTecnicoBasico.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiagnosticoTecnicoBasicoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ProductResponse>> GetDTBCompleto(string idSubscriber, string idDomicilio)
        {
            List<ProductResponse> responseApiList = new List<ProductResponse>();
            try
            {
                responseApiList = DTBBusiness.GetCustometSiteProductTest(idSubscriber, idDomicilio);
            }
            catch (Exception)
            {
                throw;
            }

            return responseApiList;
        }
    }
}