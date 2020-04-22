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
        public static List<ProductResponse> GetCustometSiteProductTest(string idSubscriber, string idDomicilio)
        {
            List<ProductResponse> productResponseList = new List<ProductResponse>();
            string idUnico = Utilities.GenerarIdUnicoDiagnostico();
            DTBResponseEntity consultaDTB = IntegracionDTB.GetConsultaDTB(idSubscriber, idDomicilio);

            RequestDTB requestDTB = DTBLogic.GetRequestDTB(consultaDTB, idUnico, idSubscriber, idDomicilio);
            ResponseDTB response = IntegracionDTB.GetCustometSiteProductTest(requestDTB, idUnico);

            productResponseList = DTBLogic.GetResponseDTB(response);

            return productResponseList;
        }

    }
}
