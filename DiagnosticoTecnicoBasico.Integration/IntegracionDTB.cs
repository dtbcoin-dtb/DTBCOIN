using DiagnosticoTecnicoBasico.Common;
using DiagnostivoTecnicoBasico.Model.ConsultaDTB;
using DiagnostivoTecnicoBasico.Model.Request;
using DiagnostivoTecnicoBasico.Model.Response;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DiagnosticoTecnicoBasico.Integration
{
    public class IntegracionDTB
    {
        private static string urlConsulta = "http://apicore31-pdd-portaldiagnostico-dev.apps-rp.cloudteco.com.ar/swagger";

        public static DTBResponseEntity GetConsultaDTB(string idSubscriber, string idDomicilio)
        {
            DTBResponseEntity dTBResponseEntity = null;

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //client.BaseAddress = new Uri("http://apicore31-pdd-portaldiagnostico-dev.apps-rp.cloudteco.com.ar/swagger");
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync(urlConsulta).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        var data = response.Content.ReadAsStringAsync().Result;
                        dTBResponseEntity = JsonConvert.DeserializeObject<DTBResponseEntity>(data);
                    }

                    return dTBResponseEntity;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static ResponseDTB GetCustometSiteProductTest(RequestDTB requestDTB, string idUnico)
        {
            IRestResponse<ResponseDTB> response = null;
            try
            {
                var client = new RestClient("{{Service_Test}}/tmf-api/customerSiteProductsTestManagement/v1/customerSiteProductsTest");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("X-Requesting-Username", "u900779");
                request.AddHeader("X-Requesting-Application", "Diagnostico");
                request.AddHeader("X-Requesting-ProcessId", idUnico);
                request.AddHeader("X-Requesting-Async", "false");
                request.AddHeader("Content-Type", "application/json;charset=utf-8");
                //request.AddParameter("application/json;charset=utf-8", "{\n    \"Ejemplo de Request para el DTB\": {\n        \"value\": {\n            \"name\": \"id-autogenerado-en-aplicativo-externo\",\n            \"testSpecification\": {\n                \"id\": 1,\n                \"name\": \"DTB\",\n                \"version\": \"V1\"\n            },\n            \"customer\": [\n                {\n                    \"id\": \"9989994\"\n                }\n            ],\n            \"place\": [\n                {\n                    \"id\": \"34017752\"\n                }\n            ],\n            \"startDateTime\": \"2020-03-30 03:03:03Z\",\n            \"characteristic\": [\n                {\n                    \"name\": \"username\",\n                    \"value\": \"user\"\n                },\n                {\n                    \"name\": \"application\",\n                    \"value\": \"app\"\n                }\n            ],\n            \"relatedProductTest\": [\n                {\n                    \"name\": \"DTB TELEFONÍA\",\n                    \"product\": {\n                        \"id\": 1,\n                        \"name\": \"TELEFONÍA\"\n                    },\n                    \"realizingResourceTest\": [\n                        {\n                            \"name\": \"eMTA ToIP-Sagemcom_3686-D06EDE8E9B46-??????????\",\n                            \"characteristic\": [\n                                {\n                                    \"name\": \"macAddress\",\n                                    \"value\": \"D06EDE8E9B46\"\n                                },\n                                {\n                                    \"name\": \"nroSerie\",\n                                    \"value\": \"????????????\"\n                                },\n                                {\n                                    \"name\": \"numeroAbonado\",\n                                    \"value\": 3874968171\n                                },\n                                {\n                                    \"name\": \"velocidadContratada\",\n                                    \"value\": \"50MB\"\n                                },\n                                {\n                                    \"name\": \"tipoEquipo\",\n                                    \"value\": \"eMTA ToIP\"\n                                },\n                                {\n                                    \"name\": \"marca\",\n                                    \"value\": \"Sagemcom\"\n                                },\n                                {\n                                    \"name\": \"modelo\",\n                                    \"value\": \"3686\"\n                                }\n                            ]\n                        }\n                    ]\n                },\n                {\n                    \"name\": \"DTB TV POR CABLE\",\n                    \"product\": {\n                        \"id\": 14213171,\n                        \"name\": \"TV POR CABLE\"\n                    },\n                    \"realizingResourceTest\": [\n                        {\n                            \"name\": \"DECO HD-ARRIS_DCX-3210-M61410IA2425-?????????\",\n                            \"characteristic\": [\n                                {\n                                    \"name\": \"macAddress\",\n                                    \"value\": \"??????????\"\n                                },\n                                {\n                                    \"name\": \"nroSerie\",\n                                    \"value\": \"M61410IA2425\"\n                                },\n                                {\n                                    \"name\": \"tipoEquipo\",\n                                    \"value\": \"DECO HD\"\n                                },\n                                {\n                                    \"name\": \"marca\",\n                                    \"value\": \"ARRIS Enterprises, Inc.\"\n                                },\n                                {\n                                    \"name\": \"modelo\",\n                                    \"value\": \"DCX-3210\"\n                                }\n                            ]\n                        }\n                    ]\n                },\n                {\n                    \"name\": \"DTB INTERNET CABLEMODEM\",\n                    \"product\": {\n                        \"id\": 3,\n                        \"name\": \"INTERNET CABLEMODEM\"\n                    },\n                    \"realizingResourceTest\": [\n                        {\n                            \"name\": \"Cablemodem WiFi-Sagemcom_3686-D06EDE8E9B46-??????????\",\n                            \"characteristic\": [\n                                {\n                                    \"name\": \"macAddress\",\n                                    \"value\": \"D06EDE8E9B46\"\n                                },\n                                {\n                                    \"name\": \"nroSerie\",\n                                    \"value\": \"???????????\"\n                                },\n                                {\n                                    \"name\": \"velocidadContratada\",\n                                    \"value\": \"50MB\"\n                                },\n                                {\n                                    \"name\": \"tipoEquipo\",\n                                    \"value\": \"Cablemodem WiFi\"\n                                },\n                                {\n                                    \"name\": \"marca\",\n                                    \"value\": \"Sagemcom\"\n                                },\n                                {\n                                    \"name\": \"modelo\",\n                                    \"value\": \"3686\"\n                                }\n                            ]\n                        }\n                    ]\n                }\n            ]\n        }\n    }\n}", ParameterType.RequestBody);
                request.AddParameter("application/json;charset=utf-8", requestDTB, ParameterType.RequestBody);
                response = client.Execute<ResponseDTB>(request);
            }
            catch (Exception e)
            {
                throw e;
            }

            return response.Data;
        }
    }
}
