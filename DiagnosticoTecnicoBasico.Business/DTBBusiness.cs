using DiagnosticoTecnicoBasico.Common;
using DiagnosticoTecnicoBasico.Integration;
using DiagnostivoTecnicoBasico.Model;
using DiagnostivoTecnicoBasico.Model.ConsultaDTB;
using DiagnostivoTecnicoBasico.Model.Request;
using DiagnostivoTecnicoBasico.Model.Response;
using DiagnostivoTecnicoBasico.Model.ResponseAPI;
using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnosticoTecnicoBasico.Business
{
    public class DTBBusiness
    {
        public static List<DiagnostivoTecnicoBasico.Model.ResponseAPI.Product> GetCustometSiteProductTest(string idSubscriber, string idDomicilio)
        {
            List<DiagnostivoTecnicoBasico.Model.ResponseAPI.Product> productResponseList = new List<DiagnostivoTecnicoBasico.Model.ResponseAPI.Product>();
            string idUnico = Utilities.GenerarIdUnicoDiagnostico();
            try
            {
                DTBResponseEntity consultaDTB = IntegracionDTB.GetConsultaDTB(idSubscriber, idDomicilio);
                RequestDTB requestDTB = DTBLogic.GetRequestDTB(consultaDTB, idUnico, idSubscriber, idDomicilio);
                ResponseDTB response = IntegracionDTB.GetCustometSiteProductTest(requestDTB, idUnico);
                productResponseList = DTBLogic.GetResponseDTB(response);
            }
            catch (Exception e)
            {
                throw e;
            }

            return productResponseList;
        }

    }
}
