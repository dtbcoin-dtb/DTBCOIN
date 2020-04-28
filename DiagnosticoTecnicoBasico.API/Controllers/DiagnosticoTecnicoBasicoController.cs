using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DiagnosticoTecnicoBasico.Business;
using DiagnosticoTecnicoBasico.Common;
using DiagnostivoTecnicoBasico.Model;
//using DiagnostivoTecnicoBasico.Model.Error;
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
        public ActionResult<GenericResponse<Product>> GetDTBCompleto(string idSubscriber, string idDomicilio)
        {
            GenericResponse<Product> genericResponse = new GenericResponse<Product>();
            try
            {
                List<Product> responseApiList = DTBBusiness.GetCustometSiteProductTest(idSubscriber, idDomicilio);
                genericResponse.StatusCode = (int)HttpStatusCode.OK;
                genericResponse.ResponseData = responseApiList;
            }
            catch (Exception e)
            {
                genericResponse.StatusCode = (int)HttpStatusCode.InternalServerError;
                genericResponse.CustomMessage = CustomMessage.InternalServerError;
                genericResponse.ExceptionMessage = e.Message;

                Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            }

            return genericResponse;
        }
    }
}